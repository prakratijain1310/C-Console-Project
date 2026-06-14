using System;
using CommunityConnect.Interfaces;

public class EmailNotificationService
    : INotificationService
{
    public void Send(string message)
    {
        try
        {
            Console.WriteLine(
                $"Email Sent: {message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(
                ex.Message);
        }
    }
}