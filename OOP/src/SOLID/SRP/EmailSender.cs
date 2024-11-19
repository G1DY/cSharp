using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.SRP
{
    public class EmailSender
    {
        public void sendingEmail(string message, string email)
        {
            System.Console.WriteLine($"sending email to {email} : {message}");
        }   
    }
}