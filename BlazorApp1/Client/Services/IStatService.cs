namespace BlazorApp1.Client.Services
{
    public interface IStatService
    {
        Task GetVisits();
        Task IncrementVisists();
    }
}
