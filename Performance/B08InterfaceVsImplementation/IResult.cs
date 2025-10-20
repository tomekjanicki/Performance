namespace Performance.B08InterfaceVsImplementation;

public interface IResult
{
    bool Success { get; }
    
    string Error { get; }
    
    int Value { get; }
}