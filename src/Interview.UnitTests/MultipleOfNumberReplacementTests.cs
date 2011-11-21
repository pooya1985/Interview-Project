using Interview.Core.Model;
using NUnit.Framework;

namespace Interview.UnitTests
{
    [TestFixture]
    public class MultipleOfNumberReplacementTests
    {
        [Test]
        public void GetTextFor_should_return_fizz_when_multiple_of_three_is_passed()
        {
            var replacement = new MultipleOfNumberReplacement(3, "Fizz");
            var test = replacement.GetTextFor(9);

            Assert.That(test, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetTextFor_should_return_null_when_number_is_not_multiple_of_three()
        {
            var replacement = new MultipleOfNumberReplacement(3, "Fizz");
            var test = replacement.GetTextFor(10);

            Assert.That(test, Is.Null);
        }
    }
}