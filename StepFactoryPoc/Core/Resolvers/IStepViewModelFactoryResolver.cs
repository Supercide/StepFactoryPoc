using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Core.Steps;

namespace StepFactoryPoc.Core.Resolvers
{
    public interface IStepViewModelFactoryResolver
    {
        IViewModelFactory Resolve(IStepBase step);
    }
}