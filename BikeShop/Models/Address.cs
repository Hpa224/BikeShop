using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Maps to the Address table (AddressType comes from CustomerAddress).
    /// </summary>
    public class Address
    {
        // Column lengths (nvarchar) from the Address / CustomerAddress tables
        public const int AddressLineLength = 60;
        public const int CityLength = 30;
        public const int StateProvinceLength = 50;
        public const int CountryRegionLength = 50;
        public const int PostalCodeLength = 15;
        public const int AddressTypeLength = 50;

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; } = "";
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = "";
        public string StateProvince { get; set; } = "";
        public string CountryRegion { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string AddressType { get; set; } = "Main Office";

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(AddressLine1);
            if (!string.IsNullOrWhiteSpace(AddressLine2)) sb.AppendLine(AddressLine2);
            sb.Append($"{City}, {StateProvince} {PostalCode}");
            if (!string.IsNullOrWhiteSpace(CountryRegion) && CountryRegion != "United States") sb.Append($"{Environment.NewLine}{CountryRegion}");
            return sb.ToString();
        }
    }
}
