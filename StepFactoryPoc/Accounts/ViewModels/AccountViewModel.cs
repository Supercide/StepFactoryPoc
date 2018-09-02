using StepFactoryPoc.Accounts.Steps;
using StepFactoryPoc.Core.ViewModels;

namespace StepFactoryPoc.Accounts.ViewModels
{
    public class AccountViewModel : BaseStepViewModel
    {
        public AccountViewModel(AccountStep accountStep)
        {
            SomeProperty = $"Created from {accountStep.Name}";
        }
    }
}