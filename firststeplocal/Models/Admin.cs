using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("admins")]
    public partial class Admin
    {
        [Key]
        [Column("admin_id")]
        public int AdminId { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Column("password")]
        [StringLength(50)]
        public string? Password { get; set; }
        [Column("full_name")]
        [StringLength(100)]
        public string? FullName { get; set; }
    }
}
