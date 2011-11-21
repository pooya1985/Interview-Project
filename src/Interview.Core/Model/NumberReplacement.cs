namespace Interview.Core.Model
{
    public abstract class NumberReplacement : NumberWithText
    {
        protected NumberReplacement(int number, string text) : base(number, text)
        {}

        public abstract string GetTextFor(int number);
    }
}