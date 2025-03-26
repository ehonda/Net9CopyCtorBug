using EHonda.Net9CopyCtorBug.Net9.Library;

namespace Net9.Application;

public record DerivedFromNet9(string BaseName) : Base(BaseName)
{
    public required string AnotherProperty { get; init; }
}