using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Delegates1
    {
        //// START EMBED: Example delegate declaration ////
        private delegate int FuncTwoInts(int one, int two);
        //// END EMBED ////

        //// START EMBED: Delegate expressions 1 ////
        private static int Add(int one, int two)
        {
            return one + two;
        }

        private FuncTwoInts theFunc = Add;
        //// END EMBED ////

        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Delegate expressions 2 ////
            FuncTwoInts theFunc = delegate (int one, int two)
            {
                return one + two;
            };
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: Delegate expressions 3 ////
            FuncTwoInts theFunc = (one, two) =>
            {
                return one + two;
            };
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Delegate expressions 4 ////
            FuncTwoInts theFunc = (one, two) => one + two;
            //// END EMBED ////
        }

        //// START EMBED: Delegates as parameters ////
        private static void PrintWith_2and4(FuncTwoInts func)
        {
            int result = func(2, 4);
            Console.WriteLine(result);
        }
        //// END EMBED ////

        //// START EMBED: Passing a delegate to a method ////
        private static void Execute()
        {
            // Prints 8
            PrintWith_2and4((first, second) => first * second);

            // Prints 6
            PrintWith_2and4((one, two) => one + two);

            // Prints 224
            PrintWith_2and4((a, b) => int.Parse($"{a}{a}{b}"));

            // Prints 9999
            PrintWith_2and4((foo, bar) => 9999);
        }
        //// END EMBED ////

        //// START EMBED: SayHello declaration ////
        private delegate void SayHello();

        private SayHello helloFunction = () => Console.WriteLine("Hello!");
        //// END EMBED ////

        //// START EMBED: SayGoodbye declaration ////
        private delegate void SayGoodbye();

        private SayGoodbye goodbyeFunction = () => Console.WriteLine("Goodbye!");
        //// END EMBED ////

        //// START EMBED: SayAnything declaration ////
        private delegate void SayAnything();

        private SayAnything helloFunction2 = () => Console.WriteLine("Hello!");
        private SayAnything goodbyeFunction2 = () => Console.WriteLine("Goodbye!");
        //// END EMBED ////

        //// START EMBED: Example Action usage ////
        private Action supFunction = () => Console.WriteLine("Sup?!");
        //// END EMBED ////

        //// START EMBED: Example Action usage 2 ////
        private Action<string, int, bool> printThreeValues =
            (s, i, b) => Console.WriteLine($"string: {s}, int: {i}, bool: {b}");
        //// END EMBED ////

        //// START EMBED: Example Func usage ////
        private Func<int> twoPlusThree = () => 2 + 3;
        //// END EMBED ////


        //// START EMBED: Example Func usage 2 ////
        private Func<string, string, int> sumCharacters = 
            (s1, s2) => s1.Length + s2.Length;
        //// END EMBED ////


    }
}