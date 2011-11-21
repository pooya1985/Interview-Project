using System.Linq;
using Interview.Core.Interfaces;
using Interview.Core.Model;
using Interview.Core.Services;
using Moq;
using NUnit.Framework;

namespace Interview.UnitTests
{
    [TestFixture]
    public class NumberReplacementPrinterTest
    {
        [Test]
        public void NumberReplacementPrinter_should_write_number_if_not_multiple_match()
        {
            var writer = new TestWriter();
            var printer = new NumberReplacementPrinter(writer, new MultipleOfNumberReplacement(3, "Fizz"));
            printer.PrintRange(1, 10);

            Assert.That(writer.Lines.Count(x => x == "2"), Is.EqualTo(1));
            Assert.That(writer.Lines.Any(x => x == "2"), Is.True);
        }

        [Test]
        public void NumberReplacementPrinter_should_write_fizz_when_multiple_of_three()
        {
            var writer = new TestWriter();
            var printer = new NumberReplacementPrinter(writer, new MultipleOfNumberReplacement(3, "Fizz"));
            printer.PrintRange(1, 10);

            Assert.That(writer.Lines.Count(x => x == "Fizz"), Is.EqualTo(3));
            Assert.That(writer.Lines.Any(x => x == "3"), Is.False);
        }

        [Test]
        public void NumberReplacementPrinter_should_write_fizzbuzz_when_multiple_of_three_and_five()
        {
            var writer = new TestWriter();
            var printer = new NumberReplacementPrinter(writer, new MultipleOfNumberReplacement(3, "Fizz"), new MultipleOfNumberReplacement(5, "Buzz"));
            printer.PrintRange(1, 15);

            Assert.That(writer.Lines.Count(x => x == "FizzBuzz"), Is.EqualTo(1));
            Assert.That(writer.Lines.Any(x => x == "3"), Is.False);
            Assert.That(writer.Lines.Any(x => x == "5"), Is.False);
        }

        [Test]
        public void NumberReplacementPrinter_should_write_0_when_multiple_of_zero_is_passed_in_regardless_of_the_word_specified_unless_zero()
        {
            var writer = new TestWriter();
            var printer = new NumberReplacementPrinter(writer, new MultipleOfNumberReplacement(0, "Should not happen unless zero"));
            printer.PrintRange(0, 50);

            Assert.That(writer.Lines.Count(x => x == "Should not happen unless zero"), Is.EqualTo(1));
        }

        [Test]
        public void NumberReplacementPrinter_should_call_LinePrinter_write()
        {
            var writer = new Mock<ILineWriter>();
            var printer = new NumberReplacementPrinter(writer.Object);
            printer.PrintRange(1, 1);

            writer.Verify(x => x.Write("1"));
        }

        [Test]
        public void NumberReplacementPrinter_should_write_50_lines_for_1_through_50_range()
        {
            var writer = new TestWriter();
            var printer = new NumberReplacementPrinter(writer);
            printer.PrintRange(1, 50);

            Assert.That(writer.Lines.Count, Is.EqualTo(50));
        }
    }
}