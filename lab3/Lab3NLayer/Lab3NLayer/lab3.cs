using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab3NLayer
{
    public partial class lab3 : Form
    {
        MotoService mtoService = new MotoService();
        OrderService orderService = new OrderService();
        List<TypeDto> allTypes;
        List<MotoDto> allMotos;
        public lab3()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            allTypes = mtoService.GetTypes();
            loadMotos();
            loadTypes();
            // Заполнение комбобокса "Type" для отчета1.
            comboBoxManufReport1.DataSource = allTypes;
            comboBoxManufReport1.DisplayMember = "Name";
            comboBoxManufReport1.ValueMember = "Id";

        }

        private void loadTypes()
        {
            bindingSourceTypes.DataSource = orderService.GetAllOrders();
        }

        private void loadMotos()
        {
            allMotos = mtoService.GetAllMotos();
            // Отображаем данные
            bindingSourceMoto.DataSource = allMotos;
            // Заполнение комбобокса "Производитель" в таблице "Товары".
            FillMotoComboboxForType();
        }

        private void FillMotoComboboxForType()
        {
            bindingSourceType.DataSource = orderService.GetAllOrders();
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DataSource = allTypes;
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).ValueMember = "Id";
        }

        private void buttonSaveMoto_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                mtoService.Save();
            }
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = ReportsService.ReportOrdersByMonth((int)comboBoxManufReport1.SelectedValue);
        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            int v0 = -1;                                        // v0 = 0 - есть, v0 = 1 - нет, v0 = 2 - выбор всех
            if (checkedListBox1.GetItemChecked(1))
                v0 = 0;
            if (checkedListBox1.GetItemChecked(0))
                v0 = 1;
            if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1))
                v0 = 2;

            dataGridViewReport2.DataSource = ReportsService.ExecuteSP((int)numericUpDown1.Value, (int)v0);

            v0 = -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMotoForm f = new AddMotoForm();
            f.comboBoxType.DataSource = allTypes;
            f.comboBoxType.DisplayMember = "Name";
            f.comboBoxType.ValueMember = "Id";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            MotoDto motoc = new MotoDto();
            motoc.Id = (int)f.comboBoxType.SelectedValue;
            motoc.Color = f.textBoxColor.Text;
            motoc.Cost = (int)f.numericUpDown1Cost.Value;
            motoc.Model_name = f.textBoxModel.Text;
            motoc.Brand_name = f.textBoxBrand.Text;
            mtoService.CreateMoto(motoc);
            allMotos = mtoService.GetAllMotos();
            bindingSourceMoto.DataSource = allMotos;
            MessageBox.Show("Новый объект добавлен");
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewMoto);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewMoto[4, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                MotoDto ph = allMotos.Where(i => i.Id == id).FirstOrDefault();
                if (ph != null)
                {
                    AddMotoForm f = new AddMotoForm();
                    f.comboBoxType.DataSource = allTypes;
                    f.comboBoxType.DisplayMember = "Name";
                    f.comboBoxType.ValueMember = "Id";
                    f.comboBoxType.SelectedValue = ph.id_Type_FK;
                    f.numericUpDown1Cost.Value = ph.Cost;
                    f.textBoxModel.Text = ph.Model_name;
                    f.textBoxBrand.Text = ph.Brand_name;
                    f.textBoxColor.Text = ph.Color;


                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    ph.Cost = (int)f.numericUpDown1Cost.Value;
                    ph.Model_name = f.textBoxModel.Text;
                    ph.Brand_name = f.textBoxBrand.Text;
                    ph.Color = f.textBoxColor.Text;
                    mtoService.UpdateMoto(ph);

                    MessageBox.Show("Объект обновлен");
                    bindingSourceMoto.DataSource = mtoService.GetAllMotos();
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewMoto);
            if (index != -1)
            {
                int id = 0;
                if (dataGridViewMoto[0, index].Value == null) return;
                bool converted = Int32.TryParse(dataGridViewMoto[4, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                mtoService.DeleteMoto(id);
                dataGridViewMoto.DataSource = mtoService.GetAllMotos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeOrderForm f = new MakeOrderForm();
            if (f.ShowDialog() == DialogResult.OK)
                bindingSourceType.DataSource = orderService.GetAllOrders();
        }

    }
}
