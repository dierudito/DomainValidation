namespace DomainValidation.Interfaces.Specification;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T entity);

    Task<bool> IsSatisfiedByAsync(T entity);
}
