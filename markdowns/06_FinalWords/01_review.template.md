# C# LINQ Background Topics - Review

Congratulations on completing the **C# LINQ Background Topics** course!

Here is a quick review of what you have learned:

### Delegates
Many LINQ methods accept delegate parameters. A delegate is a reference to a method that can be stored and passed around in a variable. A new delegate type can be declared like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example delegate declaration
```

The simplest way to define a delegate variable is with the lambda operator, `=>`, as shown here:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegate expressions 4
```

There are also some built-in delegate types that you can use for most common tasks. They are `Action`:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Action usage 2
```

And `Func`:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Func usage 2
```

### Extension methods
All LINQ methods are implemented as extension methods. Extension methods enable the addition of new methods to a pre-existing type. Here is an example of an extension to the built-in type `int`:

```csharp
//// EMBED: LinqCourseEmbeddedCode/CoolExtensionsForInt.cs, Example extension method declaration
```

### IEnumerable&lt;T&gt; and generators
LINQ methods extend the `IEnumerable<T>` interface. All arrays and collections in C# implement this interface, and so they all support LINQ functionality.

Many LINQ methods also return `IEnumerable<T>`. This return value is typically a generator that can provide values on-demand, rather than a static list of values. A generator is a stateful method that returns a sequence of values via repeated calls to the `yield return` statement. Here is an example of a generator method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacci() generator method
```

A generator method will continue to return values either until execution reaches the end of the function or until a `yield break` statement is executed.