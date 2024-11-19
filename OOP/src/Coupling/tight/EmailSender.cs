using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Coupling.tight
{
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            // Email logic
            System.Console.WriteLine("Sending email" + message);
        }
    }
}