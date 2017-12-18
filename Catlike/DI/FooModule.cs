using Autofac;
using Catlike.Services;

namespace Catlike.DI
{
    public class FooModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            
            builder.RegisterType<FooService>().As<IFooService>();
        }
    }
}