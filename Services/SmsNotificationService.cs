using System;

namespace CommunityConnect.Services
{
    public class SmsNotificationService
        : NotificationService
    {
        public override void Send(string message)
        {
            Console.WriteLine(
                $"SMS Sent: {message}");
        }
    }
}