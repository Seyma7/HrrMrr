using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.BusinessResult
{
    public class DataResult<T> where T: class
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Message { get; set; }

        public DataResult()
        {
            IsSuccess = false;
            Message = new List<string>();
        }
    }
}
