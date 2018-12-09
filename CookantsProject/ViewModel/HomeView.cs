using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class HomeView
    {
        public IEnumerable<SecurityUser> SecurityUser { get; set; }
        public IEnumerable<AboutUs> AboutUs { get; set; }
    }
}
