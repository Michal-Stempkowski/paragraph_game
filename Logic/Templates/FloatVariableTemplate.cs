using Logic;
using Logic.Expanded;
using Logic.Templates;

namespace tests
{
    public class FloatVariableTemplate : VariableTemplate<float?, Variable<float?>>
    {
        public FloatVariableTemplate(string variableName) : base(variableName)
        {
            
        }

        public override float? GetValueFromWorldState(IWorldState worldState)
        {
            return worldState.GetFloat(Name);
        }

        public override Variable<float?> ValueToVariable(float? value)
        {
            return new Variable<float?>(Name, value);
        }
    }
}