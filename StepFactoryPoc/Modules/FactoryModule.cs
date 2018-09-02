using Autofac;
using StepFactoryPoc.Controllers;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Dates.Steps;
using StepFactoryPoc.Settings.Factories;

namespace StepFactoryPoc.Modules
{
    public class FactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(ThisAssembly)
                .SingleInstance()
                .AsImplementedInterfaces()
                .AssignableTo<IViewModelFactory>();

            builder.RegisterType<StepViewModelFactory>()
                .As<IStepViewModelFactory>()
                .SingleInstance();

            builder.RegisterType<StepViewModelFactoryResolver>()
                .As<IStepViewModelFactoryResolver>()
                .SingleInstance();

            builder.RegisterType<DateTimeInputStep>()
                .AsSelf()
                .SingleInstance();

            builder.RegisterType<SomeController>()
                .AsSelf()
                .SingleInstance();

            base.Load(builder);
        }
    }
}