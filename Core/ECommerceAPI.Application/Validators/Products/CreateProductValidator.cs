using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;


namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator() {
            RuleFor(p => p.Name).NotEmpty()
                    .NotNull()
                    .WithMessage("Please type the product name")
                    .MaximumLength(150)
                    .MinimumLength(3)
                    .WithMessage("Please type the product name between 3 to 150 character");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please add a value")
                .Must(s => s >= 0)
                .WithMessage("Stock value cannot be less than 0 ");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please add a value")
                .Must(s => s >= 0)
                .WithMessage("Price value cannot be less than 0 ");
        }
    }
}
