using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public enum VehicleTypeEnum 
    {
        MC = 1, CAR = 2
    }

    [Table("PSpot")]
    public partial class DBPspot
    {
        public int Spot { get; set; }
        [Key]
        [StringLength(10)]
        public string Reg { get; set; } = null!;
        public DateTime Arrival { get; set; }
        [StringLength(20)]
        public string? Type { get; set; }
    }
}
