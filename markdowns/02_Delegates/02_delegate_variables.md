[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background: Delegate Variables

Referring to the `FuncTwoInts` type, previously declared as:

```csharp
private delegate int FuncTwoInts(int one, int two);
```

## Delegate expressions
The `FuncTwoInts` type can be used to declare variables like this:

```csharp
private static int Add(int one, int two)
{
    return one + two;
}

private FuncTwoInts theFunc = Add;
```

Or like this:

```csharp
FuncTwoInts theFunc = delegate (int one, int two)
{
    return one + two;
};
```

Or this:

```csharp
FuncTwoInts theFunc = (one, two) =>
{
    return one + two;
};
```

Or even like this:

```csharp
FuncTwoInts theFunc = (one, two) => one + two;
```

## Lambda expressions
The last two delegate examples above (the ones utilizing the => operator) are called lambda expressions. Lambda expressions are just a more efficient way of defining a delegate.

> **NOTE:** The => operator is called the lambda operator.

If the function defined by the lambda expression is more than a single line, then the `{ }` are required, as is the `return` keyword. On the other hand, if the only statement in the lambda expression is the `return` statement, then the second, abbreviated form can be used.

# Exercise
In this exercise, you must use either a method delegate or a lambda expression to define the `HelloFunc` variable such that it produces the desired results. The required delegate takes a single `string` argument and returns a `string` result.

@[Delegate Variable Exercise]({"stubs": ["Delegates2/DelegatesExercise2.cs"], "command": "Delegates2.UnitTest.Exercise2", "project": "exercises"})
