using System;

namespace CommunityConnect.Services
{
    public class LoggingService
    {
        public void LogRegistration(
            string volunteerName)
        {
            Console.WriteLine(
                $"[LOG] {volunteerName} registered");
        }
    }
}