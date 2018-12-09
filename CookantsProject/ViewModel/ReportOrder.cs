using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class ReportOrder
    {
        public string FirstName { get; set; }
        public DateTime? OrderDate { get; set; }

        public string OrderNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
