# Background: Delegate Variables

Referring to the `FuncTwoInts` type, previously declared as:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example delegate declaration
```

## Delegate expressions
The `FuncTwoInts` type can be used to declare variables like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegate expressions 1
```

Or like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegate expressions 2
```

Or this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegate expressions 3
```

Or even like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Delegate expressions 4
```

## Lambda expressions
The last two delegate examples above (the ones utilizing the => operator) are called lambda expressions. Lambda expressions are just a more efficient way of defining a delegate.

> **NOTE:** The => operator is called the lambda operator.

If the function defined by the lambda expression is more than a single line, then the `{ }` are required, as is the `return` keyword. On the other hand, if the only statement in the lambda expression is the `return` statement, then the second, abbreviated form can be used.

# Exercise
In this exercise, you must use either a method delegate or a lambda expression to define the `HelloFunc` variable such that it produces the desired results. The required delegate takes a single `string` argument and returns a `string` result.

@[Delegate Variable Exercise]({"stubs": ["Delegates2/DelegatesExercise2.cs"], "command": "Delegates2.UnitTest.Exercise2", "project": "exercises"})
