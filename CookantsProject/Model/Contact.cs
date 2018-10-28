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
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }
        #region ForeignKey Property

        [ForeignKey("SecurityUserCustomers")]
        [Required]
        [Description("Relationships with Customer")]
        public int CustomerId { get; set; }
        public virtual SecurityUser SecurityUserCustomers { get; set; }
        #endregion
        #region Model Property
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Description("Call, Message")]
        public string ContactType { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Comment { get; set; }
        
        #endregion
        #region NoMapping Property


        #endregion
    }
}
