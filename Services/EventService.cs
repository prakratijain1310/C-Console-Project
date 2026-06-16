using System;
using CommunityConnect.Models;
using CommunityConnect.Repository;

public class EventService
{
    private readonly
        IRepoService<Volunteer>
        _repository;

    public EventService(
        IRepoService<Volunteer>
        repository)
    {
        _repository =
            repository;
    }

    public EventService(VolunteerRepository repository)
    {
    }

    public event Action<string>
        VolunteerRegistered;
    public void RegisterVolunteer(
            string volunteerName)
    {
            Console.WriteLine(
                $"{volunteerName} successfully registered.");

            VolunteerRegistered?.Invoke(
                volunteerName);
}
}