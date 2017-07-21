# Extra credit - Action and Func
> **Feeling a bit overwhelmed?** The content on this page is optional. It can make your life easier, but it requires a bit more knowledge to understand than the other content in this course. Feel free to skip to the next lesson if you want to.

## Action type
Writing a delegate type for each delegate that you want to declare gets a bit repetitive. For example, suppose you were to write this `SayHello` delegate:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, SayHello declaration
```
Looks good, right? But imagine if you later wanted to declare another delegate that can say goodbye? You could reuse the `SayHello` type, but that doesn't make much sense, does it?

You could instead declare a new delegate type:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, SayGoodbye declaration
```
But notice that `SayGoodbye` is, other than its name, exactly the same as `SayHello`. Maybe it would be better to rename `SayHello` to something more generic like `SayAnything`...

But then what do you do when you need to declare another delegate type that takes no parameters and returns `void`? Maybe that declaration should be called `DoAnything`! But then you'd need to declare that type for every project that you work on...

See where this is headed?

There is a family of built-in delegate type declarations that can be used to define commonly-used delegates without the need to declare a custom type. The types that define a delegate without a return value (`void` return) are the [`Action`](https://msdn.microsoft.com/en-us/library/system.action(v=vs.110).aspx) types in the [`System`](https://msdn.microsoft.com/en-us/library/system(v=vs.110).aspx#Anchor_3) namespace.

Here is an example using `Action` to declare a delegate variable:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Action usage
```

But what if you want to pass some parameters to your delegate? That's covered as well. There's an [`Action<T>`](https://msdn.microsoft.com/en-us/library/018hxwa8(v=vs.110).aspx) that takes one parameter, or [`Action<T1, T2>`](https://msdn.microsoft.com/en-us/library/bb549311(v=vs.110).aspx) takes two parameters, and so on all the way up to an `Action` that takes 16 parameters.

Here's an example of a delegate that takes three parameters of different types:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Action usage 2
```

## Func type
`Action` is good for delegates that return `void`, but what about delegates that return a value? That's where [`Func<TResult>`](https://msdn.microsoft.com/en-us/library/bb534960(v=vs.110).aspx) comes in. The `Func` family of delegate types can return a value of any type you wish. For example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Func usage
```

What about passing parameters? Then you need [`Func<T, TResult>`](https://msdn.microsoft.com/en-us/library/bb549151(v=vs.110).aspx) for delegates that take one parameter, and [`Func<T1, T2, TResult>`](https://msdn.microsoft.com/en-us/library/bb534647(v=vs.110).aspx) for two parameters, etc. Just as with `Action`, the framework has delegates that support all the way up to 16 parameters.

Here is an example of a delegate declaration that takes two parameters:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Delegates1.cs, Example Func usage 2
```