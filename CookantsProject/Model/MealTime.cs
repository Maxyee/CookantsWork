﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class MealTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        #region ForeignKey Property

        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan DeliveryStartTime { get; set; }
        #endregion



        #region NoMapping Property





        #endregion
    }
}
