[//]: # (GENERATED FILE -- DO NOT EDIT)
# IEnumerable&lt;T&gt; - Exiting a generator

There is a certain set of problems for which an unbounded generator is a great solution. But the majority of real-world situations deal with bounded problems. In fact, in order to use the `GetFibonacci()` method in practical examples, we found that it was necessary to impose some bounds on the sequence.

## Exiting the generator method
One way to make a generator bounded is to simply allow the method to exit normally. Suppose we wanted `GetFibonacci()` to provide only the first `n` values of the sequence. We could write it like this:

```csharp
private IEnumerable<int> GetFibonacciOfLength(int length)
{
    int previousVal1 = 0;
    int previousVal2 = 1;

    for (int i = 0; i < length; i++)
    {
        int nextVal = previousVal1 + previousVal2;
        previousVal1 = previousVal2;
        previousVal2 = nextVal;
        yield return nextVal;
    }
}
```

Now, we could use this new `GetFibonacci()` method like so:

```csharp
// Will print:
// Value: 1
// Value: 2
// Value: 3
// Value: 5
// Value: 8
foreach (int val in GetFibonacciOfLength(5))
{
    Console.WriteLine($"Value: {val}");
}
```

Unlike with the previous examples, we don't need to break out of the `foreach` loop. It will complete normally at the end of the 5-value sequence.

## The yield break statement
Suppose we want to have a generator that provides a bounded sequence, but it's non-trivial to calculate exactly how many values will be in the sequence. There is a way to do this as well.

Let's write a `GetFibonacci()` method that returns a sequence in which the maximum returned value is less-than-or-equal-to a provided `max` parameter. Here is one implementation of such a method:

```csharp
private IEnumerable<int> GetFibonacciUpTo(int max)
{
    int previousVal1 = 0;
    int previousVal2 = 1;

    while (true)
    {
        int nextVal = previousVal1 + previousVal2;
        if (nextVal > max) yield break;
        previousVal1 = previousVal2;
        previousVal2 = nextVal;
        yield return nextVal;
    }
}
```

When execution hits the `yield break` statement, the iterator ends, as shown here using the `Count()` LINQ method:

```csharp
// Prints the number 11, indicating that
// there are 11 values <= 200:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

Console.WriteLine(GetFibonacciUpTo(200).Count());
```
