using EHonda.Net9CopyCtorBug.Net8.Library;

namespace Net9.Application;

public record DerivedFromNet8_WithoutRequiredProperty(string BaseName) : Base(BaseName)
{
    public string AnotherProperty { get; init; }
}