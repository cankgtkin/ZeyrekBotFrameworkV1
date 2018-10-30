using Autofac;

namespace ZeyrekFramework.Business.DependencyResolvers.Autofac
{
    public class IocServiceResolver
    {
        public static IContainer Container;

        public static T Get<T>()
        {
            using (var scope = Container.BeginLifetimeScope())
                return scope.Resolve<T>();
        }
    }
}
