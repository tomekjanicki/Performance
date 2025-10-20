using BenchmarkDotNet.Attributes;

namespace Performance.B09ListManipulations;

public class ListManipulationsBenchmark
{
    [Benchmark]
    public IReadOnlyCollection<int> InsertItemsAtTheBeginningOneByOne() => 
        ListManipulations.InsertItemsAtTheBeginningOneByOne(300);
    
    [Benchmark]
    public IReadOnlyCollection<int> InsertItemsAtTheBeginningByRange() => 
        ListManipulations.InsertItemsAtTheBeginningByRange(300);
    
    [Benchmark]
    public IReadOnlyCollection<int> InsertItemsAtTheBeginningWithLinq() => 
        ListManipulations.InsertItemsAtTheBeginningWithLinq(300);
    
    [Benchmark]
    public IReadOnlyCollection<int> RemoveItemsAtTheBeginningOneByOne() => 
        ListManipulations.RemoveItemsAtTheBeginningOneByOne(300);
    
    [Benchmark]
    public IReadOnlyCollection<int> RemoveItemsAtTheBeginningByRange() => 
        ListManipulations.RemoveItemsAtTheBeginningByRange(300);
    
    [Benchmark]
    public IReadOnlyCollection<int> RemoveItemsAtTheBeginningByLinq() => 
        ListManipulations.RemoveItemsAtTheBeginningByLinq(300);
}