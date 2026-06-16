using CommunityConnect.Models;
using CommunityConnect.Interfaces;
using CommunityConnect.Repository;
using CommunityConnect.Services;
using System;

// =========================
// OOP Demonstration
// =========================

User volunteer =
    new Volunteer(
        1,
        "Prakrati",
        "p@gmail.com");

User admin =
    new NgoAdmin(
        2,
        "John",
        "j@gmail.com");

volunteer.Login();
admin.Login();

Console.WriteLine();

// =========================
// Interface Demonstration
// =========================

INotificationService notification =
    new EmailNotificationService();

notification.Send(
    "Welcome to CommunityConnect!");

Console.WriteLine();

// =========================
// Repository Demonstration
// =========================

VolunteerRepository repository =
    new VolunteerRepository();

repository.Add(
    new Volunteer(
        1,
        "Prakrati",
        "prakrati@gmail.com"));

repository.Add(
    new Volunteer(
        2,
        "Aman",
        "aman@gmail.com"));

Console.WriteLine("Volunteers Added Successfully");
Console.WriteLine();

// =========================
// Event & Delegate Demo
// =========================

EventService eventService =
    new EventService(repository);

EmailService emailService =
    new EmailService();

SmsService smsService =
    new SmsService();

LoggingService loggingService =
    new LoggingService();

// Subscribe

eventService.VolunteerRegistered +=
    emailService.SendWelcomeEmail;

eventService.VolunteerRegistered +=
    smsService.SendSms;

eventService.VolunteerRegistered +=
    loggingService.LogRegistration;

// Trigger Event

eventService.RegisterVolunteer(
    "Prakrati");

Console.WriteLine();

// Unsubscribe SMS

eventService.VolunteerRegistered -=
    smsService.SendSms;

Console.WriteLine(
    "SMS Service Unsubscribed");

Console.WriteLine();

// Trigger Again

eventService.RegisterVolunteer(
    "Aman");