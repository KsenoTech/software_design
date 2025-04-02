using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApp1
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



        }



        private void button1_Click(object sender, EventArgs e)
        {
            phoneAdapter.Update(dataSet, "phone");

        }
    }
}
