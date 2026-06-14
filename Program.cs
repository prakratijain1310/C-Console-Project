using CommunityConnect.Models;
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