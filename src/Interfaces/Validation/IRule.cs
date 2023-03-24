namespace DomainValidation.Interfaces.Validation;

public interface IRule<in TEntity>
{
    string ErrorMessage { get; }

    bool Validate(TEntity entity);
    Task<bool> ValidateAsync(TEntity entity);
}
