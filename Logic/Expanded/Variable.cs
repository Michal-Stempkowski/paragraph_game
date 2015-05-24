using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Expanded
{
    public class Variable<TValue> : ILogic
    {
        public Variable(string name, TValue v)
        {
            Name = name;
            Value = v;
        }

        public string Name { get; private set; }
        public TValue Value { get; private set; }
    }
}
