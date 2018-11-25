using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}
