using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacioTema_2
{
    class Customer
    {
        public int customerNumber { get; set; }
        public string customerName { get; set; }

        public string fullInfo
        {
            get
            {
                return $"{ customerNumber } || { customerName }";
            }
        }
    }
}
