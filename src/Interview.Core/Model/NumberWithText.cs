namespace Interview.Core.Model
{
    public class NumberWithText
    {
        public NumberWithText(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public int Number { get; set; }
        public string Text { get; set; }
    }
}