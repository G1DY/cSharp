using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Coupling.loosely
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // Email logic
            System.Console.WriteLine("Sending email" + message);
        }
    }
}