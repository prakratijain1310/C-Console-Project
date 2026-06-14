using CommunityConnect.Models;
using CommunityConnect.Interfaces;
using CommunityConnect.Repositories;

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


INotificationService notification =
    new EmailNotificationService();

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
        "aman@gmail.com"));VolunteerRepository _ =
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