using Interview.Core.Interfaces;
using Interview.Core.Model;

namespace Interview.Core.Services
{
    public class NumberReplacementPrinter : INumberReplacementPrinter
    {
        private readonly ILineWriter _lineWriter;
        private readonly NumberReplacement[] _numberReplacements;

        public NumberReplacementPrinter(ILineWriter lineWriter, params NumberReplacement[] numberReplacements)
        {
            _lineWriter = lineWriter;
            _numberReplacements = numberReplacements;
        }

        public void PrintRange(int start, int end)
        {
            for (var number = start; number <= end; number++)
            {
                var line = getLineFrom(number);
                _lineWriter.Write(line);
            }
        }

        private string getLineFrom(int number)
        {
            string line = null;

            foreach (var replacement in _numberReplacements)
                line += replacement.GetTextFor(number);

            return string.IsNullOrEmpty(line) ? number.ToString() : line;
        }
    }
}