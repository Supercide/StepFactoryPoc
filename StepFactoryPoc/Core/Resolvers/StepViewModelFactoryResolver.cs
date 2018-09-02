using System;
using System.Collections.Generic;
using System.Linq;
using StepFactoryPoc.Core.Factories;
using StepFactoryPoc.Core.Steps;

namespace StepFactoryPoc.Core.Resolvers
{
    public class StepViewModelFactoryResolver : IStepViewModelFactoryResolver
    {
        private readonly IReadOnlyDictionary<Type, IViewModelFactory> _factories;

        public StepViewModelFactoryResolver(IEnumerable<IViewModelFactory> factories)
        {
            _factories = factories.ToDictionary(x => x.StepType);
        }

        public IViewModelFactory Resolve(IStepBase stepBase)
        {
            if (_factories.ContainsKey(stepBase.GetType()))
            {
                return _factories[stepBase.GetType()];
            }

            throw new KeyNotFoundException($"The step type provided for the {nameof(StepViewModelFactoryResolver)} has no factories associated with it");
        }
    }
}