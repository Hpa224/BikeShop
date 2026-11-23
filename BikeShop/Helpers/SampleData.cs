using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BikeShop.Models;

namespace BikeShop.Helpers
{
    /// <summary>
    /// TEMPORARY in-memory data so the Customer, New Sale and Receipt screens can be
    /// run and tested in Phase 2. Replace these lists with queries against
    /// BikeStore.mdf when the database is connected.
    /// </summary>
    internal static class SampleData
    {
        private static int nextOrderID = 71947;

        public static List<Customer> Customers { get; } = new List<Customer>
        {
            new Customer { CustomerID = 1, Title = "Mr.", FirstName = "Orlando", MiddleName = "N.", LastName = "Gee",
                CompanyName = "A Bike Store", EmailAddress = "orlando0@bikestore.com", Phone = "245-555-0173",
                Address = new Address { AddressID = 1, AddressLine1 = "2251 Elliot Avenue", City = "Seattle",
                    StateProvince = "Washington", PostalCode = "98104", CountryRegion = "United States" } },
            new Customer { CustomerID = 2, Title = "Mr.", FirstName = "Keith", LastName = "Harris",
                CompanyName = "Progressive Sports", EmailAddress = "keith0@bikestore.com", Phone = "170-555-0127",
                Address = new Address { AddressID = 2, AddressLine1 = "7943 Walnut Ave", City = "Renton",
                    StateProvince = "Washington", PostalCode = "98055", CountryRegion = "United States" } },
            new Customer { CustomerID = 3, Title = "Ms.", FirstName = "Donna", MiddleName = "F.", LastName = "Carreras",
                CompanyName = "Advanced Bike Components", EmailAddress = "donna0@bikestore.com", Phone = "279-555-0130",
                Address = new Address { AddressID = 3, AddressLine1 = "12345 Sterling Avenue", City = "Irving",
                    StateProvince = "Texas", PostalCode = "75061", CountryRegion = "United States" } },
            new Customer { CustomerID = 4, Title = "Ms.", FirstName = "Maria", LastName = "Lopez",
                EmailAddress = "maria@email.com", Phone = "305-555-0142",
                Address = new Address { AddressID = 4, AddressLine1 = "11200 SW 8th St", City = "Miami",
                    StateProvince = "Florida", PostalCode = "33199", CountryRegion = "United States" } },
            new Customer { CustomerID = 5, Title = "Mr.", FirstName = "James", LastName = "Carter",
                EmailAddress = "jcarter@email.com", Phone = "305-555-0177",
                Address = new Address { AddressID = 5, AddressLine1 = "450 Biscayne Blvd", AddressLine2 = "Apt 12",
                    City = "Miami", StateProvince = "Florida", PostalCode = "33132", CountryRegion = "United States" } },
        };

        public static List<Product> Products { get; } = new List<Product>
        {
            new Product { ProductID = 680, ProductNumber = "FR-R92B-58", Name = "HL Road Frame - Black, 58", ListPrice = 1431.50m },
            new Product { ProductID = 706, ProductNumber = "FR-R92R-62", Name = "HL Road Frame - Red, 62",   ListPrice = 1431.50m },
            new Product { ProductID = 722, ProductNumber = "FR-R38B-60", Name = "LL Road Frame - Black, 60", ListPrice = 337.22m },
            new Product { ProductID = 739, ProductNumber = "FR-R72R-48", Name = "ML Road Frame - Red, 48",   ListPrice = 594.83m },
            new Product { ProductID = 771, ProductNumber = "BK-M68S-38", Name = "Mountain-200 Silver, 38",   ListPrice = 2319.99m },
            new Product { ProductID = 775, ProductNumber = "BK-M68B-38", Name = "Mountain-200 Black, 38",    ListPrice = 2294.99m },
            new Product { ProductID = 749, ProductNumber = "BK-R93R-62", Name = "Road-150 Red, 62",          ListPrice = 3578.27m },
            new Product { ProductID = 954, ProductNumber = "BK-T79Y-46", Name = "Touring-1000 Yellow, 46",   ListPrice = 2384.07m },
            new Product { ProductID = 707, ProductNumber = "HL-U509-R",  Name = "Sport-100 Helmet, Red",     ListPrice = 34.99m },
            new Product { ProductID = 708, ProductNumber = "HL-U509",    Name = "Sport-100 Helmet, Black",   ListPrice = 34.99m },
            new Product { ProductID = 859, ProductNumber = "GL-H102-M",  Name = "Half-Finger Gloves, M",     ListPrice = 24.49m },
            new Product { ProductID = 870, ProductNumber = "WB-H098",    Name = "Water Bottle - 30 oz.",     ListPrice = 4.99m },
            new Product { ProductID = 930, ProductNumber = "TI-M823",    Name = "HL Mountain Tire",          ListPrice = 35.00m },
            new Product { ProductID = 935, ProductNumber = "PD-M282",    Name = "LL Mountain Pedal",         ListPrice = 40.49m },
        };

        public static List<SalesOrder> Orders { get; } = new List<SalesOrder>();

        /// <summary>Order numbers increase in sequence (SO71947, SO71948, ...).</summary>
        public static int PeekNextOrderID() => nextOrderID;
        public static int GetNextOrderID() => nextOrderID++;

        public static int GetNextCustomerID() => Customers.Count == 0 ? 1 : Customers.Max(c => c.CustomerID) + 1;

        public static List<Product> SearchProducts(string partialName)
        {
            string text = partialName.Trim();
            return Products
                .Where(p => p.Name.Contains(text, StringComparison.OrdinalIgnoreCase)
                         || p.ProductNumber.Contains(text, StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => p.Name)
                .ToList();
        }

        /// <summary>A finished order used when frmReceipt is opened on its own for testing.</summary>
        public static SalesOrder CreateSampleOrder()
        {
            var order = new SalesOrder { SalesOrderID = 71946, Customer = Customers[0], OrderDate = DateTime.Today };
            order.Details.Add(new SalesOrderDetail { ProductID = 775, ProductNumber = "BK-M68B-38", ProductName = "Mountain-200 Black, 38", OrderQty = 1, UnitPrice = 2294.99m });
            order.Details.Add(new SalesOrderDetail { ProductID = 680, ProductNumber = "FR-R92B-58", ProductName = "HL Road Frame - Black, 58", OrderQty = 2, UnitPrice = 1431.50m });
            order.Details.Add(new SalesOrderDetail { ProductID = 707, ProductNumber = "HL-U509-R", ProductName = "Sport-100 Helmet, Red", OrderQty = 1, UnitPrice = 34.99m });
            return order;
        }
    }
}
