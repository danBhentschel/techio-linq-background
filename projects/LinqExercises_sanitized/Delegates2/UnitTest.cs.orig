using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace Delegates2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise2()
        {
            var inputs = new[] {"World", "Dolly", "there"};
            var answers = inputs.Select(_ => DelegatesExercise2.HelloFunc(_)).ToList();

            if (answers == null)
            {
                Utils.TechioMessage("You need to call Exercise.TestSayHello()");
            }
            Assert.IsNotNull(answers);
            Utils.AssertAreEqual("Hello, World!", answers[0], inputs[0]);
            Utils.AssertAreEqual("Hello, Dolly!", answers[1], inputs[1]);
            Utils.AssertAreEqual("Hello, there!", answers[2], inputs[2]);

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("Congratulations, you did it!");
        }
    }
}
