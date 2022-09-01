using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StringMayContainNonBracketCharacters()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Non Bracket Characters."));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void TestStringOneReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void TestStringTwoReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void TestStringThreeReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void TestStringFourReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void TestStringFiveReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void TestStringSixReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void TestStringSevenReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void StringParameterReturnsTrueIfBalanced()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("True[][]LaunchCode[][]Balanced"));
        }

        [TestMethod]
        public void StringParameterReturnsFalseIfUnbalanced()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][LaunchCode]["));
        }
    }
}


