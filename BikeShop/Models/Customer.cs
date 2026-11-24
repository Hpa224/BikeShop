using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Maps to the Customer table. Property names match the column names;
    /// the MaxLength constants match the column lengths so the forms can use them.
    /// </summary>
    public class Customer
    {
        // Column lengths (nvarchar) from the Customer table
        public const int TitleLength = 8;
        public const int NameLength = 50;        // FirstName, MiddleName, LastName
        public const int SuffixLength = 10;
        public const int CompanyNameLength = 128;
        public const int EmailAddressLength = 50;
        public const int PhoneLength = 25;

        public int CustomerID { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; } = "";
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = "";
        public string? Suffix { get; set; }
        public string? CompanyName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }

        // Main address (Address table, linked through CustomerAddress)
        public Address Address { get; set; } = new Address();

        public string FullName => $"{LastName}, {FirstName}";

        // Used by the customer combo box on the New Sale screen
        public override string ToString() =>
            string.IsNullOrWhiteSpace(CompanyName) ? FullName : $"{FullName} – {CompanyName}";
    }
}
