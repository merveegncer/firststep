using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("gender")]
    public partial class Gender
    {
        public Gender()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("gender_id")]
        public int GenderId { get; set; }
        [Column("gender_type")]
        [StringLength(50)]
        public string? GenderType { get; set; }

        [InverseProperty(nameof(Product.Gender))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
