using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Maps to the SalesOrderDetail table (one row per product on an order).
    /// OrderQty is a smallint in the database.
    /// </summary>
    public class SalesOrderDetail
    {
        public const int MinQuantity = 1;
        public const int MaxQuantity = 999;

        public int SalesOrderID { get; set; }
        public int SalesOrderDetailID { get; set; }
        public int ProductID { get; set; }
        public string ProductNumber { get; set; } = "";
        public string ProductName { get; set; } = "";
        public short OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }

        public decimal LineTotal => Math.Round(UnitPrice * (1 - UnitPriceDiscount) * OrderQty, 2);
    }
}
