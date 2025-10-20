namespace Performance.B11ThrowingExceptions;

public readonly record struct Result<TResult>
{
    private readonly string? _error;
    private readonly TResult? _value;

    internal Result(string error)
    {
        _error = error;
        Success = false;
    }

    internal Result(TResult value)
    {
        _value = value;
        Success = true;
    }
    
    public bool Success { get; }

    public string Error => _error ?? throw new InvalidOperationException("error is not set");
    
    public TResult Value => _value ?? throw new InvalidOperationException("value is not set");
}