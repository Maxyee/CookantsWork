using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CookantsEntity.Model
{
    public class ContactUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Email { get; set; } // use for username

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Phone { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Facebook { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Twitter { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Latlng { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
