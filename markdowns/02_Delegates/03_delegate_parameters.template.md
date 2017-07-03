# Background: Delegates as Parameters

Still referring to the `FuncTwoInts` type, previously declared as:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example delegate declaration
```

## Declaring a method with a delegate argument

The `FuncTwoInts` type can be used to declare method parameters, as shown here:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegates as parameters
```

The method `PrintWith_2and4()` takes a delegate as an argument. The passed-in delegate must match the `FuncTwoInts` type, meaning that it must accept two `int` parameters and return an `int`. 

## Passing a delegate to a method

Here are some examples of how the `PrintWith_2and4()` method can be called:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Passing a delegate to a method
```

For each of the above calls, `PrintWith_2and4()` executes the provided method reference with 2 and 4 as arguments, and then prints the result.

# Exercise
In this exercise, you must pass either a method delegate or a lambda expression to the `TestSayHello()` method in order to produce the desired result. The delegate parameter takes a single `string` argument and returns a `string` result.

@[Delegate Parameters Exercise]({"stubs": ["Delegates3/DelegatesExercise3.cs"], "command": "Delegates3.UnitTest.Exercise3", "project": "exercises"})
