﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class OrderReturnDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Subtotal { get; set; }
        public bool RefundStatus { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Order Order { get; set; }
    }
}