using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFunction1_Arg1_Returned0dot7()
        {
            var functions = new Functions.Functions();
            double x = 1;
            double expected = Math.Round(0.708073418273571, 2);
            double result = functions.Function1(x);
            Assert.AreEqual(expected, Math.Round(result, 2));
        }

        [TestMethod]
        public void TestFunction2_Arg1_Returned0()
        {
            var functions = new Functions.Functions();
            double x = 1;
            double expected = 0;
            double result = functions.Function2(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFunction3_Arg1_Returned6()
        {
            var functions = new Functions.Functions();
            double x = 1;
            double expected = 6;
            double result = functions.Function3(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDoubleFunction3_Arg1_Returned12()
        {
            var functions = new Functions.Functions();
            double x = 1;
            double expected = 12;
            double result = functions.Function3(x);
            result = functions.DoubleResutlt(result);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestFunction1_Arg2_Returned083()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 0.826821810431806;
            double result = functions.Function1(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFunction2_Arg2_Returned14()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 14;
            double result = functions.Function2(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFunction3_Arg2_Returned15()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 16;
            double result = functions.Function3(x);
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void TestDoubleFunction1_Arg2_Returned1dot65()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 1.653643620863612;
            double result = functions.Function1(x);
            result = functions.DoubleResutlt(result);
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestDoubleFunction2_Arg2_Returned28()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 28;
            double result = functions.Function2(x);
            result = functions.DoubleResutlt(result);
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestDoubleFunction3_Arg2_Returned32()
        {
            var functions = new Functions.Functions();
            double x = 2;
            double expected = 32;
            double result = functions.Function3(x);
            result = functions.DoubleResutlt(result);
            Assert.AreEqual(result, expected);
        }
    }
}