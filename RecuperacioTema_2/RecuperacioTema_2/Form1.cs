using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacioTema_2
{
    public partial class Form1 : Form
    {
        public int[] IdCustomer;
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
            String customer = customerCB.Text;
            String[] n = customer.Split('|');

            string id = n[0];

            DataAcces db = new DataAcces();
            List<Order> order = new List<Order>();

            order = db.GetOrders(id);
            foreach (Order ord in order)
            {
                ordersCB.Items.Add(ord.orderNumber);
            }
        }
    }
}
