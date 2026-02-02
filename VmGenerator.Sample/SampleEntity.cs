using Generators;
using VmSource.Abstract.Model;

namespace VmGenerator.Sample;

// This code will not compile until you build the project with the Source Generators

[CreateVm]
public partial class SampleEntity : BaseModel
{
    public new int Id { get; } = 42;
    public string? Name { get; } = "Sample";
}