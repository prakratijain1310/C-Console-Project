using System;

namespace CommunityConnect.Services
{
    public abstract class NotificationService
    {
        protected void Log()
        {
            Console.WriteLine("Logging...");
        }
        public abstract void Send(string message);
    }
}