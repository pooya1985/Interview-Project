namespace Interview.Core.Helpers
{
    public static class Extensions
    {
        public static bool IsMultipleOf(this int i, int number)
        {
            if (number == 0 && i == 0)
                return true;

            if (number == 0)
                return false;

            return i % number == 0;
        }
    }
}