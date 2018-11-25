namespace CQRSDemo.Commands
{
    internal class UserDeleted
    {
        public string Login { get;}

        public UserDeleted(string login)
        {
            Login = login;
        }
    }
}