using Logic;
using Logic.Expanded;
using Logic.Templates;
using NSubstitute;
using NUnit.Framework;

namespace tests
{
    /// <summary>
    /// Summary description for Logic
    /// </summary>
    [TestFixture]
    public class VariableTests : VariableTestsBase
    {
        private readonly StringVariableTemplate _variable;

        public VariableTests()
        {
            _variable = new StringVariableTemplate(VariableName);
        }

        [Test] 
        public void should_be_able_to_create_variable()
        {
            Assert.That(_variable.Name, Is.EqualTo(VariableName));
        }

        [Test]
        public void on_not_existing_variable_expansion_should_throw_an_exception()
        {
            WorldStateMock.GetString(VariableName).Returns(null as string);

            Assert.Throws<VariableDoesNotExistException>(
                () => _variable.ExpandLogic(WorldStateMock));
        }

        [Test]
        public void on_existing_variable_expansion_should_know_its_value()
        {
            const string variableValue = "value";

            WorldStateMock.GetString(VariableName).Returns(variableValue);

            var variable = new StringVariableTemplate(VariableName);
            TestExpandingVariableTemplate(variable, variableValue);
        }

        private void TestExpandingVariableTemplate<TVariableTemplate, TVariableValue>(TVariableTemplate variable, TVariableValue variableValue)
            where TVariableTemplate : VariableTemplate<TVariableValue, Variable<TVariableValue>>
        {
            var expanded = variable.ExpandLogic(WorldStateMock) as Variable<TVariableValue>;
            Assert.That(expanded, Is.Not.Null);
            // ReSharper disable once PossibleNullReferenceException
            Assert.That(expanded.Name, Is.EqualTo(VariableName));
            Assert.That(expanded.Value, Is.EqualTo(variableValue));
        }

        [Test]
        public void int_variable_should_also_work()
        {
            int? variableValue = 5;

            WorldStateMock.GetInt(VariableName).Returns(variableValue);

            var variable = new IntVariableTemplate(VariableName);
            TestExpandingVariableTemplate(variable, variableValue);
        }
    }
}
