using StepFactoryPoc.Core.ViewModels;
using StepFactoryPoc.Dates.Steps;
using StepFactoryPoc.Settings.Steps;

namespace StepFactoryPoc.Settings.ViewModels
{
    public class SettingsViewModel : BaseStepViewModel
    {
        public SettingsViewModel(SettingsStep settingsStep, DateTimeInputStep dateTimeInputStepViewModel)
        {
            StepCreator = settingsStep.Name;
            SomeProperty = dateTimeInputStepViewModel.TimeOfCreation.ToShortDateString();
        }

        public string StepCreator { get; }
    }
}