using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTO_s.Product
{
    public class UpdateProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Specification { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }

        public decimal SalePrice { get; set; }
        public int StockMinimum { get; set; }

        public bool IsActive { get; set; }
    }
}
