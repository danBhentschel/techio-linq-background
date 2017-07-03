using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethods2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise2()
        {
            Utils.TechioMessage("\"World\".MakePlural(1)");
            var answer = "World".MakePlural(1);
            Utils.AssertAreEqual("World", answer, "World");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("\"Universe\".MakePlural(2)");
            answer = "Universe".MakePlural(2);
            Utils.AssertAreEqual("Universes", answer, "Universe");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("\"Nurse\".MakePlural(3)");
            answer = "Nurse".MakePlural(3);
            Utils.AssertAreEqual("Nurses", answer, "Nurse");

            Utils.TechioMessage(string.Empty);
            Utils.TechioMessage("Congratulations, you did it!");
        }
    }
}
