using StepFactoryPoc.Core.Factories;

namespace StepFactoryPoc.Core.Resolvers
{
    public interface IStepViewModelFactoryResolver
    {
        IViewModelFactory Resolve<T>();
    }
}