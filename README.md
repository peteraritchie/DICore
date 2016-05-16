# DICore
[![Build status](https://ci.appveyor.com/api/projects/status/nrh2ccoyl7s1mwws?svg=true)](https://ci.appveyor.com/project/peteraritchie/dicore)

A library for facilitating [Dependency Inversion](https://en.wikipedia.org/wiki/Dependency_inversion_principle)

With many frameworks, interface-driven design is non-existant or spotty.  The ability for your code to *depend on abstractions* can be difficult.  While abstractions around framework types can be hand-crafted, and an application-specific abstraction that makes the implicit more explicit can be created, it's time-consuming and of specious value given the use of frameworks that themselves provide abstractions.

This library doesn't try to replace good design.  If an application-specific type can better wrap a framework type or set of framework types, the design should prefer that design methodology of wholesale use of this library.

None-the-less, this library begins the process of creating abstractions from .NET Framework types that don't fully implement abstractions (in this case interfaces)

The core contains a small set of utility classes to aid in reducing dependency on concrete classes (or the creation of concrete classes).  The code includes types such as `FuncComparable`, `FuncComparer`, `FuncEqualityComparer`, and `FuncEquatable` to provide delegate-based interface implementations for some common .NET Framework interfaces such as `IComparable`, `IComparer`, `IEqualityComparer`, and `IEquatable`.  In addition, the library includes the best practice of an abstract factory `IFactory` and a similar delegate-based implementation `FuncFactory` to aid in avoiding such anti-patterns as [Service Locator](http://blog.ploeh.dk/2010/02/03/ServiceLocatorisanAnti-Pattern/)