using System;
using Logic.Expanded;

namespace Logic.Templates
{
    public class StringVariableTemplate : VariableTemplate<string, Variable<string>>
    {
        public StringVariableTemplate(string name) : base(name)
        {
        }

        public override string GetValueFromWorldState(IWorldState worldState)
        {
            return worldState.GetString(Name);
        }

        public override Variable<string> ValueToVariable(string value)
        {
            return new Variable<string>(Name, value);
        }
    }
}
