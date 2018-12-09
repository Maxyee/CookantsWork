using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class SecurityUserDetails
    {
        public SecurityUser securityUsers { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal TotalWithdraw { get; set; }
        public decimal TotelBalance { get; set; }
        public List<OrderItem> orderitems { get; set; }
        public List<UserAccounting> payments { get; set; }

    }
}
