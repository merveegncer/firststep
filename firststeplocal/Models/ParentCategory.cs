using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("parent_category")]
    public partial class ParentCategory
    {
        public ParentCategory()
        {
            Categories = new HashSet<Category>();
        }

        [Key]
        [Column("parent_category_id")]
        public int ParentCategoryId { get; set; }
        [Column("parent_category_name")]
        [StringLength(100)]
        public string? ParentCategoryName { get; set; }

        [InverseProperty(nameof(Category.ParentCategory))]
        public virtual ICollection<Category> Categories { get; set; }
    }
}
