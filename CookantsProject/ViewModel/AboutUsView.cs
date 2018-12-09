using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{

    public class AboutUsView
    {
        public AboutUs aboutUs { get; set; }
        public List<TeamMember> teamMember { get; set; }
    }
}
