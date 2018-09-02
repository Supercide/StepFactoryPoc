using System;
using StepFactoryPoc.Accounts.Steps;
using StepFactoryPoc.Accounts.ViewModels;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;

namespace StepFactoryPoc.Accounts.Factories
{
    public class AccountViewModelFactory : IViewModelFactory
    {
        public BaseStepViewModel CreateStepViewModel(IStepBase step)
        {
            return new AccountViewModel(step as AccountStep);
        }

        public Type StepType => typeof(AccountStep);
    }
}