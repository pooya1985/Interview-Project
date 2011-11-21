using Interview.Core.Interfaces;
using Interview.Core.Model;
using Interview.Core.Services;

namespace Interview.ConsoleUI.Impl
{
    public class DependencyRegistry : StructureMap.Configuration.DSL.Registry
    {
        public DependencyRegistry()
        {
            For<INumberReplacementPrinter>()
                .Use<NumberReplacementPrinter>()
                .EnumerableOf<NumberReplacement>()
                .Contains(x =>
                              {
                                  x.IsThis(new MultipleOfNumberReplacement(3, "Fizz"));
                                  x.IsThis(new MultipleOfNumberReplacement(5, "Buzz"));
                                  x.IsThis(new MultipleOfNumberReplacement(42, "The Answer"));
                                  x.IsThis(new MultipleOfNumberReplacement(0, "Not Happening unless 0"));
                              });

            For<ILineWriter>().Use<ConsoleWriter>();
        }
    }
}