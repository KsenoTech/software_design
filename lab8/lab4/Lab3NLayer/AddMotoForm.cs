using DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3NLayer
{
    public partial class AddMotoForm : Form
    {
        //IMotoService db;
        public AddMotoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        #region
        //public AddMotoForm(IMotoService dbOperations)
        //{
        //    InitializeComponent();

        //    db = dbOperations;


        //    comboBoxType.DataSource = db.GetTypes();
        //    comboBoxType.DisplayMember = "Name";
        //    comboBoxType.ValueMember = "id_Type";

        //    DialogResult result = ShowDialog(this);
        //    if (result == DialogResult.Cancel)
        //        return;
        //    MotoDto motoc = new MotoDto();
        //    motoc.id_Type_FK = (int)comboBoxType.SelectedValue;
        //    motoc.Color = textBoxColor.Text;
        //    motoc.Cost = (int)numericUpDown1Cost.Value;
        //    motoc.Model = textBoxModel.Text;
        //    motoc.Brand_name = textBoxBrand.Text;

        //    tbAddress.Text = selectdedOrder.Adress;
        //        tbCustomer.Text = selectdedOrder.Customer;
        //        tbPhoneNumber.Text = selectdedOrder.PhoneNumber;

        //}   
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<int> items = new List<int>();
        //    MotoDto motoc = new MotoDto();
        //    motoc.id_Type_FK = (int)comboBoxType.SelectedValue;
        //    motoc.Color = textBoxColor.Text;
        //    motoc.Cost = (int)numericUpDown1Cost.Value;
        //    motoc.Model = textBoxModel.Text;
        //    motoc.Brand_name = textBoxBrand.Text;

        //    var result = service.MakeOrder(order);
        //    if (result != null)
        //    {
        //        MessageBox.Show("Success");
        //    }
        //    else MessageBox.Show("Failed");

        //}
        #endregion
    }
}
