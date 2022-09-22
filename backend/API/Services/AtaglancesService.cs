using API.Data;
using API.Dtos;
using API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IAtaglancesService
    {
        //1
        public Task<int> CountProjectList();
        //1

        //2
        public Task<TotalAndDomainRevenueBreakdownDto> TotalAndDomainRevenueBreakdownList();
        public Task<TotalAndHostingRevenueBreakdownDto> TotalAndHostingRevenueBreakdownList();
        public Task<TotalAndEmailRevenueBreakdownDto> TotalAndEmailRevenueBreakdownList();
        //2

        //3
        public Task<long> TotalConfirm2020();
        public Task<long> TotalConfirm2021();
        public Task<long> TotalConfirm2022();
        public Task<long> TotalConfirm2023();

        public Task<long> TotalForecast2020();
        public Task<long> TotalForecast2021();
        public Task<long> TotalForecast2022();
        public Task<long> TotalForecast2023();
        //3
    }
    public class AtaglancesService : IAtaglancesService
    {
        private readonly AppDbContext _context;
        private readonly IProjectService _projectService;
        private readonly IProjectDomainService _projectDomainService;
        private readonly IProjectHostingService _projectHostingService;
        private readonly IProjectEmailSystemService _projectEmailSystemService;
        public AtaglancesService(
            AppDbContext context,
            IProjectService projectService,
            IProjectDomainService projectDomainService,
            IProjectHostingService projectHostingService,
            IProjectEmailSystemService projectEmailSystemService
            )
        {
            _context = context;
            _projectService = projectService;
            _projectDomainService = projectDomainService;
            _projectHostingService = projectHostingService;
            _projectEmailSystemService = projectEmailSystemService;
        }
        public async Task<int> CountProjectList()
        {
            return await _context.Projects.Where(x => x.Phase == 3 || x.Phase == 4).CountAsync();
        }
        public async Task<TotalAndDomainRevenueBreakdownDto> TotalAndDomainRevenueBreakdownList()
        {
            try
            {
                //set list temp
                var tempList = new List<BreakdownDto>();

                //new model
                TotalAndDomainRevenueBreakdownDto model = new TotalAndDomainRevenueBreakdownDto();

                //init Dicre
                model.domainRevenueBreakdownIColection = new List<BreakdownDto>();

                //get all doamin provider list 
                var domainProviderList = await _context.DomainProviders.ToListAsync();

                //get all project
                var projects = await _projectService.GetAll();

                var domains = await _projectDomainService.GetAll();

                foreach (var project in projects)
                {
                    //Maintenance Cost
                    if (project.MaintCost != "0/Month" && !string.IsNullOrEmpty(project.MaintCost))
                    {
                        string frequency = project.MaintCost.Split('/')[1];
                        double mainCost = double.Parse(project.MaintCost.Split('/')[0]);
                        switch (frequency)
                        {
                            case "Quarter":
                                mainCost /= 3;
                                break;
                            case "Bi-annual":
                                mainCost /= 6;
                                break;
                            case "Annual":
                                mainCost /= 12;
                                break;
                        }
                    }
                    if (domains.Count() > 0)
                    {
                        foreach (var domain in domains)
                        {
                            foreach (var domainProvider in domainProviderList)
                            {
                                if (domain.Provider == domainProvider.Id)
                                {
                                    string frequency = domain.Cost.Split('/')[1];
                                    double domainCost = double.Parse(domain.Cost.Split('/')[0]);

                                    switch (frequency)
                                    {
                                        case "Quarter":
                                            domainCost /= 3;
                                            break;
                                        case "Bi-annual":
                                            domainCost /= 6;
                                            break;
                                        case "Annual":
                                            domainCost /= 12;
                                            break;
                                    }
                                    model.Total += domainCost;
                                    var dto = new BreakdownDto();
                                    dto.Key = domainProvider.Name;
                                    dto.Value = domainCost;
                                    tempList.Add(dto);
                                }
                            }

                        }
                    }
                }
                model.domainRevenueBreakdownIColection = tempList
                                        .GroupBy(x => x.Key)
                                        .Select(x => new BreakdownDto()
                                        {
                                            Key = x.FirstOrDefault().Key,
                                            Value = x.Sum(s => s.Value),
                                        })
                                        .ToList();
                return model;
            }
            catch(Exception ex)
            {
                TotalAndDomainRevenueBreakdownDto model = new TotalAndDomainRevenueBreakdownDto();
                var list = new List<BreakdownDto>();
                var item = new BreakdownDto();
                item.Value = 0.0;
                item.Key = "";
                list.Add(item);
                model.domainRevenueBreakdownIColection = list;
                return model;
            }
        }
        public async Task<TotalAndEmailRevenueBreakdownDto> TotalAndEmailRevenueBreakdownList()
        {
            try
            {
                //set list temp
                var tempList = new List<BreakdownDto>();

                //new model
                TotalAndEmailRevenueBreakdownDto model = new TotalAndEmailRevenueBreakdownDto();

                //init Dicre
                model.emailRevenueBreakdownIColection = new List<BreakdownDto>();

                //get all email provider list 
                var projectEmailSystems = await _context.ProjectEmailSystems.ToListAsync();

                //get all project
                var projects = await _projectService.GetAll();

                //get email list
                var emailSystemsList = await _context.EmailSystems.ToListAsync();

                //get email system list
                var emailSysProjectList = await _context.ProjectEmailSystems.ToListAsync();
                foreach (var project in projects)
                {
                    //Maintenance Cost
                    if (project.MaintCost != "0/Month" && !string.IsNullOrEmpty(project.MaintCost))
                    {
                        string frequency = project.MaintCost.Split('/')[1];
                        double mainCost = double.Parse(project.MaintCost.Split('/')[0]);
                        switch (frequency)
                        {
                            case "Quarter":
                                mainCost /= 3;
                                break;
                            case "Bi-annual":
                                mainCost /= 6;
                                break;
                            case "Annual":
                                mainCost /= 12;
                                break;
                        }
                    }
                    foreach (var emailSysProject in emailSysProjectList)
                    {
                        foreach (var emailSys in emailSystemsList)
                        {
                            if (emailSysProject.Provider == emailSys.Id)
                            {
                                string frequency = emailSysProject.Cost.Split('/')[1];
                                double emailCost = double.Parse(emailSysProject.Cost.Split('/')[0]);

                                switch (frequency)
                                {
                                    case "Quarter":
                                        emailCost /= 3;
                                        break;
                                    case "Bi-annual":
                                        emailCost /= 6;
                                        break;
                                    case "Annual":
                                        emailCost /= 12;
                                        break;
                                }
                                model.Total += emailCost;
                                var dto = new BreakdownDto();
                                dto.Key = emailSys.EmailSystemName;
                                dto.Value = emailCost;
                                tempList.Add(dto);
                            }
                        }
                    }
                }
                model.emailRevenueBreakdownIColection = tempList
                                        .GroupBy(x => x.Key)
                                        .Select(x => new BreakdownDto()
                                        {
                                            Key = x.FirstOrDefault().Key,
                                            Value = x.Sum(s => s.Value),
                                        })
                                        .ToList();
                return model;
            }
            catch(Exception ex)
            {
                TotalAndEmailRevenueBreakdownDto model = new TotalAndEmailRevenueBreakdownDto();
                var list = new List<BreakdownDto>();
                var item = new BreakdownDto();
                item.Value = 0.0;
                item.Key = "";
                list.Add(item);
                model.emailRevenueBreakdownIColection = list;
                return model;
            }
           
        }
        public async Task<TotalAndHostingRevenueBreakdownDto> TotalAndHostingRevenueBreakdownList()
        {
            try
            {
                //set list temp
                var tempList = new List<BreakdownDto>();

                //new model
                TotalAndHostingRevenueBreakdownDto model = new TotalAndHostingRevenueBreakdownDto();

                //init Dicre
                model.hostingRevenueBreakdownIColection = new List<BreakdownDto>();


                //get all project
                var projects = await _projectService.GetAll();

                //get all
                var hostingList = await _context.ProjectHostings.ToListAsync();

                //get all doamin provider list 
                var hostingProviderList = await _context.HostingProviders.ToListAsync();

                foreach (var project in projects)
                {
                    //Maintenance Cost
                    if (project.MaintCost != "0/Month" && !string.IsNullOrEmpty(project.MaintCost))
                    {
                        string frequency = project.MaintCost.Split('/')[1];
                        double mainCost = double.Parse(project.MaintCost.Split('/')[0]);
                        switch (frequency)
                        {
                            case "Quarter":
                                mainCost /= 3;
                                break;
                            case "Bi-annual":
                                mainCost /= 6;
                                break;
                            case "Annual":
                                mainCost /= 12;
                                break;
                        }
                    }

                    foreach (var hosting in hostingList)
                    {
                        foreach (var provider in hostingProviderList)
                        {
                            if (hosting.Provider == provider.Id)
                            {
                                string frequency = hosting.Cost.Split('/')[1];
                                double hotingCost = double.Parse(hosting.Cost.Split('/')[0]);

                                switch (frequency)
                                {
                                    case "Quarter":
                                        hotingCost /= 3;
                                        break;
                                    case "Bi-annual":
                                        hotingCost /= 6;
                                        break;
                                    case "Annual":
                                        hotingCost /= 12;
                                        break;
                                }
                                model.Total += hotingCost;
                                var dto = new BreakdownDto();
                                dto.Key = provider.Name;
                                dto.Value = hotingCost;
                                tempList.Add(dto);
                            }
                        }
                    }
                }
                model.hostingRevenueBreakdownIColection = tempList
                                        .GroupBy(x => x.Key)
                                        .Select(x => new BreakdownDto()
                                        {
                                            Key = x.FirstOrDefault().Key,
                                            Value = x.Sum(s => s.Value),
                                        })
                                        .ToList();
                return model;
            }
            catch(Exception ex)
            {
                TotalAndHostingRevenueBreakdownDto model = new TotalAndHostingRevenueBreakdownDto();
                var list = new List<BreakdownDto>();
                var item = new BreakdownDto();
                item.Value = 0.0;
                item.Key = "";
                list.Add(item);
                model.hostingRevenueBreakdownIColection = list;
                return model;
            }
          
        }
        public async Task<long> TotalConfirm2020()
        {
            try
            {
                var projectMonthlyMantenacesList = _context.ProjectMonthlyMaintenances;
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                var queryMantenaces = from m in projectList
                                      join p in projectMonthlyMantenacesList
                                    on m.Id equals p.FkProjectId into ps
                                      from a in ps.DefaultIfEmpty()
                                      select new { m, a };
                return queryMantenaces.Where(s => s.m.MaintExpire.ToString().Contains("2020")).ToList().Sum(s => {

                    return Helper.CheckObjNull(s.a) == true ? s.a.Amount : 0;
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
          
        }
        public async Task<long> TotalConfirm2021()
        {
            try
            {
                var projectMonthlyMantenacesList = _context.ProjectMonthlyMaintenances;
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                var queryMantenaces = from m in projectList
                                      join p in projectMonthlyMantenacesList
                                    on m.Id equals p.FkProjectId into ps
                                      from a in ps.DefaultIfEmpty()
                                      select new { m, a };
                return queryMantenaces.Where(s => s.m.MaintExpire.ToString().Contains("2021")).ToList().Sum(s => {
                    return Helper.CheckObjNull(s.a) == true ? s.a.Amount : 0;
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<long> TotalConfirm2022()
        {
            try
            {
                var projectMonthlyMantenacesList = _context.ProjectMonthlyMaintenances;
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                var queryMantenaces = from m in projectList
                                      join p in projectMonthlyMantenacesList
                                    on m.Id equals p.FkProjectId into ps
                                      from a in ps.DefaultIfEmpty()
                                      select new { m, a };
                return queryMantenaces.Where(s => s.m.MaintExpire.ToString().Contains("2022")).ToList().Sum(s => {
                    return Helper.CheckObjNull(s.a) == true ? s.a.Amount : 0;
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<long> TotalConfirm2023()
        {
            try
            {
                var projectMonthlyMantenacesList = _context.ProjectMonthlyMaintenances;
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                var queryMantenaces = from m in projectList
                                      join p in projectMonthlyMantenacesList
                                    on m.Id equals p.FkProjectId into ps
                                      from a in ps.DefaultIfEmpty()
                                      select new { m, a };
                return queryMantenaces.Where(s => s.m.MaintExpire.ToString().Contains("2023")).ToList().Sum(s => {
                    return Helper.CheckObjNull(s.a) == true ? s.a.Amount : 0;
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<long> TotalForecast2020()
        {
            try
            {
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                return projectList.Where(s => s.MaintExpire.ToString().Contains("2020")).ToList().Sum(s =>
                {
                    return long.Parse(Helper.IsDigitsOnly(s.ForecastAmount) == true ? s.ForecastAmount : "0");
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<long> TotalForecast2021()
        {
            try
            {
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                return projectList.Where(s => s.MaintExpire.ToString().Contains("2021")).ToList().Sum(s => {
                    return long.Parse(Helper.IsDigitsOnly(s.ForecastAmount) == true ? s.ForecastAmount : "0");
                });
            }
            catch(Exception ex)
            {
                return 0;
            }
           
        }
        public async Task<long> TotalForecast2022()
        {
            try
            {
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                return projectList.Where(s => s.MaintExpire.ToString().Contains("2022")).ToList().Sum(s => {
                    return long.Parse(Helper.IsDigitsOnly(s.ForecastAmount) == true ? s.ForecastAmount : "0");
                });
            }
           catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<long> TotalForecast2023()
        {
            try
            {
                var projectList = _context.Projects.Where(c => c.Phase == 3 || c.Phase == 4);
                return projectList.Where(s => s.MaintExpire.ToString().Contains("2023")).ToList().Sum(s =>
                {
                    return long.Parse(Helper.IsDigitsOnly(s.ForecastAmount) == true ? s.ForecastAmount : "0");
                });
            }
          catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
