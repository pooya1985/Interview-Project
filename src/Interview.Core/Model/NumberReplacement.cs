namespace Interview.Core.Model
{
    public abstract class NumberReplacement
    {
       private readonly NumberWithText _numberWithText;

        protected NumberReplacement(){}
        protected NumberReplacement(int number, string text)
        {
            _numberWithText = new NumberWithText(number, text);
        }

        public abstract string GetTextFor(int number);

        protected NumberWithText NumberWithText
        {
            get { return _numberWithText; }
        }
    }
}