using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class PhoneValidationRespons
    {
        public List<Results> results { get; set; }
        
    }

    public class Results
    {
        public string status { get; set; }
        public string messageid { get; set; }
        public string destination { get; set; }
    }
}
