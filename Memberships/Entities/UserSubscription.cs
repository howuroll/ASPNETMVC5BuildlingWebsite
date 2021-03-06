using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Memberships.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        //Composite Key: Subscription and ASPnetuser tables
        [Key, Column(Order = 1)]
        [Required]
        public int SubscriptionId { get; set; }
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        [Required]
        public string UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}