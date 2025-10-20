namespace Performance.B08InterfaceVsImplementation;

public readonly record struct StructResult : IResult
{
    private readonly string? _error;
    private readonly int? _value;
    
    private StructResult(string error)
    {
        _error = error;
        Success = false;
    }
    
    private StructResult(int value)
    {
        _value = value;
        Success = true;
    }
    
    public bool Success { get; }

    public string Error => _error ?? throw new InvalidOperationException("error is not set");

    public int Value => _value ?? throw new InvalidOperationException("value is not set");

    public static StructResult CreateSuccess(int value) => 
        new(value);
    
    public static StructResult CreateError(string error) => 
        new(error);
}