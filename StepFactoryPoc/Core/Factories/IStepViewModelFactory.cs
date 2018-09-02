using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;

namespace StepFactoryPoc.Core.Factories
{
    public interface IStepViewModelFactory
    {
        BaseStepViewModel CreateStepViewModel(IStepBase step);
    }
}