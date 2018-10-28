using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CookantsEntity.Model
{
    public class TeamMember
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
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Title { get; set; } // use for Title

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Facebook { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Twitter { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Linkedin { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string RootUrl { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string FileName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Description { get; set; }

        public string FileExtention { get; set; }

        #endregion

        #region NoMapping Property

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        [NotMapped]
        public string ImageUrl => RootUrl + "/" + FileName + "" + FileExtention;
        #endregion
    }
}
