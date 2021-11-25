using NUnit.Framework;
using System.Collections.Generic;

namespace ExploringMars.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSucess()
        {
            var limitXY = (X: 5, Y: 5);
            var positionProbe = (X: 1, Y: 2, direction: 'N');
            string actual = Control.ControlProbe(limitXY, positionProbe, "LMLMLMLMM");

            string expected = "1 3 N";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestExploringLimits()
        {
            var limitXY = (X: 4, Y: 4);
            var positionProbe = (X: 3, Y: 3, direction: 'E');
            string actual = Control.ControlProbe(limitXY, positionProbe, "MMRMMRMRRM");

            string expected = "4 1 E";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGetSpaceLimit()
        {
            var input = "5 5";

            var actual = Control.GetSpaceLimit(input);

            var expected = (5, 5);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGetInitPosition()
        {
            var input = "1 2 N";

            var actual = Control.GetInitPosition(input);

            var expected = (1, 2, 'N');

            Assert.AreEqual(expected, actual);
        }

        //(List<string> inputs)
        [Test]
        public void TestRunProbesControl()
        {
            List<string> input = new List<string>();
            input.Add("5 5");
            input.Add("1 2 N");
            input.Add("LMLMLMLMM");
            input.Add("3 3 E");
            input.Add("MMRMMRMRRM");

            var actual = Control.RunProbesControl(input);

            List<string> expected = new List<string>();
            expected.Add("1 3 N");
            expected.Add("5 1 E");

            Assert.AreEqual(expected, actual);
        }
    }
}