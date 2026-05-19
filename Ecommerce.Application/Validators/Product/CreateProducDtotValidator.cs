using Ecommerce.Application.DTO_s.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Validators.Product
{
    public class CreateProducDtotValidator : AbstractValidator<CreateProduct>
    {
        public CreateProducDtotValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("El nombre es obligatorio")
                .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres");

            RuleFor(x => x.Sku)
                .NotEmpty().WithMessage("El SKU es obligatorio")
                .Matches("^[A-Z0-9-]+$").WithMessage("El SKU solo puede contener mayusculas");

            RuleFor(x => x.SalePrice)
                .GreaterThan(0).WithMessage("El precio de venta debe ser mayor a 0");

            RuleFor(x => x.PurchaseCost)
                .GreaterThan(0).WithMessage("El costo de compra debe ser mayor a 0.")
                .LessThan(x => x.SalePrice).WithMessage("El costo de compra no puede ser mayor al precio de venta");

            RuleFor(x => x.StockMinimum)
                .GreaterThanOrEqualTo(0).WithMessage("El stock minimo no puede ser negativo");
        }
    }
}
