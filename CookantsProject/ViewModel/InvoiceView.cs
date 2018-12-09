using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class InvoiceView
    {
        public Order order { get; set; }
        public List<OrderItem> orderitems { get; set; }


    }
}
