using Logic.Expanded;

namespace Logic.Templates
{
    interface ILogicTemplate
    {
        ILogic ExpandLogic(IWorldState worldState);
    }
}
