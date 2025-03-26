using Net9.Application;

var derivedFromNet8A = new DerivedFromNet8("Name") { AnotherProperty = "A" };
var derivedFromNet8B = derivedFromNet8A with { AnotherProperty = "B" };

var derivedFromNet8WithoutRequiredPropertyA
    = new DerivedFromNet8_WithoutRequiredProperty("Name") { AnotherProperty = "A" };
var derivedFromNet8WithoutRequiredPropertyB
    = derivedFromNet8WithoutRequiredPropertyA with { AnotherProperty = "B" };

var derivedFromNet9A = new DerivedFromNet9("Name") { AnotherProperty = "A" };
var derivedFromNet9B = derivedFromNet9A with { AnotherProperty = "B" };

Console.WriteLine(derivedFromNet8A);
Console.WriteLine(derivedFromNet8B);

Console.WriteLine(derivedFromNet8WithoutRequiredPropertyA);
Console.WriteLine(derivedFromNet8WithoutRequiredPropertyB);

Console.WriteLine(derivedFromNet9A);
Console.WriteLine(derivedFromNet9B);
