using System;
using CommunityConnect.Interfaces;

namespace CommunityConnect.Services
{
    public class EventService
    {
        private readonly INotificationService _notificationService;

        public EventService(
            INotificationService notificationService)
        {
            _notificationService =
                notificationService
                ?? throw new ArgumentNullException(
                    nameof(notificationService));
        }

        public void RegisterVolunteer(
            string volunteerName)
        {
            Console.WriteLine(
                $"{volunteerName} registered.");

            _notificationService.Send(
                "Registration Successful");
        }
    }
}