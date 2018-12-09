using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class UserDashboard
    {
        public List<SecurityUser> AllAdmin { get; set; }
        public List<SecurityUser> AllActiveCook { get; set; }
        public List<SecurityUser> AllActiveDeliveryBoy { get; set; }
        public List<SecurityUser> AllCustomer { get; set; }
        public List<SecurityUser> AllUnAuthorizedCook { get; set; }
        public List<SecurityUser> AllUnAuthorizedAdmin { get; set; }
        public List<SecurityUser> AllUnAuthorizedCustomer { get; set; }
        public List<SecurityUser> AllUnAuthorizedDeliveryBoy { get; set; }

    }
}
