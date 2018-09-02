namespace StepFactoryPoc.Core.Factories
{
    public interface IStepViewModelFactoryResolver
    {
        IViewModelFactory Resolve<T>();
    }
}