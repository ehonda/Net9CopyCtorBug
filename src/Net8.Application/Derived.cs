using EHonda.Net9CopyCtorBug.Net8.Library;

namespace Net8.Application;

public record Derived(string BaseName) : Base(BaseName)
{
    public required string AnotherProperty { get; init; }
}