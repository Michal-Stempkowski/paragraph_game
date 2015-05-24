using Logic;
using NSubstitute;

namespace tests
{
    public class VariableTestsBase
    {
        protected readonly IWorldState WorldStateMock;
        protected const string VariableName = "a";

        protected VariableTestsBase()
        {
            WorldStateMock = Substitute.For<IWorldState>();
        }
    }
}