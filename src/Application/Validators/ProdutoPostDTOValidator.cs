using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class ProdutoPostDTOValidator : AbstractValidator<ProdutoPostDTO>
{
    public ProdutoPostDTOValidator()
    {
        RuleFor(pro => pro.Nome).MinimumLength(3).MaximumLength(250);
        RuleFor(pro => pro.Complemento).MaximumLength(250);
        RuleFor(pro => (int)pro.ProdutoTipo).GreaterThanOrEqualTo(0);
    }
}
