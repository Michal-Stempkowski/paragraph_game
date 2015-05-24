using System;
using Logic.Expanded;

namespace Logic.Templates
{
    public abstract class VariableTemplate<TValue, TExpanded> : ILogicTemplate 
        where TExpanded : ILogic
    {
        protected VariableTemplate(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public ILogic ExpandLogic(IWorldState worldState)
        {
            var value = GetValueFromWorldState(worldState);
            if (value == null)
            {
                throw new VariableDoesNotExistException(Name);
            }
            
            return ValueToVariable(value);
        }

        public abstract TValue GetValueFromWorldState(IWorldState worldState);

        public abstract TExpanded ValueToVariable(TValue value);
    }
}