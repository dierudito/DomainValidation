namespace DomainValidation.Validation;

public record ValidationError(string Name, string Message)
{
    public string Name { get; private set; } = Name;
    public string Message { get; private set; } = Message;
}
