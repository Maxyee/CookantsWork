using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class AddressView
    {
        public SecurityUser HomeAddress { get; set; }
        public SecurityUser OfficeAddress { get; set; }
        public SecurityUser OtherAddress { get; set; }
    }
}
