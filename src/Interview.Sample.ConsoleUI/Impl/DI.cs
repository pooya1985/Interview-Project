namespace Interview.ConsoleUI.Impl
{
    public class DI
    {
        public static T Resolve<T>()
        {
            return StructureMap.ObjectFactory.GetInstance<T>();
        }
    }
}
