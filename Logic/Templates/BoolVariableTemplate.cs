using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Expanded;

namespace Logic.Templates
{
    public class BoolVariableTemplate : VariableTemplate<bool?, Variable<bool?>>
    {
        public BoolVariableTemplate(string name) : base(name)
        {
        }

        public override bool? GetValueFromWorldState(IWorldState worldState)
        {
            return worldState.GetBool(Name);
        }

        public override Variable<bool?> ValueToVariable(bool? value)
        {
            return new Variable<bool?>(Name, value);
        }
    }
}
