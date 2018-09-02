using System;
using Autofac;
using Newtonsoft.Json;
using StepFactoryPoc.Controllers;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Modules;

namespace StepFactoryPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<FactoryModule>();
            var rootContainer = builder.Build();

            using (var childScope = rootContainer.BeginLifetimeScope())
            {
                var controller = childScope.Resolve<SomeController>();
                var accountPageViewmodel = controller.RenderAccountPage();
                Console.WriteLine("Rendering AccountViewModel");
                Console.WriteLine(JsonConvert.SerializeObject(accountPageViewmodel));
                
                var settingsViewmodel = controller.RenderSettingsPage();
                Console.WriteLine("Rendering SettingsViewModel");
                Console.WriteLine(JsonConvert.SerializeObject(settingsViewmodel));
                Console.ReadLine();
            }
        }
    }
}
