using API.Data;
using API.Dtos;
using API.Helpers;

namespace API.Services
{
    public interface IAtaglancesService
    {
        public IEnumerable<ProjectProjectMonthlyMaintenanceDto> QueryMantenaces();
        public Task<long> TotalForecast2020();
        public Task<long> TotalConfirm2020();
        public Task<long> TotalForecast2021();
        public Task<long> TotalConfirm2021();
        public Task<long> TotalForecast2022();
        public Task<long> TotalConfirm2022();
        public Task<long> TotalForecast2023();
        public Task<long> TotalConfirm2023();
    }
    public class AtaglancesService : IAtaglancesService
    {
        private readonly AppDbContext _context;
        public AtaglancesService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ProjectProjectMonthlyMaintenanceDto> QueryMantenaces()
        {
          return from p in _context.Projects
                        join m in _context.ProjectMonthlyMaintenances
                      on p.Id equals m.FkProjectId into ps
                 from a in ps.DefaultIfEmpty()
                 select new ProjectProjectMonthlyMaintenanceDto { project=p,projectMonthlyMaintenance= a };
        }

        public async Task<long> TotalConfirm2020()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2020")).Sum(s =>
            {
                return Helper.CheckObjNull(s.projectMonthlyMaintenance) == true ? s.projectMonthlyMaintenance.Amount : 0;
            });
        }
        public async Task<long> TotalConfirm2021()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2021")).Sum(s =>
            {
                return Helper.CheckObjNull(s.projectMonthlyMaintenance) == true ? s.projectMonthlyMaintenance.Amount : 0;
            });
        }
        public async Task<long> TotalConfirm2022()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2022")).Sum(s =>
            {
                return Helper.CheckObjNull(s.projectMonthlyMaintenance) == true ? s.projectMonthlyMaintenance.Amount : 0;
            });
        }
        public async Task<long> TotalConfirm2023()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2023")).Sum(s =>
            {
                return Helper.CheckObjNull(s.projectMonthlyMaintenance) == true ? s.projectMonthlyMaintenance.Amount : 0;
            });
        }
        public async Task<long> TotalForecast2020()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2020")).Sum(s =>
            {
                return long.Parse(Helper.IsDigitsOnly(s.project.ForecastAmount) == true ? s.project.ForecastAmount : "0");
            });
        }
        public async Task<long> TotalForecast2021()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2021")).Sum(s =>
            {
                return long.Parse(Helper.IsDigitsOnly(s.project.ForecastAmount) == true ? s.project.ForecastAmount : "0");
            });
        }
        public async Task<long> TotalForecast2022()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2022")).Sum(s =>
            {
               return long.Parse(Helper.IsDigitsOnly(s.project.ForecastAmount) == true ? s.project.ForecastAmount : "0");
            });
        }
        public async Task<long> TotalForecast2023()
        {
            return QueryMantenaces().Where(s => s.project.MaintExpire.ToString().Contains("2023")).Sum(s =>
            {
                return long.Parse(Helper.IsDigitsOnly(s.project.ForecastAmount) == true ? s.project.ForecastAmount : "0");
            });
        }
    }
}
