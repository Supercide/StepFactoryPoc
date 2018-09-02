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
            switch (step)
            {
                case SettingsStep settingsStep:
                    var settingsFactory = _stepViewModelFactoryResolver.Resolve<SettingsStep>();
                    return settingsFactory.CreateStepViewModel(settingsStep);

                case AccountStep accountStep:
                    var accountFactory = _stepViewModelFactoryResolver.Resolve<AccountStep>();
                    return accountFactory.CreateStepViewModel(accountStep);

                default:
                    throw new ArgumentException("Unknown step", nameof(step));
            }
        }
    }
}