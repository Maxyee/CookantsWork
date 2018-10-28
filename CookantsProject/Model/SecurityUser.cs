using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
    public class SecurityUser
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
        [ForeignKey("Coupons")]
        [Description("Relationships with Coupon")]
        public int? CouponId { get; set; }
        public virtual Coupon Coupons { get; set; }

        [ForeignKey("SecurityUsers")]
        [Description("Relationships with SecurityUsers")]
        public int? DeliveryBoyId { get; set; }
        public virtual SecurityUser SecurityUsers { get; set; }
        [ForeignKey("BusinessZones")]
        [Required]
        [Description("Relationships with Business Zone")]
        public int BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZones { get; set; }

        [ForeignKey("OfficeAddress")]
        [Description("Relationships with OfficeAddress")]
        public int? OfficeAddressId { get; set; }
        public virtual Address OfficeAddress { get; set; }

        [ForeignKey("HomeAddress")]
        [Description("Relationships with HomeAddress")]
        public int? HomeAddressId { get; set; }
        public virtual Address HomeAddress { get; set; }

        [ForeignKey("OtherAddress")]
        [Description("Relationships with OtherAddress")]
        public int? OtherAddressId { get; set; }
        public virtual Address OtherAddress { get; set; }

        #endregion


        #region Model Property

        [Column(TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(100)]
        public string Email { get; set; } // use for username

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number Required!")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string DeviceType { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string DeviceToken { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string VerificationCode { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string RootUrl { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string FileName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string FileExtention { get; set; }

        public bool IsAuthorize { get; set; }

        public bool IsExternalUser { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal CreditBalance { get; set; }
        public decimal DebitBalance { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Specialized { get; set; }

        #endregion

        #region NoMapping Property

        [NotMapped]
        public string Access_Token { get; set; }

        [NotMapped]
        public string Token_Type => "Bearer";

        [NotMapped]
        public int ExpiresYears => 1;

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        [NotMapped]
        public string ImageUrl => RootUrl + "/" + FileName + "" + FileExtention;

        #endregion

    }
}
