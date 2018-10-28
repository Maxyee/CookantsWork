using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
    public class Cater
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
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Email { get; set; } // use for username

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Budget { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsAgree { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
