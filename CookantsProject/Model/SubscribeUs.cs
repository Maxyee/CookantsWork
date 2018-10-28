using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CookantsEntity.Model
{
    public class SubscribeUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("BusinessZone")]
        [Description("Relationships with BusinessZone")]
        public int BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZone { get; set; }

        #endregion

        #region Model Property

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Email { get; set; } 

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Phone { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
