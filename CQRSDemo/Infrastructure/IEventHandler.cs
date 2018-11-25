namespace CQRSDemo
{
    public interface IEventHandler<TEvent>
    {
        void Handle(TEvent @event);
    }
}