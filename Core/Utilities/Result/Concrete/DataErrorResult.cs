using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class DataErrorResult<T>:DataResult<T>
    {
        public DataErrorResult(T data, string message):base(data,message,false)
        {

        }
        public DataErrorResult(T data):base(data,false)
        {

        }
        public DataErrorResult(string message):base(default,message,false)
        {

        }
        public DataErrorResult():base(default,false)
        {

        }
    }
}
