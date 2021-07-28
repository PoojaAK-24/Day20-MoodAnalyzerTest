using Day20_MoodAnalyzerAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Refactor UC-1
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in happy mood");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood ");
            string result = obj.analyseMood();
            Assert.AreEqual("SAD", result);
        }
        //Refactor UC-1

        //UC-2
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
        //UC-2

        //UC-3
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodEmpty_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser();
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
        // UC-3
    }
}

