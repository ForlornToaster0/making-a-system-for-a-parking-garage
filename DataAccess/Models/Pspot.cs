﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeleteMe.Models
{
    [Table("PSpot")]
    public partial class Pspot
    {
        [Key]
        public int Spot { get; set; }
        [StringLength(10)]
        public string? Reg { get; set; }
        public DateTime? Arrival { get; set; }
        [StringLength(20)]
        public string? Type { get; set; }
    }
}