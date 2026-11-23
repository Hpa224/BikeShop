using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Maps to the SalesOrderHeader table. SubTotal, TaxAmt and TotalDue are
    /// calculated from the detail lines.
    /// </summary>
    public class SalesOrder
    {
        public const decimal TaxRate = 0.07m;

        public int SalesOrderID { get; set; }
        public string SalesOrderNumber => $"SO{SalesOrderID}";
        public DateTime OrderDate { get; set; } = DateTime.Today;
        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(7);
        public int CustomerID => Customer?.CustomerID ?? 0;
        public Customer? Customer { get; set; }
        public string ShipMethod { get; set; } = "In Store";
        public decimal Freight { get; set; }

        public List<SalesOrderDetail> Details { get; } = new List<SalesOrderDetail>();

        public decimal SubTotal => Details.Sum(d => d.LineTotal);
        public decimal TaxAmt => Math.Round(SubTotal * TaxRate, 2);
        public decimal TotalDue => SubTotal + TaxAmt + Freight;
        public int ItemCount => Details.Sum(d => d.OrderQty);
    }
}
