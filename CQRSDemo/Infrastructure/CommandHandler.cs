using Ninject;

namespace CQRSDemo
{
    public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand>
    {
        [Inject]
        public IButler Please { get; set; }
        public abstract void Handle(TCommand command);
    }
}
