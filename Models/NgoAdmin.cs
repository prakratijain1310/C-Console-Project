using System;
using CommunityConnect.Models;

namespace CommunityConnect.Models
{
    public class NgoAdmin : User
{
    public NgoAdmin(
        int id,
        string name,
        string email)
        : base(id,name,email)
    {
    }

    public override void Login()
    {
        Console.WriteLine(
            "NGO Admin logged in");
    }
}
}