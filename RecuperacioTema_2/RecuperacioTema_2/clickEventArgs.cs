using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacioTema_2
{
    public class clickEventArgs:EventArgs
    {
        private string _id;
        public clickEventArgs(Order order)
        {
            _id = order.orderNumber.ToString();
        }

        public string ID
        {
            get { return _id; }
        }
    }
}
