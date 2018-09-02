using System;
using StepFactoryPoc.Core.Steps;
using StepFactoryPoc.Core.ViewModels;

namespace StepFactoryPoc.Core.Factories
{
    public interface IViewModelFactory
    {
        BaseStepViewModel CreateStepViewModel(IStepBase step);
        Type StepType { get; }
    }
}