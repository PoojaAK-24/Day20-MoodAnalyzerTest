using Day20_MoodAnalyzerAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("sad");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }

    }
}

