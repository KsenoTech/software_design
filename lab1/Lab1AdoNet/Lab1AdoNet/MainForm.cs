using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1AdoNet
{
    public partial class MainForm : Form
    {
        #region Строка подключения к БД

        private string connectionString;

        #endregion

        #region Объекты SqlDataAdapter

        private SqlDataAdapter MotorcycleAdapter;
        private SqlDataAdapter TypeAdapter;

        #endregion
            
        private SqlCommandBuilder MotorcycleBuilder = new SqlCommandBuilder();


        #region Объект DataSet

        private DataSet dataSet = new DataSet();

        #endregion

        public MainForm()
        {
            
            InitializeComponent();
            textCatchTovar.Text = "Поле для вывода ошибок.";

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            // Создание объектов SqlDataAdapter.
            MotorcycleAdapter = new SqlDataAdapter("Select * from Motorcycle", connectionString);
            TypeAdapter = new SqlDataAdapter("Select * from Type", connectionString);


            SqlCommandBuilder MotorcycleBuilder = new SqlCommandBuilder(MotorcycleAdapter);

            // Заполнение таблиц в DataSet.
            MotorcycleAdapter.Fill(dataSet, "Motorcycle");
            TypeAdapter.Fill(dataSet, "Type");
            

            // Связывание элементов управления с данными.
            

            dataGridViewTovary.DataSource = dataSet.Tables["Motorcycle"]; ;
            dataGridViewZakazy.DataSource = dataSet.Tables["Type"];

            // Заполнение комбобокса "Производитель" в таблице "Товары".
            FillManufacturerCombobox();

            // Заполнение комбобокса "Товары" для отчета1.
            FillReport1Combobox();

            
        }

        private void FillNalich()
        {
            for (int i = 0; i <= checkedListBox1.Items.Count; i++)
            {
                if ((checkedListBox1.GetItemChecked(i) == true) && (i == 0))
                {
                    MessageBox.Show("This is the value of ceckhed Item " + checkedListBox1.Items[i].ToString());
                }
            }
        }

        private void FillReport1Combobox()
        {
                // Связывание комбобокса Отчет1 с таблицей Мото из dataSet.
                comboBoxManufReport1.DataSource = dataSet.Tables["Type"];
                comboBoxManufReport1.DisplayMember = "Name";
                comboBoxManufReport1.ValueMember = "id_Type";
        }

        /// <summary>
        /// Заполнить комбобокс "Тип конфиг" в таблице "Тип".
        /// </summary>
        private void FillManufacturerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewTovary.Columns["Conf_Type"]).DataSource =
                dataSet.Tables["Type"];
            ((DataGridViewComboBoxColumn)dataGridViewTovary.Columns["Conf_Type"]).DisplayMember =
                "Name";
            ((DataGridViewComboBoxColumn)dataGridViewTovary.Columns["Conf_Type"]).ValueMember =
                "id_Type";
        }

        /// <summary>
        /// Сохранить изменения в таблице material.
        /// </summary>
        private void buttonSavePhone_Click(object sender, EventArgs e)
        {
            MotorcycleAdapter.Update(dataSet, "Motorcycle");
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand =
                   new SqlCommand("Select m.id_Motorcycle, m.Brand_name, m.Model, m.Color, m.HaveInStore, m.Cost " +
                   "from Motorcycle m JOIN Type t ON m.id_Type_FK = t.id_Type " +
                   "where t.id_Type in " +
                   "(select id_Type_FK from Motorcycle group by id_Type_FK having id_Type = " + comboBoxManufReport1.SelectedValue + ")", sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("report1");
                dataTable.Columns.Add("Brand_name");
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("Color");
                dataTable.Columns.Add("HaveInStore");

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["Brand_name"] = sqlDataReader["Brand_name"];
                        row["Model"] = sqlDataReader["Model"];
                        row["Color"] = sqlDataReader["Color"];
                        row["HaveInStore"] = sqlDataReader["HaveInStore"];
                        dataTable.Rows.Add(row);
                    }
                    sqlDataReader.NextResult();
                }
                //DataTable.Load(sqlDataReader);
                sqlDataReader.Close();
                dataGridViewReport1.DataSource = dataTable;
               // sqlConnection.Close();

            }
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            //FillNalich();
            int v0 = -1; // v0 = 0 - есть, v0 = 1 - нет, v0 = 2 - выбор всех
            if (checkedListBox1.GetItemChecked(0))
                v0 = 0;
            if (checkedListBox1.GetItemChecked(1))
                v0 = 1;
            if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1))  
                v0 = 2;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("sqlzaprosLAB1", sqlConnection);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@count", SqlDbType.Int));
                sqlAdapter.SelectCommand.Parameters.AddWithValue("@nalichie", v0);
                sqlAdapter.SelectCommand.Parameters["@count"].Value = numericUpDown1.Value;

                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "report2");

                dataGridViewReport2.DataSource = dataSet.Tables["report2"];
            }
            v0 = -1;
        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            try
            {
                TypeAdapter.Update(dataSet, "Type");
            }
            catch(Exception ex)
            {
                textCatchZakaz.Text = ex.Message;
                textCatchTovar.Text = ex.Message;
            }
        }

        private void dataGridViewTovary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
