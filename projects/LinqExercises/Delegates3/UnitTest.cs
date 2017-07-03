using System.Collections.Generic;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates3
{
    [TestClass]
    public class UnitTest
    {
        public static List<string> Answers;

        [TestMethod]
        public void Exercise3()
        {
            Answers = null;

            DelegatesExercise3.DoSayHello();

            if (Answers == null)
            {
                Utils.TechioMessage("You need to call Exercise.TestSayHello()");
            }
            Assert.IsNotNull(Answers);
            Utils.AssertAreEqual("Hello, World!", Answers[0], "World");
            Utils.AssertAreEqual("Hello, Dolly!", Answers[1], "Dolly");
            Utils.AssertAreEqual("Hello, there!", Answers[2], "there");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("Congratulations, you did it!");
        }
    }
}
