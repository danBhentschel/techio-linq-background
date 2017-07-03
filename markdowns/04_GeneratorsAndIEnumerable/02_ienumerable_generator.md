[//]: # (GENERATED FILE -- DO NOT EDIT)
# IEnumerable&lt;T&gt; - Unbounded generators


## The Fibonacci generator
In the previous lesson, we looked at an `IEnumerable<int>` backed by a `List<int>`. An `IEnumerable<T>` could also be backed by a stateful method, rather than a static collection. This method is called a generator, and it looks like this:

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

Wait a minute! What does that return? It looks like it's returning an `int`, even though the method declaration returns an `IEnumerable<int>`. And what's up with that infinite loop?

## How it works
The magic is in that `yield return` statement. Within the context of a single _iteration_, each execution of that line returns the next value in the sequence. The `yield return` statement maintains context so that a request for the next value can continue execution right where it left off.

Be aware that, at least in this example, this method produces a pseudo-infinite sequence. It's not truly infinite, as will be seen in the next lesson.

# Exercise
See if you can write your own generator method that implements the following sequence:

Alternate between adding 2 to the previous number, then multiplying the previous number by 2. Here are the first several values in this sequence:

<pre>
  0+2, 2x2, 4+2, 6x2, 12+2, 14x2, 28+2, 30x2, 60+2 ...
= 2,   4,   6,   12,  14,   28,   30,   60,   62 ...
</pre>

@[Unbounded Generator Exercise]({"stubs": ["Generators1/GeneratorsExercise1.cs"], "command": "Generators1.UnitTest.Exercise1", "project": "exercises"})
