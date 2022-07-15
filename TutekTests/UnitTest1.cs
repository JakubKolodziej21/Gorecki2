using NUnit.Framework;

namespace TutekTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            TutekDirask.Fraction fractionA = new TutekDirask.Fraction(1, 2);
            TutekDirask.Fraction fractionB = new TutekDirask.Fraction(3, 4);
            TutekDirask.Fraction result = fractionA + fractionB;

            Assert.AreEqual(result.ToString(), "10 / 8");
        }

        [Test]
        public void Test2()
        {
            TutekDirask.Fraction fractionA = new TutekDirask.Fraction(1, 2);
            int result = fractionA.toCeil();

            Assert.AreEqual(result, 1);
        }
    }
}