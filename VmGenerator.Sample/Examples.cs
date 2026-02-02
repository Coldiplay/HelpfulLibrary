using System.Collections.Generic;
using Entities;
using Generators;
using VmSource.Abstract.Model;

namespace VmGenerator.Sample;

// This code will not compile until you build the project with the Source Generators

[CreateVm]
public class Test : BaseModel
{
    public Testt Testt { get; set; }
}
public class Testt {}



public class Examples
{
    // Create generated entities, based on DDD.UbiquitousLanguageRegistry.txt
    public object[] CreateEntities()
    {
        //var test = new SampleEntityVm();
        return [];
        // return new object[]
        // {
        //     new Customer(),
        //     new Employee(),
        //     new Product(),
        //     new Shop(),
        //     new Stock()
        // };
    }

    // Execute generated method Report
    public IEnumerable<string> CreateEntityReport(SampleEntity entity)
    {
        return new List<string>();
        //return entity.Report();
    }
}