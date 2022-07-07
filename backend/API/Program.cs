using API.Data;
using API.Helpers;
using API.Services;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddHttpClient();
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("db")));
#region Register DI
services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
services.AddScoped<ICustomerService, CustomerService>();
services.AddScoped<IEmailSystemService, EmailSystemService>();
services.AddScoped<IIndustryService, IndustryService>();
services.AddScoped<IMaintenanceHourlyService, MaintenanceHourlyService>();
services.AddScoped<IMaintenanceLogService, MaintenanceLogService>();
services.AddScoped<IMaintenanceMontlyService, MaintenanceMontlyService>();
services.AddScoped<IMaintenanceReportService, MaintenanceReportService>();
services.AddScoped<IProjectBackupService, ProjectBackUpService>();
services.AddScoped<IProjectCredentialLogService, ProjectCredentialLogService>();
services.AddScoped<IProjectCredentialService, ProjectCredentialService>();
services.AddScoped<IProjectHourlyMaintenanceRecordService, ProjectHourlyMaintenanceRecordService>();
services.AddScoped<IProjectHourlyMaintenanceService, ProjectHourlyMaintenanceService>();
services.AddScoped<IProjectMonthlyMaintenanceService, ProjectMonthlyMaintenanceService>();
services.AddScoped<IProjectService, ProjectService>();
services.AddScoped<IStaffCredentialRequestService, StaffCredentialRequestService>();
services.AddScoped<IStaffService, StaffService>();
services.AddScoped<ITechnologyUsedService, TechnologyUsedService>();
services.AddScoped<ITicketImageService, TicketImageService>();
services.AddScoped<ITicketReplyService, TicketReplyService>();
services.AddScoped<ITicketService, TicketService>();
# endregion
services.AddCors();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options =>
       options.WithOrigins(ConstantHelper.Fontend_URL)
       .AllowAnyHeader()
       .AllowAnyMethod());
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
