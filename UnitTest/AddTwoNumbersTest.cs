using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeDemo;

namespace UnitTest
{
    [TestClass]
    public class AddTwoNumbersTest
    {
        private static readonly ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        private static readonly ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        [TestMethod]
        public void Test_ddTwoNumbersDemo()
        {
            var result = AddTwoNumbersDemo.AddTwoNumbers(l1, l2);
            Assert.AreEqual(7, result.val);
        }
    }
}
