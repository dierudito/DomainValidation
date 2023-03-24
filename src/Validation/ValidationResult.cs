namespace DomainValidation.Validation;

public record ValidationResult(string Message, IEnumerable<ValidationError> Errors)
{
    public string Message { get; private set; } = Message;
    public bool IsValid { get => !Errors.Any(); }
    public IEnumerable<ValidationError> Errors { get; private set; } = Errors;

    public ValidationResult() : this(Message: default, Array.Empty<ValidationError>())
    {
    }

    public void Add(ValidationError error)
    {
        var list = new List<ValidationError>(Errors) { error };
        SetErrors(list);
    }

    public void Add(params ValidationResult[] validationResults)
    {
        var list = new List<ValidationError>(Errors);
        foreach (var validation in validationResults)
            list.AddRange(validation.Errors);

        SetErrors(list);
    }

    public void Remove(ValidationError error)
    {
        var list = new List<ValidationError>(Errors);
        list.Remove(error);
        SetErrors(list);
    }

    private void SetErrors(List<ValidationError> errors)
    {
        Errors = errors;

        if (!IsValid)
            Message = errors[0].Message;
    }
}
