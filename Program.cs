using CommunityConnect.Models;
using CommunityConnect.Services;

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

NotificationService service1 =
    new EmailNotificationService();

NotificationService service2 =
    new SmsNotificationService();

service1.Send("Welcome");
service2.Send("Welcome");