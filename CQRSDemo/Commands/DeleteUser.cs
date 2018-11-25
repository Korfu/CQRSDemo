using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Commands
{
    public class DeleteUser
    {
        public string Login { get; }

        public DeleteUser(string login)
        {
            Login = login;
        }
    }

    public class DeleteUserHandler : CommandHandler<DeleteUser>
    {
        public override void Handle(DeleteUser command)
        {
            var userToDelete = new User
            {
                Login = command.Login
            };
            Console.WriteLine(" ");
            Console.WriteLine($"Usuwam użykownika o loginie {userToDelete.Login}");
            

            //delete from db

            Please.Tell(new UserDeleted(userToDelete.Login));
        }
    }
}
