using System;

namespace CommunityConnect.Services
{
    public class SmsService
    {
        public void SendSms(
            string volunteerName)
        {
            Console.WriteLine(
                $"[SMS] Welcome {volunteerName}");
        }
    }
}