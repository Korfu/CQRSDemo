using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo
{
    public class AddUser
    {
        public string Login { get; }
        public string Name { get; }

        public AddUser(string login, string name)
        {
            Login = login;
            Name = name;
        }
    }

    public class AddUSerHandler : CommandHandler<AddUser>
    {
        public override void Handle(AddUser command)
        {
            var user = new User
            {
                Name = command.Name,
                Login = command.Login
            };

            Console.WriteLine($"Stworzylem uzytkownika {user.Name}, {user.Login}!");

            //save to db

            Please.Tell(new UserCreated(user.Name));
        }
    }

}
