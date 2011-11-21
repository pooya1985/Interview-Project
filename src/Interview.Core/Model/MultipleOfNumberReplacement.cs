using Interview.Core.Helpers;

namespace Interview.Core.Model
{
    public class MultipleOfNumberReplacement : NumberReplacement
    {
        public MultipleOfNumberReplacement(int number, string text) : base(number, text)
        {}

        public override string GetTextFor(int number)
        {
            return number.IsMultipleOf(Number) ? Text : null;
        }
    }
}