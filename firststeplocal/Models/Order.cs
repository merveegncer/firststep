using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("orders")]
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("total_amount", TypeName = "decimal(10, 2)")]
        public decimal? TotalAmount { get; set; }
        [Column("order_date", TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string? Status { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Orders")]
        public virtual User? User { get; set; }
        [InverseProperty(nameof(OrderDetail.Order))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
