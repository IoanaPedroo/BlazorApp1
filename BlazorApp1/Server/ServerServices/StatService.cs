using BlazorApp1.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.ServerServices
{
    public class StatService : IStatService
    {
        private readonly DataContext _dataContext;
        public StatService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<int> GetVisits()
        {
            var stats = await _dataContext.Stats.FirstOrDefaultAsync();
            if(stats == null)
            {
                return 0;
            }
            return stats.Visitis;
        }

        public async Task IncrementVisits()
        {
            var stats = await _dataContext.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                _dataContext.Stats.Add(new Shared.Stat { Visitis = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visitis++;
                stats.LastVisit = DateTime.Now;
            }
            await _dataContext.SaveChangesAsync();
        }
    }
}
