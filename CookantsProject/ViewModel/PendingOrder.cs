using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class PendingOrder
    {
        public BusinessZone businessZone { get; set; }
        public List<Order> orders { get; set; }
    }
}
