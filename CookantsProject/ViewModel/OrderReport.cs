using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
   public class OrderReport
    {
        public Order orders { get; set; }
        public MenuItem menuItem { get; set; }
        public SecurityUser cookInfo { get; set; }
        public SecurityUser customerInfo { get; set; }

    }
}
