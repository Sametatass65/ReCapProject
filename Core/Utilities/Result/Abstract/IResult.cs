using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Abstract
{
    public interface IResult
    {
        string message { get; }
        bool Success { get; }
    }
}
