using BLL.Services;
using DTO;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab3NLayer
{
    public partial class MakeOrderForm : Form
    {
        IMotoService db;
        IOrderService service;
        OrderDto selectdedOrder;

        //Добавить заказ
        public MakeOrderForm(IMotoService dbOperations, IOrderService orderService, OrderDto o = null)
        {
            InitializeComponent();

            db = dbOperations;
            service = orderService;
            selectdedOrder = o;

            ListBoxMotosInOrder.DataSource = db.GetAllMotos();
            ListBoxMotosInOrder.DisplayMember = "Brand_name";
            ListBoxMotosInOrder.ValueMember = "id_Motorcycle";

            if (selectdedOrder != null)
            {
                for (int i = 0; i < ListBoxMotosInOrder.Items.Count; i++)
                {
                    MotoDto castedItem = ListBoxMotosInOrder.Items[i] as MotoDto;
                    if (selectdedOrder.OrderedMotosIDs.Contains(castedItem.Id))
                        ListBoxMotosInOrder.SetItemChecked(i, true);
                }
                tbAddress.Text = selectdedOrder.Adress;
                tbCustomer.Text = selectdedOrder.Customer;
                tbPhoneNumber.Text = selectdedOrder.PhoneNumber;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListBoxMotosInOrder.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один товар в заказ!");
                return;
            }
            List<int> items = new List<int>();
            foreach (var i in ListBoxMotosInOrder .CheckedItems)
                items.Add((i as MotoDto).Id);

            OrderDto order;
            if (selectdedOrder == null)
                order = new OrderDto();
            else
                order = selectdedOrder;

            order.Adress = tbAddress.Text;
            order.Customer = tbCustomer.Text;
            order.PhoneNumber = tbPhoneNumber.Text;
            order.OrderedMotosIDs = items;

            var result = service.MakeOrder(order);
            if (result != null)
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Failed");

        }
    }
}
