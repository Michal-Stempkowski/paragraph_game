using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IWorldState
    {
        string GetString(string name);
        int? GetInt(string name);
        bool? GetBool(string name);
        float? GetFloat(string variableName);
    }
}
