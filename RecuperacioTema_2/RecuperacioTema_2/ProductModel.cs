using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacioTema_2
{
    class ProductModel
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public double BuyPrice { get; set; }
        public byte[] LargePhoto { get; set; }
    }
}
