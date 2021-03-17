using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecyperaCionLibrary;

namespace RecuperacioTema_2
{
    public partial class Form1 : Form
    {
        Order or = new Order();
        public Form1()
        {
            InitializeComponent();
            DataAcces db = new DataAcces();
            List<Customer> customer = new List<Customer>();

            customer = db.GetCustomer();

            foreach(Customer custom in customer)
            {
                customerCB.Items.Add(custom.fullInfo);
            }
        }

        private void customerCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ordersCB.Items.Clear();
            String customer = customerCB.Text;
            String[] n = customer.Split('|');

            string id = n[0];

            DataAcces db = new DataAcces();
            List<Order> order = new List<Order>();

            order = db.GetOrdersToCustomer(id);
            foreach (Order ord in order)
            {
                ordersCB.Items.Add(ord.orderNumber);
            }
        }

        public static EventHandler<clickEventArgs> ClickSizze;

        public virtual void OnClickSizze(clickEventArgs e)
        {
            ClickSizze?.Invoke(this, e);
        }

        private void ordersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            or.orderNumber = Int32.Parse(((ComboBox)sender).Text);
            clickEventArgs args = new clickEventArgs(or);
            OnClickSizze(args);
        }
    }
}
