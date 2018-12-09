using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
    public class Item
    {
        public int? id { get; set; }
        public MenuItem menuitem { get; set; }
        public int quantity { get; set; }
    }
}
