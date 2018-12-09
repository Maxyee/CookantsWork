using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.ViewModel
{
   public class ChangePasswordView
    {
        [Required]
        public string New { get; set; }

        [Required]
        public string Old { get; set; }
    }
}
