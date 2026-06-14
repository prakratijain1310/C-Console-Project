using System;

namespace CommunityConnect.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public User(
            int id,
            string name,
            string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Name cannot be empty");
            if(!email.Contains("@"))
            {
                throw new ArgumentException(
                    "Invalid email");
            }

            Id = id;
            Name = name;
            Email = email;
        }

        public virtual void Login()
        {
            Console.WriteLine(
                "User logged in");
        }
    }
}