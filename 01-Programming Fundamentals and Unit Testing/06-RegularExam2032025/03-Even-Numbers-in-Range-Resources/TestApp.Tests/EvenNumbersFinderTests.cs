using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class EvenNumbersFinderTests
    {
        [Test]
        public void Test_FindEvenNumbers_StartGreaterThanEnd_ReturnsErrorMessage()
        {
            int numStartGreater = 10;
            int numEndSmaller = 1;
            string expected = "Start number should not be greater than end number.";

            string actual = EvenNumbersFinder.FindEvenNumbers(numStartGreater, numEndSmaller);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_NoEvenNumbersInRange_ReturnsEmptyString()
        {
            int numStart = 23;
            int numEnd = 23;

            string actual = EvenNumbersFinder.FindEvenNumbers(numStart, numEnd);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Test_FindEvenNumbers_SingleEvenNumberInRange_ReturnsThatNumber()
        {
            int numStart = 21;
            int numEnd = 23;
            string expected = "22";

            string actual = EvenNumbersFinder.FindEvenNumbers(numStart, numEnd);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_MultipleEvenNumbersInRange_ReturnsEvenNumbers()
        {
            int numStart = 1;
            int numEnd = 5;
            string expected = "2 4";

            string actual = EvenNumbersFinder.FindEvenNumbers(numStart, numEnd);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_ZeroInRange_ReturnsZero()
        {
            int numStart = 0;
            int numEnd = 0;
            string expected = "0";

            string actual = EvenNumbersFinder.FindEvenNumbers(numStart, numEnd);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
