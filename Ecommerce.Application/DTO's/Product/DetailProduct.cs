using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTO_s.Product
{
    public class DetailProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sku { get; set; }

        public string? Description { get; set; }
        public decimal SalePrice { get; set; }

        public string? Specification { get; set; }
        public string? ImageUrl { get; set; }

        public string? CategoryName { get; set; }
        public int StockCurrent { get; set; }
    }
}
