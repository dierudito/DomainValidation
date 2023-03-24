namespace DomainValidation.Interfaces.Validation;

public interface IRule<in TEntity>
{
    string ErrorMessage { get; }

    Task<bool> ValidateAsync(TEntity entity);
}
