﻿namespace ACM.BL.Models
{
    public class OrderDisplayItem
    {
        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}