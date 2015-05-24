using System;

namespace Logic
{
    public class VariableDoesNotExistException : SystemException
    {
        public VariableDoesNotExistException(string variableName) :
            base(String.Format(ErrorMessageString, variableName))
        {
            VariableName = variableName;
        }

        public readonly string VariableName;

        private const string ErrorMessageString = "StringVariable '{0}'doeas not exist";
    }
}
