using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace UnitTest
{
    [TestClass]
    public class TwoNumTest
    {
        [TestMethod]
        public void Test_TwoNum_One()
        {
            var result = TwoNumDemo.TwoSum_One(new int[] { 11, 15, 20, 45, 44, 33, 2, 7 }, 9);
            Assert.AreEqual(6, result[0]);
        }

        [TestMethod]
        public void Test_TwoNum_Two()
        {
            var result = TwoNumDemo.TwoSum_Two(new int[] { 11, 15, 20, 45, 44, 33, 2, 7 }, 9);
            Assert.AreEqual(6, result[0]);
        }
    }
}
