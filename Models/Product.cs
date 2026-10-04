using System;
using System.ComponentModel.DataAnnotations;

namespace GroceryShopAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
