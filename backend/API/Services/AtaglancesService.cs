using API.Data;
using API.Dtos;
using API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IAtaglancesService
    {
        public Task<Dictionary<string, double>> domainProviderCostList();
        public Task<Dictionary<string, double>> hostingProviderCostList();
        public Task<Dictionary<string, double>> emailProviderCostList();
        public double totalMaintCostPerMonth();
        public double totalDomainCostPerMonth();
        public double totalHostCostPerMonth();
        public double totalEmailCostPerMonth();
        public Task<int> CountProjectList();
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
        private readonly IProjectService _projectService;
        public AtaglancesService(AppDbContext context, IProjectService projectService)
        {
            _context = context;
            _projectService = projectService;
        }
        public async Task<int> CountProjectList()
        {
            return await _context.Projects.Where(x => x.Phase == 3 || x.Phase == 4).CountAsync();
        }
        public async Task<Dictionary<string, double>> domainProviderCostList()
        {
            throw new NotImplementedException();
            //var projectList = await _projectService.GetAll();
            //foreach(var project in projectList)
            //{
            //    if (project.MaintCost != "0/Month" && string.IsNullOrEmpty(project.MaintCost))
            //    {
            //        string frequency = project.MaintCost.Split('/')[1];
            //        double maintCost = double.Parse(project.MaintCost.Split('/')[0]);
            //        switch (frequency)
            //        {
            //            case "Quarter":
            //                maintCost /= 3;
            //                break;
            //            case "Bi-annual":
            //                maintCost /= 6;
            //                break;
            //            case "Annual":
            //                maintCost /= 12;
            //                break;
            //        }

            //    }
            //}
        }
        public async Task<Dictionary<string, double>> emailProviderCostList()
        {
            throw new NotImplementedException();
        }
        public async Task<Dictionary<string, double>> hostingProviderCostList()
        {
            throw new NotImplementedException();
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

        public Task<double> totalDomainCostPerMonth()
        {
            throw new NotImplementedException();
        }

        public Task<double> totalEmailCostPerMonth()
        {
            throw new NotImplementedException();
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

        public Task<double> totalHostCostPerMonth()
        {
            throw new NotImplementedException();
        }

        public double totalMaintCostPerMonth(double value)
        {
            return value;
        }

        public double totalMaintCostPerMonth()
        {
            throw new NotImplementedException();
        }

        double IAtaglancesService.totalDomainCostPerMonth()
        {
            throw new NotImplementedException();
        }

        double IAtaglancesService.totalEmailCostPerMonth()
        {
            throw new NotImplementedException();
        }

        double IAtaglancesService.totalHostCostPerMonth()
        {
            throw new NotImplementedException();
        }
    }
}
