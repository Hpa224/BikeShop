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
        public const decimal TaxRate = ShoppingCart.TaxRate;

        public int SalesOrderID { get; set; }
        public string SalesOrderNumber => $"SO{SalesOrderID}";
        public DateTime OrderDate { get; set; } = DateTime.Today;
        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(7);
        public Customer? Customer { get; set; }
        public int CustomerID => Customer?.CustomerID ?? 0;
        public int BillToAddressID => Customer?.Address.AddressID ?? 0;
        public int ShipToAddressID => Customer?.Address.AddressID ?? 0;
        public string ShipMethod { get; set; } = "In Store";
        public decimal Freight { get; set; }

        public List<SalesOrderDetail> Details { get; } = new List<SalesOrderDetail>();

        public decimal SubTotal => Details.Sum(d => d.LineTotal);
        public decimal TaxAmt => Math.Round(SubTotal * TaxRate, 2);
        public decimal TotalDue => SubTotal + TaxAmt + Freight;
        public int ItemCount => Details.Sum(d => d.OrderQty);

        /// <summary>Builds the order header and one detail line per cart item.</summary>
        public static SalesOrder CreateFromCart(ShoppingCart cart, int salesOrderID, DateTime orderDate)
        {
            var order = new SalesOrder
            {
                SalesOrderID = salesOrderID,
                Customer = cart.Customer,
                OrderDate = orderDate.Date,
                DueDate = orderDate.Date.AddDays(7)
            };

            int lineNumber = 1;
            foreach (CartItem item in cart.Items)
            {
                order.Details.Add(new SalesOrderDetail
                {
                    SalesOrderID = salesOrderID,
                    SalesOrderDetailID = lineNumber++,
                    ProductID = item.Product.ProductID,
                    ProductNumber = item.Product.ProductNumber,
                    ProductName = item.Product.Name,
                    OrderQty = (short)item.Quantity,
                    UnitPrice = item.UnitPrice
                });
            }
            return order;
        }
    }
}
