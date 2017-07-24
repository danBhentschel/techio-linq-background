# Extension Methods

## Why learn about extension methods?
All LINQ methods are extension methods, defined in the `System.Linq` namespace.

## What are extension methods?
Extension methods in C# enable the addition of new methods to a pre-existing type, without modifying the original source code for that type. They are similar in purpose (though different in implementation) to mixins in other languages. Extension methods can be very useful for adding functionality to classes or interfaces found in a third-party library, or even to classes in the .NET Framework libraries.

## Example extension method

This is what an extension method declaration looks like:

```csharp
//// EMBED: LinqCourseEmbeddedCode/CoolExtensionsForInt.cs, Example extension method declaration
```

The name of the class isn't important, nor is the name of the method. The important elements are:
 - The class and method must both be `static`
 - The first parameter to the method must be of the type that is being extended (`int` in this example)
 - The first parameter to the method must be prefaced with the keyword `this`

## Calling an extension method

The above extension method can be called as if it were a member of the `int` type. For example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/ExtensionMethods1.cs, Call extension method
```

Notice that the extension method is defined in the `IntExtensions` namespace, and so that namespace must be included with a `using` directive before the extension method can be invoked.

# Exercise

In this exercise, you must add an extension method, `SayHello()` to the built-in `string` type. The `SayHello()` method should return the string: "Hello, &lt;subject&gt;!"

@[Extension Methods Exercise]({"stubs": ["ExtensionMethods1/ExtensionMethodsExercise1.cs"], "command": "ExtensionMethods1.UnitTest.Exercise1", "project": "exercises"})
