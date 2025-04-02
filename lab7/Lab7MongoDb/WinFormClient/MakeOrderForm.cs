using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Interfaces.Services;

namespace Lab4DI
{
    public partial class MakeOrderForm : Form
    {
        IPhoneService db;
        IOrderService service;
        OrderDto selectdedOrder;

        //Добавить заказ
        public MakeOrderForm(IPhoneService dbOperations, IOrderService orderService, OrderDto o = null)
        {
            InitializeComponent();
            db = dbOperations;
            service = orderService;
            selectdedOrder = o;

            ListBoxPhonesInOrder.DataSource = db.GetAllPhones();
            ListBoxPhonesInOrder.DisplayMember = "Name";
            ListBoxPhonesInOrder.ValueMember = "Id";

            if (selectdedOrder != null)
            {
                for (int i=0;i< ListBoxPhonesInOrder.Items.Count; i++)
                {
                    PhoneDto castedItem = ListBoxPhonesInOrder.Items[i] as PhoneDto;
                    if (selectdedOrder.OrderedPhonesIds.Contains(castedItem.Id))
                        ListBoxPhonesInOrder.SetItemChecked(i, true);
                }
                tbAddress.Text = selectdedOrder.Address;
                tbCustomer.Text = selectdedOrder.Customer;
                tbPhoneNumber.Text = selectdedOrder.PhoneNumber;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListBoxPhonesInOrder.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один товар в заказ!");
                return;
            }
            List<int> items = new List<int>();
            foreach (var i in ListBoxPhonesInOrder.CheckedItems)
                items.Add((i as PhoneDto).Id);

            OrderDto order;
            if (selectdedOrder == null)
                order = new OrderDto();
            else
                order = selectdedOrder;

            order.Address = tbAddress.Text;
                order.Customer = tbCustomer.Text;
                order.PhoneNumber = tbPhoneNumber.Text;
                order.OrderedPhonesIds = items;

            var result = service.MakeOrder(order);
            if (result != null)
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Failed");

        }
    }
}
