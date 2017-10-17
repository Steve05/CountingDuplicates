using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingDuplicates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void input_empty_should_return_zero()
        {
            AssertDuplicateCountShouldBe(0, "");
        }

        [TestMethod]
        public void input_abcde_should_return_zero()
        {
            AssertDuplicateCountShouldBe(0, "abcde");
        }

        [TestMethod]
        public void input_aabbcde_should_return_two()
        {
            AssertDuplicateCountShouldBe(2, "aabBcde");
        }

        [TestMethod]
        public void input_aabBcde_should_return_two()
        {
            AssertDuplicateCountShouldBe(2, "aabBcde");
        }

        [TestMethod]
        public void input_Indivisibility_should_return_one()
        {
            AssertDuplicateCountShouldBe(1, "Indivisibility");
        }

        [TestMethod]
        public void input_Indivisibilities_should_return_two()
        {
            AssertDuplicateCountShouldBe(2, "Indivisibilities");
        }

        private static void AssertDuplicateCountShouldBe(int expected, string str)
        {
            var kata = new Kata();
            var actual = kata.DuplicateCount(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int DuplicateCount(string str)
        {
            return string.IsNullOrEmpty(str) ? 0 : str.ToLower().GroupBy(x => x).Count(@group => @group.Count() >= 2);
        }

    }
}

   


