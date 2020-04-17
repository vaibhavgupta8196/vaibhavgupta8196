using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestBusinessLayer;

namespace UnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginPositive()
        {
            Login login = new Login();
            bool actual = login.validate("raj", "raj#123");
            Assert.AreEqual<bool>(true, actual);
        }
        [TestMethod]
        public void TestLoginWrongUsername()
        {
            Login login = new Login();
            bool actual = login.validate("rajhg", "raj#123");
            Assert.AreEqual<bool>(false, actual);
        }
        [TestMethod]
        public void TestLoginWrongPassword()
        {
            Login login = new Login();
            bool actual = login.validate("raj", "rnbvaj#123");
            Assert.AreEqual<bool>(false, actual);
        }
        [TestMethod]
        public void TestLoginWrongUsernameAndPassword()
        {
            Login login = new Login();
            bool actual = login.validate("rambvbjhg", "ramvj#123");
            Assert.AreEqual<bool>(false, actual);
        }
        [TestMethod]
        public void TestLoginEmptyUsername()
        {
            Login login = new Login();
            bool actual = login.validate("", "raj#123");
            Assert.AreEqual<bool>(false, actual);
        }
        [TestMethod]
        public void TestLoginEmptyPassword()
        {
            Login login = new Login();
            bool actual = login.validate("raj", "");
            Assert.AreEqual<bool>(false, actual);
        }
        [TestMethod]
        public void TestLoginEmptyUsernameAndPassword()
        {
            Login login = new Login();
            bool actual = login.validate("", "");
            Assert.AreEqual<bool>(false, actual);
        }

    }
}
