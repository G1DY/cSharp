using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.SRP
{
    public class UserRegistration
    {
        public void registerUser(User user)
        {
            EmailSender emailSender= new EmailSender();
            emailSender.sendingEmail(user.Email, "welcome to the app");
        }
    }
}