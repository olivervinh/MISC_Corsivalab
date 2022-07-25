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
                var domains = await _projectDomainService.GetAll();
                if (domains.Count() > 0)
                {
                    foreach (var domain in domains)
                    {
                        foreach (var provider in domainProviderList)
                        {
                            if (domain.Provider == provider.Id)
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
                                dto.Key = provider.Name;
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

        public async Task<TotalAndEmailRevenueBreakdownDto> TotalAndEmailRevenueBreakdownList()
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

            //
            var emailList = await _context.EmailSystems.ToListAsync();

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
                var emailSysProjectList = await _context.ProjectEmailSystems.ToListAsync();
                if (tempList.Count > 0)
                {
                    foreach (var email in emailSysProjectList)
                    {
                        foreach (var provider in emailList)
                        {
                            if (email.Provider == provider.Id)
                            {
                                string frequency = email.Cost.Split('/')[1];
                                double emailCost = double.Parse(email.Cost.Split('/')[0]);

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
                                dto.Key = provider.EmailSystemName;
                                dto.Value = emailCost;
                                tempList.Add(dto);
                            }
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

        public async Task<TotalAndHostingRevenueBreakdownDto> TotalAndHostingRevenueBreakdownList()
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

            //
            var emailList = await _context.EmailSystems.ToListAsync();

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
                var emailSysProjectList = await _context.ProjectEmailSystems.ToListAsync();
                if (tempList.Count > 0)
                {
                    foreach (var email in emailSysProjectList)
                    {
                        foreach (var provider in emailList)
                        {
                            if (email.Provider == provider.Id)
                            {
                                string frequency = email.Cost.Split('/')[1];
                                double emailCost = double.Parse(email.Cost.Split('/')[0]);

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
                                dto.Key = provider.EmailSystemName;
                                dto.Value = emailCost;
                                tempList.Add(dto);
                            }
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
    }
}
