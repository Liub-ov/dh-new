using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DH_C;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a, b;
            var Alice = new User(5);
            var Bob = new User(4);
            b = Alice.getN(Alice, Bob);
            a = Bob.getN(Bob, Alice);
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a, b;
            var Alice = new User(13);
            var Bob = new User(8);
            b = Alice.getN(Alice, Bob);
            a = Bob.getN(Bob, Alice);
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a, b;
            var Alice = new User(9);
            var Bob = new User(2);
            b = Alice.getN(Alice, Bob);
            a = Bob.getN(Bob, Alice);
            Assert.AreEqual(a, b);
        }
    }
}
