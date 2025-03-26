using EHonda.Net9CopyCtorBug.Net8.Library;

namespace Net9.Application;

public record DerivedFromNet8(string BaseName) : Base(BaseName)
{
    public required string AnotherProperty { get; init; }
}