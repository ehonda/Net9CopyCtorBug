using Net8.Application;

var derivedA = new Derived("Name") { AnotherProperty = "A" };
var derivedB = derivedA with { AnotherProperty = "B" };

Console.WriteLine(derivedA);
Console.WriteLine(derivedB);