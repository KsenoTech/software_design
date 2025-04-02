using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string connectionString;
        #region Объекты SqlDataAdapter

        private SqlDataAdapter phoneAdapter;
        private SqlDataAdapter orderAdapter;
        private SqlDataAdapter manufacturerAdapter;

        #endregion

        #region Объекты SqlCommandBuilder

        private SqlCommandBuilder phoneBuilder = new SqlCommandBuilder();
        private SqlCommandBuilder orderBuilder = new SqlCommandBuilder();

        #endregion

        #region Объект DataSet

        private DataSet dataSet = new DataSet();

        #endregion

        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            // Создание объектов SqlDataAdapter.
            phoneAdapter = new SqlDataAdapter("Select * from Phone", connectionString);
            orderAdapter = new SqlDataAdapter("Select * from [Order]", connectionString);
            manufacturerAdapter = new SqlDataAdapter("Select * from Manufacturer", connectionString);

            // Автоматическая генерация команд SQL.
            phoneBuilder = new SqlCommandBuilder(phoneAdapter);
            orderBuilder = new SqlCommandBuilder(orderAdapter);

            // Заполнение таблиц в DataSet.
            phoneAdapter.Fill(dataSet, "phone");
            orderAdapter.Fill(dataSet, "order");
            manufacturerAdapter.Fill(dataSet, "manufacturer");

            FillManufacturerCombobox();

            dataGridView1.DataSource = dataSet.Tables["phone"]; 

        }

        private void FillManufacturerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Manuf"]).DataSource =
                dataSet.Tables["manufacturer"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Manuf"]).DisplayMember =
                "Name";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Manuf"]).ValueMember =
                "Id";
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
