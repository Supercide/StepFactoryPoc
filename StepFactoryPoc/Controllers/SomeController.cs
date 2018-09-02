using StepFactoryPoc.Accounts.Steps;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;
using StepFactoryPoc.Settings.Steps;

namespace StepFactoryPoc.Controllers
{
    public class SomeController
    {
        private readonly IStepViewModelFactory _factory;

        public SomeController(IStepViewModelFactory factory)
        {
            _factory = factory;
        }

        public BaseStepViewModel RenderSettingsPage()
        {
            IStepBase settingsStep = new SettingsStep();
            return _factory.CreateStepViewModel(settingsStep);
        }

        public BaseStepViewModel RenderAccountPage()
        {
            IStepBase settingsStep = new AccountStep();
            return _factory.CreateStepViewModel(settingsStep);
        }
    }
}