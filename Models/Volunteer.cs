using System;

namespace CommunityConnect.Models
{
    public class Volunteer : User
    {
        private int hoursContributed;

        public Volunteer(
            int id,
            string name,
            string email)
            : base(id, name, email)
        {
        }

        public int HoursContributed
        {
            get { return hoursContributed; }
            set
            {
                if (value >= 0)
                    hoursContributed = value;
            }
        }

        public override void Login()
        {
            Console.WriteLine(
                "Volunteer logged in");
        }
    }
}