using System.Collections.Generic;
using Interview.Core.Interfaces;

namespace Interview.UnitTests
{
    public class TestWriter : ILineWriter
    {
        public TestWriter()
        {
            Lines = new List<string>();
        }

        public IList<string> Lines { get; set; }

        public void Write(string line)
        {
            Lines.Add(line);
        }
    }
}