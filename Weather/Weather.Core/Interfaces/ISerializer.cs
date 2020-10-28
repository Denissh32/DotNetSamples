using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Interfaces
{
    public interface ISerializer<T>
    {
        string ToJsonString(T input);

        T FromJsonString(string input);
    }
}
