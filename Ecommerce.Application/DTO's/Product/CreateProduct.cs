using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTO_s.Product
{
    public class CreateProduct
    {
        public string? Name { get; set; } = null;
        public string? Sku { get; set; } = null;
        public string? Description { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchaseCost { get; set; }
        public int StockMinimum { get; set; }
        public string? Specification { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
