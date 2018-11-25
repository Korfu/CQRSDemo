namespace CQRSDemo.Events
{
    public class UserEdited
    {
        public string Login;

        public UserEdited(string login)
        {
            this.Login = login;
        }
    }
}
