# Extension Methods - Extra parameters

An extension method can take extra parameters, in addition to an instance of the type that it is extending. Here is an example of how this works:

```csharp
//// EMBED: LinqCourseEmbeddedCode/CoolExtensionsForInt2.cs, Example extension method with extra parameters
```

What does this do? Let's call it a few times and find out:

```csharp
//// EMBED: LinqCourseEmbeddedCode/ExtensionMethods2.cs, Call extension method with extra parameters
```

# Exercise
Try adding another extension method to the `string` type. This time, call it `MakePlural()`. The `MakePlural()` method should take an `int` parameter and return a string that is either the original string if the parameter is 1, or the string with an 's' appended to it if the parameter is not equal to 1.

@[Extension Method Parameters Exercise]({"stubs": ["ExtensionMethods2/ExtensionMethodsExercise2.cs"], "command": "ExtensionMethods2.UnitTest.Exercise2", "project": "exercises"})
