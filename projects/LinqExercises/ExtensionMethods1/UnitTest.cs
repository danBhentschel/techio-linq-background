using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethods1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.TechioMessage("\"World\".SayHello()");
            var answer = "World".SayHello();
            Utils.AssertAreEqual("Hello, World!", answer, "World");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("\"Dolly\".SayHello()");
            answer = "Dolly".SayHello();
            Utils.AssertAreEqual("Hello, Dolly!", answer, "Dolly");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("\"Nurse\".SayHello()");
            answer = "Nurse".SayHello();
            Utils.AssertAreEqual("Hello, Nurse!", answer, "Nurse");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("Congratulations, you did it!");
        }
    }
}
