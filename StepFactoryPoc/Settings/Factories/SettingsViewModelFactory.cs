using System;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;
using StepFactoryPoc.Dates.Steps;
using StepFactoryPoc.Settings.Steps;
using StepFactoryPoc.Settings.ViewModels;

namespace StepFactoryPoc.Settings.Factories
{
    public class SettingsViewModelFactory : IViewModelFactory
    {
        private readonly DateTimeInputStep _dateTimeInputStepViewModel;

        public SettingsViewModelFactory(DateTimeInputStep dateTimeInputStepViewModel)
        {
            _dateTimeInputStepViewModel = dateTimeInputStepViewModel;
        }
        public BaseStepViewModel CreateStepViewModel(IStepBase stepBase)
        {
            return new SettingsViewModel(stepBase as SettingsStep, _dateTimeInputStepViewModel);
        }

        public Type StepType => typeof(SettingsStep);
    }
}