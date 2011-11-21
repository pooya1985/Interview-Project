using System;
using Interview.Core.Interfaces;

namespace Interview.ConsoleUI.Impl
{
    class ConsoleWriter : ILineWriter
    {
        public void Write(string line)
        {
            Console.WriteLine(line);
        }
    }
}