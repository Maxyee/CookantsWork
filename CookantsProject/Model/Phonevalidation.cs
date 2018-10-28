using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.Model
{
    public class Phonevalidation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string PhoneNo { get; set; } 

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Messageid { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string Code { get; set; }

    } 
}
