using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Maps to the Product table. Only the columns the New Sale screen needs
    /// are here for now – add the rest (Color, StandardCost, Size, Weight,
    /// ProductCategoryID, ProductModelID, sell dates) for Product Maintenance.
    /// </summary>
    public class Product
    {
        public const int NameLength = 50;
        public const int ProductNumberLength = 25;

        public int ProductID { get; set; }
        public string ProductNumber { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal ListPrice { get; set; }

        public override string ToString() => $"{ProductNumber} – {Name}";
    }
}
