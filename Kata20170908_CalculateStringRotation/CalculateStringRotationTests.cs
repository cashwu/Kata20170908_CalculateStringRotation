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

        [TestMethod]
        public void input_first_abc_second_bca_should_return_2()
        {
            CalculateRotationStringShouldBe(2, "abc", "bca");
        }

        [TestMethod]
        public void input_first_coff_second_ffco_should_return_2()
        {
            CalculateRotationStringShouldBe(2, "coff", "ffco");
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

            for (int i = 1; i <= first.Length; i++)
            {
                var rotationString = second.Substring(i) + string.Concat(second.Take(i));

                if (first == rotationString)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
