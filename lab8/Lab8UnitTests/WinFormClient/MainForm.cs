using DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4DI
{

    public partial class MainForm : Form
    {
        IOrderService orderService;
        IReportService reportService;
        IPhoneService phoneService;

        List<ManufacturerDto> allManufacturers;
        List<PhoneDto> allPhones;

        public MainForm(IPhoneService phoneservice, IOrderService orderservice, IReportService reportserv)
        {
            orderService = orderservice;
            reportService = reportserv;
            phoneService = phoneservice;
            InitializeComponent();
            loadData();
        }

        //загрузка данных в таблицы
        private void loadData()
        {
            allManufacturers = phoneService.GetManufacturers();
            loadPhones();
            loadOrders();
            // Заполнение комбобокса "Производитель" для отчета1.
            comboBoxManufReport1.DataSource = allManufacturers;
            comboBoxManufReport1.DisplayMember = "Name";
            comboBoxManufReport1.ValueMember = "Id";

        }

        //загрузить все телефоны в DataGrid
        private void loadPhones()
        {
            allPhones = phoneService.GetAllPhones();
            // Отображаем данные
            bindingSourcePhones.DataSource = allPhones;
            // Заполнение комбобокса "Производитель" в таблице "Товары".
           FillManufacturerCombobox();
        }

        private void loadOrders()
        {
            bindingSourceOrders.DataSource = orderService.GetAllOrders();
        }

        private void FillManufacturerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewPhones.Columns["manufacturerIdDataGridViewTextBoxColumn"]).DataSource = allManufacturers;
            ((DataGridViewComboBoxColumn)dataGridViewPhones.Columns["manufacturerIdDataGridViewTextBoxColumn"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridViewPhones.Columns["manufacturerIdDataGridViewTextBoxColumn"]).ValueMember = "Id";
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
                dataGridViewReport1.DataSource = reportService.ReportPhonesOfMunufacturer((int)comboBoxManufReport1.SelectedValue);
        }

         private class SPResult
        {
            public string Customer { get; set; }
            public string PhoneName { get; set; }
            public DateTime Date { get; set; }
        }
        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            dataGridViewReport2.DataSource = reportService.ExecuteSP((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPhoneForm f = new AddPhoneForm();
            f.comboBoxManuf.DataSource = allManufacturers;
            f.comboBoxManuf.DisplayMember = "Name";
            f.comboBoxManuf.ValueMember = "Id";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            PhoneDto phone = new PhoneDto();
            phone.ManufacturerId = (int)f.comboBoxManuf.SelectedValue;
            phone.Name = f.textBox1.Text;
            phone.Cost = f.numericUpDown1.Value;
            phone.Description = f.textBox2.Text;
            phoneService.CreatePhone(phone);
            allPhones = phoneService.GetAllPhones();
            bindingSourcePhones.DataSource = allPhones;
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewPhones);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewPhones[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                PhoneDto ph = allPhones.Where(i=>i.Id==id).FirstOrDefault();
                if (ph != null)
                {
                    AddPhoneForm f = new AddPhoneForm();
                    f.comboBoxManuf.DataSource = allManufacturers;
                    f.comboBoxManuf.DisplayMember = "Name";
                    f.comboBoxManuf.ValueMember = "Id";
                    f.numericUpDown1.Value = ph.Cost;
                    f.comboBoxManuf.SelectedValue = ph.ManufacturerId;
                    f.textBox1.Text = ph.Name;
                    f.textBox2.Text = ph.Description;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;
                    
                    ph.Cost = f.numericUpDown1.Value;
                    ph.Name = f.textBox1.Text;
                    ph.Description = f.textBox2.Text;
					ph.ManufacturerId = (int)f.comboBoxManuf.SelectedValue;
                    phoneService.UpdatePhone(ph);

                    MessageBox.Show("Объект обновлен");

                    allPhones = phoneService.GetAllPhones();
                    bindingSourcePhones.DataSource = allPhones;
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewPhones);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewPhones[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                phoneService.DeletePhone(id);
                bindingSourcePhones.DataSource = phoneService.GetAllPhones();
            }

        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrderForm f = new MakeOrderForm(phoneService,orderService);
            if (f.ShowDialog()==DialogResult.OK)
                bindingSourceOrders.DataSource = orderService.GetAllOrders();
        }

        private bool hasSelectedRow(DataGridView dataGridView)
        {
            return (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1);
        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridViewOrders))
            {
                OrderDto order = (OrderDto)dataGridViewOrders.CurrentRow.DataBoundItem;
                MakeOrderForm f = new MakeOrderForm(phoneService, orderService, order);
                if (f.ShowDialog() == DialogResult.OK)
                    bindingSourceOrders.DataSource = orderService.GetAllOrders();
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridViewOrders))
            {
                orderService.DeleteOrder(((OrderDto)dataGridViewOrders.CurrentRow.DataBoundItem).Id);
                loadOrders();
            }
        }
    }
}
