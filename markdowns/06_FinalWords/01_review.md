[//]: # (GENERATED FILE -- DO NOT EDIT)
# C# LINQ Background Topics - Review

Congratulations on completing the **C# LINQ Background Topics** course!

Here is a quick review of what you have learned:

### Delegates
Many LINQ methods accept delegate parameters. A delegate is a reference to a method that can be stored and passed around in a variable. A new delegate type can be declared like this:

```csharp
private delegate int FuncTwoInts(int one, int two);
```

The simplest way to define a delegate variable is with the lambda operator, `=>`, as shown here:

```csharp
FuncTwoInts theFunc = (one, two) => one + two;
```

There are also some built-in delegate types that you can use for most common tasks. They are `Action`:

```csharp
private Action<string, int, bool> printThreeValues =
    (s, i, b) => Console.WriteLine($"string: {s}, int: {i}, bool: {b}");
```

And `Func`:

```csharp
private Func<string, string, int> sumCharacters = 
    (s1, s2) => s1.Length + s2.Length;
```

### Extension methods
All LINQ methods are implemented as extension methods. Extension methods enable the addition of new methods to a pre-existing type. Here is an example of an extension to the built-in type `int`:

```csharp
namespace IntExtensions
{
    public static class CoolExtensionsForInt
    {
        public static string Growl(this int num)
        {
            return $"G{new string('r', num)}";
        }
    }
}
```

### IEnumerable&lt;T&gt; and generators
LINQ methods extend the `IEnumerable<T>` interface. All arrays and collections in C# implement this interface, and so they all support LINQ functionality.

Many LINQ methods also return `IEnumerable<T>`. This return value is typically a generator that can provide values on-demand, rather than a static list of values. A generator is a stateful method that returns a sequence of values via repeated calls to the `yield return` statement. Here is an example of a generator method:

```csharp
private IEnumerable<int> GetFibonacci()
{
    int previousVal1 = 0;
    int previousVal2 = 1;

    while (true)
    {
        int nextVal = previousVal1 + previousVal2;
        previousVal1 = previousVal2;
        previousVal2 = nextVal;
        yield return nextVal;
    }
}
```

A generator method will continue to return values either until execution reaches the end of the function or until a `yield break` statement is executed.