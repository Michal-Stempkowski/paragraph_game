using System.Diagnostics;
using Logic;
using Logic.Expanded;
using Logic.Templates;

namespace tests
{
    public class IntVariableTemplate : VariableTemplate<int?, Variable<int?>>
    {
        public IntVariableTemplate(string name) : base(name)
        {
        }

        public override int? GetValueFromWorldState(IWorldState worldState)
        {
            return worldState.GetInt(Name);
        }

        public override Variable<int?> ValueToVariable(int? value)
        {
            Debug.Assert(value != null, "value != null");
            return new Variable<int?>(Name, value.Value);
        }
    }
}