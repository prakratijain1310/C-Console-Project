using CommunityConnect.Models;

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
}