using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class MenuSchedul
    {
        
        public List<MenuSheduleView> menuSchedulesView { get; set; }
        public List<UserPoint> customerreview { get; set; }
        public SecurityUser user { get; set; }
        public decimal? userPoint { get; set; }
    }
}
