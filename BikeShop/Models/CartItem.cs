using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// One product line in the shopping cart (memory only, not a table).
    /// </summary>
    public class CartItem
    {
        public const int MinQuantity = 1;
        public const int MaxQuantity = 999;   // OrderQty is a smallint

        public CartItem(Product product, int quantity)
        {
            Product = product;
            UnitPrice = product.ListPrice;
            ChangeQuantity(quantity);
        }

        public Product Product { get; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; }
        public decimal LineTotal => UnitPrice * Quantity;

        public void ChangeQuantity(int quantity)
        {
            if (quantity < MinQuantity || quantity > MaxQuantity)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity),
                    $"Quantity must be between {MinQuantity} and {MaxQuantity}.");
            }
            Quantity = quantity;
        }
    }
}
