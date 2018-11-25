using CQRSDemo.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Commands
{
    public class EditUser
    {
        public string Login { get; }

        public EditUser(string login)
        {
            Login = login;
        }
    }

    public class EditUserHandler : CommandHandler<EditUser>
    {
        public override void Handle(EditUser command)
        {
            var userToEdit = new User
            {
                Login = command.Login
            };

            Console.WriteLine(" ");
            Console.WriteLine($"Edytuję użykownika o loginie {userToEdit.Login}");

            Please.Tell(new UserEdited(userToEdit.Login));
        }
    }
}
