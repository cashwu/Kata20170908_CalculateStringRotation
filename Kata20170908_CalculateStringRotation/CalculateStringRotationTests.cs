using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170908_CalculateStringRotation
{
    [TestClass]
    public class CalculateStringRotationTests
    {
        [TestMethod]
        public void input_first_empty_second_empty_should_return_0()
        {
            CalculateRotationStringShouldBe(0, "", "");
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
            return 0;
        }
    }
}
