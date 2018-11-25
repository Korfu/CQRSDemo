using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Infrastructure
{
    public interface IQueryHandler<TQuery>
    {
        TQuery Handle(TQuery query);
    }
}
