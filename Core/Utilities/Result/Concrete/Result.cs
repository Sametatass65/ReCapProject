using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class Result : IResult
    {
        public Result(string message, bool success):this(success)
        {
            this.message = message;
            
        }
        public Result(bool success)
        {
            this.Success = success;
        }

        public string message { get; }

        public bool Success { get; }
    }
}
