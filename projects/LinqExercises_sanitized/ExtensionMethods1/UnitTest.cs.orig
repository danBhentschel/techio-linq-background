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
            Utils.TechioMessage("About to test DoSayHello(\"World\")");
            var answer = ExtensionMethodsExercise1.DoSayHello("World");
            Utils.AssertAreEqual("Hello, World!", answer, "World");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("About to test DoSayHello(\"Dolly\")");
            answer = ExtensionMethodsExercise1.DoSayHello("Dolly");
            Utils.AssertAreEqual("Hello, Dolly!", answer, "Dolly");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("About to test DoSayHello(\"Nurse\")");
            answer = ExtensionMethodsExercise1.DoSayHello("Nurse");
            Utils.AssertAreEqual("Hello, Nurse!", answer, "Nurse");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("Congratulations, you did it!");
        }
    }
}
