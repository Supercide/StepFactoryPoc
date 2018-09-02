using System;
using StepFactoryPoc.Accounts.Steps;
using StepFactoryPoc.Core.Resolvers;
using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;
using StepFactoryPoc.Settings.Steps;

namespace StepFactoryPoc.Core.Factories
{
    public class StepViewModelFactory : IStepViewModelFactory
    {
        private readonly IStepViewModelFactoryResolver _stepViewModelFactoryResolver;

        public StepViewModelFactory(IStepViewModelFactoryResolver stepViewModelFactoryResolver)
        {
            _stepViewModelFactoryResolver = stepViewModelFactoryResolver;
        }
        public BaseStepViewModel CreateStepViewModel(IStepBase step)
        {
            var settingsFactory = _stepViewModelFactoryResolver.Resolve(step);
            return settingsFactory.CreateStepViewModel(step);
        }
    }
}