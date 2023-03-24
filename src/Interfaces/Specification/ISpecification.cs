namespace DomainValidation.Interfaces.Specification;

public interface ISpecification<in T>
{
    Task<bool> IsSatisfiedByAsync(T entity);
}