using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Memberships.Entities
{
    [Table("ProductItem")]
    public class ProductItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int ItemId { get; set; }

        [NotMapped]
        public int OldProductID { get; set; }
        public int OldItemID { get; set; }
    }
}