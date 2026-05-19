using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sku { get; set; }
        public string? Description { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchaseCost { get; set; }
        public int StockCurrent { get; set; }
        public int StockMinimum { get; set; }
        public string? Specification { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        //Relacion con Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
