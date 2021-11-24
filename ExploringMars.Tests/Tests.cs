using NUnit.Framework;

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
    }
}