namespace CQRSDemo
{
    public class UserCreated
    {
        public string Name { get; }

        public UserCreated(string name)
        {
            Name = name;
        }
    }
}
