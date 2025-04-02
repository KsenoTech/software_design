using BLL.Services;
using DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab3NLayer
{
    public partial class lab4 : Form
    {
        IOrderService orderService;
        IReportService reportService;
        IMotoService motoService;

        List<TypeDto> allTypes;
        List<MotoDto> allMotos;
        
        public lab4(IMotoService motoservice, IOrderService orderservice, IReportService reportservice)
        {
            orderService = orderservice;
            reportService = reportservice;
            motoService = motoservice;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            allTypes = motoService.GetTypes();
            loadMotos();
            loadOrders();
            // Заполнение комбобокса "Type" для отчета1.
            comboBoxManufReport1.DataSource = allTypes;
            comboBoxManufReport1.DisplayMember = "Name";
            comboBoxManufReport1.ValueMember = "Id";

        }

        private void loadOrders()
        {
            dataGridBindingSourceOrder.DataSource = orderService.GetAllOrders();
        }

        private void loadMotos()
        {
            allMotos = motoService.GetAllMotos();
            // Отображаем данные
            bindingSourceMoto.DataSource = allMotos;
            FillMotoComboboxForType();
        }

        private void FillMotoComboboxForType()
        {
            dataGridBindingSourceOrder.DataSource = orderService.GetAllOrders();
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DataSource = allTypes;
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).ValueMember = "Id";
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = reportService.ReportMotosOfType((int)comboBoxManufReport1.SelectedValue);
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

            dataGridViewReport2.DataSource = reportService.ExecuteSP((int)numericUpDown1.Value, (int)v0);

            v0 = -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //AddMotoForm f = new AddMotoForm(motoService);
            //if (f.ShowDialog() == DialogResult.OK)
            //    dataGridViewMoto.DataSource = motoService.GetAllMotos();

            AddMotoForm f = new AddMotoForm();
            f.comboBoxType.DataSource = allTypes;
            f.comboBoxType.DisplayMember = "Name";
            f.comboBoxType.ValueMember = "id_Type";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            MotoDto motoc = new MotoDto();
            motoc.id_Type_FK = (int)f.comboBoxType.SelectedValue;
            motoc.Color = f.textBoxColor.Text;
            motoc.Cost = (int)f.numericUpDown1Cost.Value;
            motoc.Model_name = f.textBoxModel.Text;
            motoc.Brand_name = f.textBoxBrand.Text;
            motoService.CreateMoto(motoc);
            allMotos = motoService.GetAllMotos();
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
            //if (hasSelectedRow(dataGridViewMoto))
            //{
            //    MotoDto motoc = (MotoDto)dataGridViewMoto.CurrentRow.DataBoundItem;
            //    AddMotoForm f = new AddMotoForm(motoService);
            //    if (f.ShowDialog() == DialogResult.OK)
            //        dataGridBindingSourceOrder.DataSource = orderService.GetAllOrders();
            //}
            int index = 0;
            //index = (int)dataGridViewMoto.SelectedRows.Count;
            //index = (int)dataGridViewMoto.CurrentRow.DataBoundItem;
            index = getSelectedRow(dataGridViewMoto);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewMoto[4, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                MotoDto ph = allMotos.Where(i => i.Id == id).FirstOrDefault();

                //int iq = ph1.id_Motorcycle;
                //MotoDto ph = allMotos.Where(i => i.id_Motorcycle == iq).FirstOrDefault();
                
                if (ph != null)
                {
                    AddMotoForm f = new AddMotoForm();
                    f.comboBoxType.DataSource = allTypes;
                    f.comboBoxType.DisplayMember = "Name";
                    f.comboBoxType.ValueMember = "id_Type";
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
                    motoService.UpdateMoto(ph);

                    MessageBox.Show("Объект обновлен");
                    bindingSourceMoto.DataSource = allMotos;// motoService.GetAllMotos();
                    //dataGridViewMoto.DataSource = motoService.GetAllMotos();
                }
                id = 0;
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
            index = 0;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewMoto);
            if (index != -1)
            {
                int id = 0;
                if (dataGridViewMoto[4, index].Value == null) return;
                bool converted = Int32.TryParse(dataGridViewMoto[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                motoService.DeleteMoto(id);
                dataGridViewMoto.DataSource = motoService.GetAllMotos();
            }
        }

        private void changeOrderButton_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridBindingSourceOrder))
            {
                OrderDto order = (OrderDto)dataGridBindingSourceOrder.CurrentRow.DataBoundItem;
                MakeOrderForm f = new MakeOrderForm(motoService, orderService, order);
                if (f.ShowDialog() == DialogResult.OK)
                    dataGridBindingSourceOrder.DataSource = orderService.GetAllOrders();
            }
        }
        
        private bool hasSelectedRow(DataGridView dataGridView)
        {
            return (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1);
        }

        private void createOrderButton_Click_1(object sender, EventArgs e)
        {
            MakeOrderForm f = new MakeOrderForm(motoService, orderService);
            if (f.ShowDialog() == DialogResult.OK)
                dataGridBindingSourceOrder.DataSource = orderService.GetAllOrders();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridBindingSourceOrder))
            {
                orderService.DeleteOrder(((OrderDto)dataGridBindingSourceOrder.CurrentRow.DataBoundItem).ID);
                loadOrders();
            }
        }
    }
}
