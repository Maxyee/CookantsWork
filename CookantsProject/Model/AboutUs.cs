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


    public class AboutUs
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
        [StringLength(150)]
        public string Title { get; set; } // use for Title

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.MultilineText)]
        public string LongDescription { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string RootUrl { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string FileName { get; set; }

        public string FileExtention { get; set; }
        #endregion

        #region NoMapping Property

        [NotMapped]
        public string ImageUrl => RootUrl + "/" + FileName + "" + FileExtention;
        #endregion
    }
}
