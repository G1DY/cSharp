using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Coupling.loosely
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}