using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Infrastructure
{
    public class QueryData<T> : IQueryData<T>
    {
        public T Data { get; set; }
    }
}
