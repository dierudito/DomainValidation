using DomainValidation.Validation;

namespace DomainValidation.Interfaces.Validation;


public interface IValidator<in TEntity>
{
    Task<ValidationResult> ValidateAsync(TEntity entity);
}