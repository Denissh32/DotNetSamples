using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Interfaces
{
    public interface IWebLoader
    {
        Task<string> LoadDataToString(string source, string apiKey = null);
    }
}
