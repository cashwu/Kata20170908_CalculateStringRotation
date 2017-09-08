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

        [TestMethod]
        public void input_first_eecoff_second_coffee_should_return_4()
        {
            CalculateRotationStringShouldBe(4, "eecoff", "coffee");
        }

        [TestMethod]
        public void input_first_Moose_second_moose_should_return_n1()
        {
            CalculateRotationStringShouldBe(-1, "Moose", "moose");
        }

        [TestMethod]
        public void input_first_isnt_second_tisn_should_return_2()
        {
            CalculateRotationStringShouldBe(2, "isn't", "'tisn");
        }

        [TestMethod]
        public void input_first_Esham_second_Esham_should_return_0()
        {
            CalculateRotationStringShouldBe(0, "Esham", "Esham");
        }

        [TestMethod]
        public void input_first_hoop_second_pooh_should_return_n1()
        {
            CalculateRotationStringShouldBe(-1, "hoop", "pooh");
        }

        [TestMethod]
        public void input_first_2_whitespace_second_1_whitespace_should_return_n1()
        {
            CalculateRotationStringShouldBe(-1, "  ", " ");
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

            for (int i = 1; i <= second.Length; i++)
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
