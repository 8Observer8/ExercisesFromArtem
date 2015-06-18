using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace TestsExercise01
{
    [TestClass]
    public class TestsExercise01
    {
        [TestMethod]
        public void TestJanuary()
        {
            string actual = Program.GetNameOfMonth(1);
            string expected = "January";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFebruary()
        {
            string actual = Program.GetNameOfMonth(2);
            string expected = "February";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMarch()
        {
            string actual = Program.GetNameOfMonth(3);
            string expected = "March";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestApril()
        {
            string actual = Program.GetNameOfMonth(4);
            string expected = "April";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMay()
        {
            string actual = Program.GetNameOfMonth(5);
            string expected = "May";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestJune()
        {
            string actual = Program.GetNameOfMonth(6);
            string expected = "June";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestJuly()
        {
            string actual = Program.GetNameOfMonth(7);
            string expected = "July";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAugust()
        {
            string actual = Program.GetNameOfMonth(8);
            string expected = "August";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSeptember()
        {
            string actual = Program.GetNameOfMonth(9);
            string expected = "September";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOctober()
        {
            string actual = Program.GetNameOfMonth(10);
            string expected = "October";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNovember()
        {
            string actual = Program.GetNameOfMonth(11);
            string expected = "November";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDecember()
        {
            string actual = Program.GetNameOfMonth(12);
            string expected = "December";
            Assert.AreEqual(expected, actual);
        }
    }
}
