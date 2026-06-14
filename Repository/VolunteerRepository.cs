using System.Collections.Generic;
using CommunityConnect.Models;

namespace CommunityConnect.Repositories
{
    public class VolunteerRepository
    {
        private readonly List<Volunteer> _volunteers =
            new();

        public void Add(Volunteer volunteer)
        {
            _volunteers.Add(volunteer);
        }

        public List<Volunteer> GetAll()
        {
            return _volunteers;
        }
    }
}