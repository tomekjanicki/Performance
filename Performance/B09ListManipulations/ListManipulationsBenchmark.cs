using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Performance.B09ListManipulations;

public class ListManipulationsBenchmark
{
    [Benchmark]
    public ReadOnlyCollection<int> InsertItemsAtTheBeginningOneByOne() => 
        ListManipulations.InsertItemsAtTheBeginningOneByOne(300);
    
    [Benchmark]
    public ReadOnlyCollection<int> InsertItemsAtTheBeginningByRange() => 
        ListManipulations.InsertItemsAtTheBeginningByRange(300);
    
    [Benchmark]
    public ReadOnlyCollection<int> InsertItemsAtTheBeginningWithLinq() => 
        ListManipulations.InsertItemsAtTheBeginningWithLinq(300);
    
    [Benchmark]
    public ReadOnlyCollection<int> RemoveItemsAtTheBeginningOneByOne() => 
        ListManipulations.RemoveItemsAtTheBeginningOneByOne(300);
    
    [Benchmark]
    public ReadOnlyCollection<int> RemoveItemsAtTheBeginningByRange() => 
        ListManipulations.RemoveItemsAtTheBeginningByRange(300);
    
    [Benchmark]
    public ReadOnlyCollection<int> RemoveItemsAtTheBeginningByLinq() => 
        ListManipulations.RemoveItemsAtTheBeginningByLinq(300);
}