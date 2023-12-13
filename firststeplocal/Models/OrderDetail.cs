using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace firststeplocal.Models
{
    [Table("order_details")]
    public partial class OrderDetail
    {
        [Key]
        [Column("detail_id")]
        public int DetailId { get; set; }
        [Column("order_id")]
        public int? OrderId { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("product_quantity")]
        public int? ProductQuantity { get; set; }
        [Column("item_price", TypeName = "decimal(10, 2)")]
        public decimal? ItemPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderDetails")]
        public virtual Order? Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderDetails")]
        public virtual Product? Product { get; set; }
    }
}
