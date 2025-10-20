namespace Performance.B03Closures;

public static class ClosuresService
{
    public static int ExecuteWithClosure(int value1, int value2, int value3) => 
        ExecuteWithClosure(() => value1 + value2 + value3);

    public static int ExecuteWithoutClosure(int value1, int value2, int value3) => 
        ExecuteWithoutClosure((value1, value2, value3), static state => state.value1 + state.value2 + state.value3);

    private static TResult ExecuteWithClosure<TResult>(Func<TResult> functionToExecute) => 
        functionToExecute();

    private static TResult ExecuteWithoutClosure<TResult, TState>(TState state,  Func<TState, TResult> functionToExecute) => 
        functionToExecute(state);
}