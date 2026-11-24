using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeShop.Models
{
    /// <summary>
    /// Shopping cart for the New Sale screen (memory only). Subtotal, Tax and
    /// Total are recalculated every time they are read, so they are always current.
    /// </summary>
    public class ShoppingCart
    {
        public const decimal TaxRate = 0.07m;

        public Customer? Customer { get; set; }
        public List<CartItem> Items { get; } = new List<CartItem>();

        public decimal Subtotal => Items.Sum(i => i.LineTotal);
        public decimal Tax => Math.Round(Subtotal * TaxRate, 2);
        public decimal Total => Subtotal + Tax;
        public bool IsEmpty => Items.Count == 0;

        public CartItem? Find(int productID) => Items.FirstOrDefault(i => i.Product.ProductID == productID);

        /// <summary>Adds a product, or adds to the quantity if it is already in the cart.</summary>
        public void Add(Product product, int quantity)
        {
            CartItem? item = Find(product.ProductID);
            if (item == null)
            {
                Items.Add(new CartItem(product, quantity));
            }
            else
            {
                item.ChangeQuantity(item.Quantity + quantity);
            }
        }

        public void UpdateQuantity(int productID, int quantity)
        {
            Find(productID)?.ChangeQuantity(quantity);
        }

        public void Remove(int productID)
        {
            CartItem? item = Find(productID);
            if (item != null) Items.Remove(item);
        }

        public void Clear()
        {
            Items.Clear();
            Customer = null;
        }
    }
}
