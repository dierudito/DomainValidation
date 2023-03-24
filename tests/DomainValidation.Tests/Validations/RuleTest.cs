using DomainValidation.Interfaces.Specification;


namespace DomainValidation.Tests.Validations;

public class RuleTest
{
    private readonly Faker _faker;
    private readonly Mock<ISpecification<string>> _specification;
}
