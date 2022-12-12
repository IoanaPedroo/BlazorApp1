namespace BlazorApp1.Server.ServerServices
{
    public interface IStatService
    {
        Task<int> GetVisits();
        Task IncrementVisits();

    }
}
