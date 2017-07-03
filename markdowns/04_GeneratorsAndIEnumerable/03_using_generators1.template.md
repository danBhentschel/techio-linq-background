# IEnumerable&lt;T&gt; - Using generators

Let's continue using the unbounded `GetFibonacci()` generator method from the previous lesson. Take a look at this line of code:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Call GetFibonacci().Count()
```

What will this print?

Actually, it won't print anything. It will process for a while, and then eventually fail with the error:

<pre>
System.OverflowException: Arithmetic operation resulted in an overflow.
</pre>

Why do you think this is?

Eventually, the numbers produced by the `GetFibonacci()` method get large enough that they don't fit into an `int`. This is the cause of the `OverflowException`.

> **NOTE:** The `Count()` method used above is a LINQ method. You can find more details in the **Using LINQ** course.

## Iterating an unbounded generator
Here is another example using the `GetFibonacci()` method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Iterate GetFibonacci() with a break
```

This is one way to (quite literally) `break` out of the infinite iteration of this sequence.

## Indexing into an IEnumerable&lt;T&gt;
You might be tempted to try to do this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Try to index into GetFibonacci()
```

It won't work, though.

`IEnumerable<T>` doesn't support the `[ ]` indexer operator, which somewhat makes sense. This Fibonacci generator isn't a static array that you can index into. It is a method call that returns a series of values as the result of an evaluation. So in order to retrieve the value at index `i`, you would need to evaluate the generator method `i` times.

## Making the sequence bounded with Take()
Here is another way to get the first 5 values of the sequence:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Bound GetFibonacci() with Take()
```

In this example, the `Take()` method is a LINQ method that returns a bounded iterator to the first 5 values of the sequence provided by `GetFibonacci()`.
