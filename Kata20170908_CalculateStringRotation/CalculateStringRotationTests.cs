using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170908_CalculateStringRotation
{
    [TestClass]
    public class CalculateStringRotationTests
    {
        [TestMethod]
        public void input_first_empty_second_empty_should_return_0()
        {
            CalculateRotationStringShouldBe(0, " ", " ");
        }

        [TestMethod]
        public void input_first_abc_second_cba_should_return_1()
        {
            CalculateRotationStringShouldBe(1, "abc", "cab");
        }

        private static void CalculateRotationStringShouldBe(int expected, string first, string second)
        {
            var rotation = new CalculateStringRotation();
            var actual = rotation.ShiftedDiff(first, second);
            Assert.AreEqual(expected, actual);
        }
    }

    public class CalculateStringRotation
    {
        public int ShiftedDiff(string first, string second)
        {
            if (first == second)
            {
                return 0;
            }

            var firstChar = first.Last();
            return second.IndexOf(firstChar) + 1;
        }
    }
}
