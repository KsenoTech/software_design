using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static BLL.Services.ReportsService;

namespace Lab3NLayer
{
    public partial class MakeOrderForm : Form
    {
        MotoService db = new MotoService();

        //Добавить заказ
        public MakeOrderForm()
        {
            InitializeComponent();
            
            loadlisBOX();
        }

        private void loadlisBOX()
        {
            ListBoxMotosInOrder.DataSource = db.GetAllMotos();
            var request = db.GetAllMotos();
            string data = request.GroupBy(i => new { i.Brand_name, i.Model_name, i.Id})/*.ToDictionary(i => i.Key, i => i.Select(j => j.Brand_name)).ToString();*/
            .Select(i => i.Key.Id).ToString();

            //ListBoxMotosInOrder.Items.Add(string.Format("{0} | {1}", Brand_name, Model));
            ListBoxMotosInOrder.DisplayMember = "Brand_name";
            //ListBoxMotosInOrder.Items.Add(String.Format("{0, -55}{1, -35}{2, -35}", db.GetMoto("select"), )) = "Model";
            //ListBoxMotosInOrder.DisplayMember = db.Motorcycles.ToList().Select(i => new MotoDto(i)).ToList();

            ListBoxMotosInOrder.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListBoxMotosInOrder.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один товар в заказ!");
                return;
            }
            List<int> items = new List<int>();
            foreach (var i in ListBoxMotosInOrder.CheckedItems)
                items.Add((i as MotoDto).Id);

            Orders order = new Orders()
            {
                Adress = tbAddress.Text,
                Customer = tbCustomer.Text,
                PhoneNumber = tbPhoneNumber.Text,
                OrderedMotosIDs = items,
            };

            OrderService service = new OrderService();
            bool result = service.MakeOrder(order);
            if (result)
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Failed");
        }
    }
}
