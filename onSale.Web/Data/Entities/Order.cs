using onSale.Common.Entities;
using onSale.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onSale.Web.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }

        public OrderStatus OrderStatus { get; set; }

        [Display(Name = "Date Sent")]
        public DateTime? DateSent { get; set; }

        [Display(Name = "Date Confirmed")]
        public DateTime? DateConfirmed { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public int Lines => OrderDetails == null ? 0 : OrderDetails.Count;

        public float Quantity => OrderDetails == null ? 0 : OrderDetails.Sum(od => od.Quantity);

        public decimal Value => OrderDetails == null ? 0 : OrderDetails.Sum(od => od.Value);
    }
}
