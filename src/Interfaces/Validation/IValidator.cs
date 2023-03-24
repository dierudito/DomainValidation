using DomainValidation.Validation;

namespace DomainValidation.Interfaces.Validation;


public interface IValidator<in TEntity>
{
    ValidationResult Validate(TEntity entity);
    Task<ValidationResult> ValidateAsync(TEntity entity);
}