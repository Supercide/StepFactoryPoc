using System;
using System.Collections.Generic;
using System.Linq;
using StepFactoryPoc.Core.Factories;

namespace StepFactoryPoc.Core.Resolvers
{
    public class StepViewModelFactoryResolver : IStepViewModelFactoryResolver
    {
        private IReadOnlyDictionary<Type, IViewModelFactory> _factories;

        public StepViewModelFactoryResolver(IEnumerable<IViewModelFactory> factories)
        {
            _factories = factories.ToDictionary(x => x.StepType);
        }

        public IViewModelFactory Resolve<T>()
        {
            if (_factories.ContainsKey(typeof(T)))
            {
                return _factories[typeof(T)];
            }

            throw new KeyNotFoundException($"The step type provided for the {nameof(StepViewModelFactoryResolver)} has no factories associated with it");
        }
    }
}