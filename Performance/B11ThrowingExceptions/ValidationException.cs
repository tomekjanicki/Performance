namespace Performance.B11ThrowingExceptions;

public sealed class ValidationException(string message) : Exception(message);