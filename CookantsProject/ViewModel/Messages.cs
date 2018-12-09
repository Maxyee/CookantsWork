using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class Messages
    {
        public string sender { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string datacoding { get; set; }
        public List<Recipient> recipients { get; set; }
    }
}
