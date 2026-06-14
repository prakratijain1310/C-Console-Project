using System;
using CommunityConnect.Interfaces;

public class EmailNotificationService
    : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine(
            $"Email Sent: {message}");
    }
}