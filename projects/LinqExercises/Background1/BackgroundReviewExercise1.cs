﻿using System.Collections.Generic;

namespace Background1
{
    // Uncomment the TransformationFunction delegate declaration
    //
    // following the examples in the lessons, declare the type
    // TransformationFunction as a delegate that takes a single
    // int parameter and returns an int result.

    // public ... TransformationFunction ...
    //// START SOLUTION ////
    public delegate int TransformationFunction(int val);
    //// END SOLUTION ////

    // Write the extension method (and containing class) here,
    // following the examples in the lessons. The method should
    // be called Transform(), extend IEnumerable<int>, take an
    // extra parameter of type TransformationFunction, and
    // return an IEnumerable<int>.

    // public ... class ...
    // { }
    //// START SOLUTION ////
    public static class Foo
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> data, TransformationFunction func)
        {
            foreach (var val in data)
            {
                yield return func(val);
            }
        }
    }
    //// END SOLUTION ////
}