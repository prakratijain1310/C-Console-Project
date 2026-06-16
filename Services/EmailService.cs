using System;

namespace CommunityConnect.Services
{
    public class EmailService
    {
        public void SendWelcomeEmail(
            string volunteerName)
        {
            Console.WriteLine(
                $"[EMAIL] Welcome {volunteerName}");
        }
    }
}