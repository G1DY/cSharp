using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Coupling.tight
{
    public class Order
    {
        public void PlaceOrder()
        {
            // logic to place an order i.e price, goods order etc
            EmailSender emailSender= new EmailSender();
            emailSender.SendEmail("order placed successfully");
        }

    }
}