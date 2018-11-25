using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Infrastructure
{
    public interface IQueryData<T>
    {
      T Data { get; }
    }
}
