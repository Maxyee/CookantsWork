using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class SecurityPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("SecurityRoles")]
        [Required]
        [Description("Relationships with Security Role")]
        public int RoleId { get; set; }
        public virtual SecurityRole SecurityRoles { get; set; }

        [ForeignKey("SecurityActions")]
        [Required]
        [Description("Relationships with Security Action")]
        public int SecurityActionId { get; set; }
        public virtual SecurityAction SecurityActions { get; set; }
        #endregion

        #region Model Property


        #endregion

        #region NoMapping Property


        #endregion
    }
}
