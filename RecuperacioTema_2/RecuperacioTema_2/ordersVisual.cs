using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacioTema_2
{
   
    public partial class ordersVisual : UserControl
    {
        OrderDetaills od = new OrderDetaills();
        public ordersVisual()
        {
            InitializeComponent();
            Form1.ClickSizze += getInfo;            
        }

        public void getInfo(object sender, clickEventArgs e)
        {
            orderNumberLB.Text = e.ID;

            viewOrder();
        }

        public void viewOrder()
        {
            DataAcces db = new DataAcces();
            List<Order> order = new List<Order>();
            string orderID = orderNumberLB.Text;
            order = db.GetOrders(orderID);

            foreach (Order or in order)
            {
                orderDateLB.Text = or.orderDate.ToString("dd-MM-yyyy");
                requeDateLB.Text = or.requiredDate.ToString("dd-MM-yyyy");
                shippDateLB.Text = or.shippedDate.ToString("dd-MM-yyyy");
                statusLB.Text = or.status;
            }

            showOrders(orderID);
        }

        public void showOrders(string orderID)
        {
            flowLayoutPanel.Controls.Clear();
            var ordermodel = new OrderModel();
            ordermodel.orderLineNumber = DataAcces.GetDetalls(orderID);

            foreach (OrderDetaills product in ordermodel.orderLineNumber)
            {

                //orderLineNmberControl orderLine = new orderLineNmberControl();
                Label l1 = new Label();
                l1.Text = "|||";
                Label l2 = new Label();
                l2.Text = product.productCode;
                Label l3 = new Label();
                l3.Text = product.quantityOrdered.ToString();
                Label l4 = new Label();
                l4.Text = product.priceEach.ToString();
                Label l5 = new Label();

                int i = product.quantityOrdered;
                int n = product.priceEach;
                int m = i * n;

                l5.Text = m.ToString();


                flowLayoutPanel.Controls.Add(l2);
                flowLayoutPanel.Controls.Add(l3);
                flowLayoutPanel.Controls.Add(l4);
                flowLayoutPanel.Controls.Add(l5);
                flowLayoutPanel.Controls.Add(l1);
            }

        }

        //public static EventHandler<clickEventArgs> ClickSizze;

        //public virtual void OnClickSizze(clickEventArgs e)
        //{
        //    ClickSizze?.Invoke(this, e);
        //}

        //private void ordersCB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    od.orderNumber = Int32.Parse(((ComboBox)sender).Text);
        //    clickEventArgs args = new clickEventArgs(od);
        //    OnClickSizze(args);
        //}

        private void ordersVisual_Load(object sender, EventArgs e)
        {

        }
    }
}
