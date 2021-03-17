using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacioTema_2
{
    class Order
    {
        public int orderNumber { get; set; }
        public DateTime orderData { get; set; }
        public DateTime requeridData { get; set; }
        public DateTime shippedData { get; set; }
        public string status { get; set; }
    }
}
