using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class DataSuccessResult<T>:DataResult<T>
    {
        public DataSuccessResult(T data, string message):base(data,message,true)
        {

        }
        public DataSuccessResult(T data):base(data,true)
        {

        }
        public DataSuccessResult(string message):base(default,message,true)
        {

        }
        public DataSuccessResult():base(default,true)
        {

        }
    }
}
