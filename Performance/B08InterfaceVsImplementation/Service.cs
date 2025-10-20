namespace Performance.B08InterfaceVsImplementation;

public static class Service
{
    public static IResult GetClassResultAsInterface(int value) =>
        ClassResult.CreateSuccess(value);
    
    public static IResult GetStructResultAsInterface(int value) =>
        StructResult.CreateSuccess(value);
    
    public static ClassResult GetClassResultDirectly(int value) =>
        ClassResult.CreateSuccess(value);
    
    public static StructResult GetStructResultDirectly(int value) =>
        StructResult.CreateSuccess(value);
}