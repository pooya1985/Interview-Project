using System;
using Interview.ConsoleUI.Impl;
using Interview.Core.Interfaces;

namespace Interview.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            initialize();

            var printer = DI.Resolve<INumberReplacementPrinter>();
            printer.PrintRange(1,100);
            Console.ReadKey();
        }

        private static void initialize()
        {
            //Would typically use bootstrapper here
            StructureMap.ObjectFactory.Initialize(x => x.AddRegistry(new DependencyRegistry()));
        }
    }
}