namespace Performance.B08InterfaceVsImplementation;

public sealed class ClassResult : IResult
{
    private readonly string? _error;
    private readonly int? _value;

    private ClassResult(string error)
    {
        _error = error;
        Success = false;
    }
    
    private ClassResult(int value)
    {
        _value = value;
        Success = true;
    }
    
    public bool Success { get; }

    public string Error => _error ?? throw new InvalidOperationException("error is not set");

    public int Value => _value ?? throw new InvalidOperationException("value is not set");

    public static ClassResult CreateSuccess(int value) => 
        new(value);
    
    public static ClassResult CreateError(string error) => 
        new(error);
}