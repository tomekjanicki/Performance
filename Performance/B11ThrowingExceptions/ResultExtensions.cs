namespace Performance.B11ThrowingExceptions;

public static class ResultExtensions
{
    public static Result<T> CreateSuccess<T>(this T value) => 
        new(value);
    
    public static Result<T> CreateError<T>(this string error) =>
        new(error);
}