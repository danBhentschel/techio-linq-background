# IEnumerable&lt;T&gt; - Exiting a generator

There is a certain set of problems for which an unbounded generator is a great solution. But the majority of real-world situations deal with bounded problems. In fact, in order to use the `GetFibonacci()` method in practical examples, we found that it was necessary to impose some bounds on the sequence.

## Exiting the generator method
One way to make a generator bounded is to simply allow the method to exit normally. Suppose we wanted `GetFibonacci()` to provide only the first `n` values of the sequence. We could write it like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacciOfLength() generator method
```

Now, we could use this new `GetFibonacciOfLength()` method like so:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Iterate GetFibonacciOfLength()
```

Unlike with the previous examples, we don't need to break out of the `foreach` loop. It will complete normally at the end of the 5-value sequence.

## The yield break statement
Suppose we want to have a generator that provides a bounded sequence, but it's non-trivial to calculate exactly how many values will be in the sequence. There is a way to do this as well.

Let's write a `GetFibonacci()` method that returns a sequence in which the maximum returned value is less-than-or-equal-to a provided `max` parameter. Here is one implementation of such a method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacciUpTo() generator method
```

When execution hits the `yield break` statement, the iterator ends, as shown here using the `Count()` LINQ method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Call GetFibonacciUpTo().Count()
```

# Exercise

Exercise time again! Let's see if you can write a bounded generator. In this exercise, you will implement the same generator as in the unbounded generator exercise, but this time the sequence will be limited to the first `n` values, where `n` is a parameter to the method. As a reminder, here is the sequence you will be implementing:

Alternate between adding 2 to the previous number, then multiplying the previous number by 2. Here are the first several values in this sequence:

<pre>
  0+2, 2x2, 4+2, 6x2, 12+2, 14x2, 28+2, 30x2, 60+2 ...
= 2,   4,   6,   12,  14,   28,   30,   60,   62 ...
</pre>

@[Bounded Generator Exercise]({"stubs": ["Generators2/GeneratorsExercise2.cs"], "command": "Generators2.UnitTest.Exercise2", "project": "exercises"})
