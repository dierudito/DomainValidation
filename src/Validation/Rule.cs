using DomainValidation.Interfaces.Specification;
using DomainValidation.Interfaces.Validation;

namespace DomainValidation.Validation;

public class Rule<TEntity> : IRule<TEntity>
{
    private readonly ISpecification<TEntity> _specification;

    public string ErrorMessage { get; private set; }

    public Rule(ISpecification<TEntity> spec, string errorMessage)
    {
        _specification = spec;
        ErrorMessage = errorMessage;
    }
    public async Task<bool> ValidateAsync(TEntity entity) =>
        await _specification.IsSatisfiedByAsync(entity);
}
