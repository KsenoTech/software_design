using lab2_.net_.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web.Configuration;
using System.Web.ModelBinding;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab2_.net_
{
    public partial class Form1 : Form
    {
        MotosContext dbcontext = new MotosContext();
        BindingList<Motorcycle> allMotos;
        BindingList<EF.Type> allType;

        public Form1()
        {
            InitializeComponent();
            loadData();
            //МИГРАЦИИ
            // enable migration
            // add-migration
            // update migration
            //  как создавать ключи
            //  что такое селект в линке
        }

        private void loadData()
        {
            allType = dbcontext.Type.Local.ToBindingList();
            loadMoto();
            loadType();

            comboBoxManufReport1.DataSource = allType;
            comboBoxManufReport1.DisplayMember = "Name";
            comboBoxManufReport1.ValueMember = "id_Type";
        }
        private void loadMoto()
        {//Brand_name, Model, Color, HaveInStore, Cost
            dbcontext.Motorcycle.Load();
            allMotos = dbcontext.Motorcycle.Local.ToBindingList();
            dataGridViewMoto.DataSource = allMotos;
            FillMotoComboboxForType();
        }
        private void FillMotoComboboxForType()
        {
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DataSource =
                dbcontext.Type.ToList();
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).DisplayMember =
                "Name";
            ((DataGridViewComboBoxColumn)dataGridViewMoto.Columns["Conf_Type"]).ValueMember =
                "id_Type";
        }

        private void loadType()
        {
            dataGridViewType.DataSource = dbcontext.Type.ToList();
        }
        
        //private void FillReport1Combobox()
        //{
        //    // Связывание комбобокса Отчет1 с таблицей Мото из dataSet.
        //    comboBoxManufReport1.DataSource = dataSet.Tables["Type"];
        //    comboBoxManufReport1.DisplayMember = "Name";
        //    comboBoxManufReport1.ValueMember = "id_Type";
        //}

        private void buttonSaveType_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                dbcontext.SaveChanges();
                dataGridViewMoto.Refresh();
            }
        }

        private void buttonSaveMoto_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                dbcontext.SaveChanges();
                dataGridViewMoto.Refresh();
            }
        }

        private partial class SPResult
        {
            //public int id_Motorcycle { get; set; }
            public string Brand_name { get; set; }

            public string Model { get; set; }
            public string Cost { get; set; }
            //public int? Можем_предложить_кредит_на { get; set; }
            public bool HaveInStore { get; set; }

        }

        private void buttonReport2_Click_1(object sender, EventArgs e)
        {
            int v0 = -1;                                        // v0 = 0 - есть, v0 = 1 - нет, v0 = 2 - выбор всех
            if (checkedListBox1.GetItemChecked(1))
                v0 = 0;
            if (checkedListBox1.GetItemChecked(0))
                v0 = 1;
            if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1))
                v0 = 2;

            var param1 = new SqlParameter("@count", Convert.ToInt32(numericUpDown1.Value));
            var param2 = new SqlParameter("@nalichie", Convert.ToInt32(v0));

            int countLINQ = (int)numericUpDown1.Value;
            int nalichie = v0;

            var result = dbcontext.Database.SqlQuery<SPResult>("sqlzaprosLAB1 @count, @nalichie",  new object[] { param1, param2 }).ToList();
            //var data = result
            //    .Where(item => (v0 == 2) || (v0 == 1 /*&& item.HaveInStore == true*/) || (v0 == 0 && item.HaveInStore == false))
            //    .Select(item => new
            //    {
            //        Brand_name = item.Brand_name,
            //        Model = item.Model,
            //        Cost = (string.IsNullOrEmpty(item.Cost) || countLINQ >= int.Parse(item.Cost)) ?
            //            (string.IsNullOrEmpty(item.Cost) ? "You need credit" : item.Cost) :
            //            "You need credit",
            //        Credit_on = (string.IsNullOrEmpty(item.Cost) || countLINQ < int.Parse(item.Cost)) ?
            //            (string.IsNullOrEmpty(item.Cost) ? "0" : (int.Parse(item.Cost) - countLINQ).ToString()) : "0"
            //    }).ToList();

            //var filteredMotorcycles = dbcontext.Motorcycle
            //.Join(
            //    dbcontext.Type,
            //    motorcycle => motorcycle.id_Type_FK,
            //    type => type.id_Type,
            //    (motorcycle, type) => new
            //    {
            //        Brand = motorcycle.Brand_name,
            //        Model = motorcycle.Model,
            //        Type = type.Name,
            //        Color = motorcycle.Color,
            //        Cost = motorcycle.Cost
            //    })
            //.Where(item => item.Cost != null && countLINQ >= int.Parse(item.Cost)).ToList();




            dataGridViewReport2.DataSource = result;
            v0 = -1;
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            var selectedType = (int)comboBoxManufReport1.SelectedValue;

            var request = dbcontext.Motorcycle
                .Join(dbcontext.Type, m => m.id_Type_FK, t => t.id_Type, (m, t) => new { Motorcycle = m, Type = t })
                .Where(joinedData => joinedData.Type.id_Type == selectedType)
                .Select(joinedData => new
                {
                    joinedData.Motorcycle.id_Motorcycle,
                    joinedData.Motorcycle.Brand_name,
                    joinedData.Motorcycle.Model,
                    joinedData.Motorcycle.Color,
                    joinedData.Motorcycle.HaveInStore,
                    joinedData.Motorcycle.Cost
                })
                .ToList();

            dataGridViewReport1.DataSource = request;
        }

        private void dataGridViewMoto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMotoForm f = new AddMotoForm();
            f.comboBoxType.DataSource = dbcontext.Type.Local.ToBindingList();
            f.comboBoxType.DisplayMember = "Name";
            f.comboBoxType.ValueMember = "id_Type";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Motorcycle moto = new Motorcycle();
            moto.id_Type_FK = (int)f.comboBoxType.SelectedValue;
            moto.Brand_name = f.textBoxBrand.Text;
            moto.Cost = (int)f.numericUpDown1Cost.Value;
            moto.Model = f.textBoxModel.Text;
            moto.Color = f.textBoxColor.Text;


            dbcontext.Motorcycle.Add(moto);
            dbcontext.SaveChanges();

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
                bool converted = Int32.TryParse(dataGridViewMoto[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Motorcycle ph = dbcontext.Motorcycle.Where(i => i.id_Motorcycle == id).FirstOrDefault();
                if (ph != null)
                {
                    AddMotoForm f = new AddMotoForm();
                    f.comboBoxType.DataSource = dbcontext.Type.Local.ToBindingList();
                    f.comboBoxType.DisplayMember = "Name";
                    f.comboBoxType.ValueMember = "id_Type";
                    // ert = ph.Cost;
                    f.numericUpDown1Cost.Value = ph.Cost;
                    f.comboBoxType.SelectedValue = ph.id_Type_FK;
                    f.textBoxBrand.Text = ph.Brand_name;
                    f.textBoxModel.Text = ph.Model;
                    f.textBoxColor.Text = ph.Color;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    ph.Color = f.textBoxColor.Text;
                    ph.Model = f.textBoxModel.Text;
                    ph.Brand_name = f.textBoxBrand.Text;
                    ph.Cost = (int)f.numericUpDown1Cost.Value;
                    ph.Type = (EF.Type)f.comboBoxType.SelectedValue;
                    
                    dbcontext.SaveChanges();
                    dataGridViewMoto.Refresh();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }
    }
}
