using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class OrderListView
    {
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public int MealTimeId { get; set; }
        public int BusinessZoneId { get; set; }


    }
}
