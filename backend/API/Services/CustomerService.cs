using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface ICustomerService : IBaseService<Customer>
    {
    }
    public class CustomerService : BaseService<Customer>,ICustomerService
    {
        public CustomerService(AppDbContext context) : base(context)
        {
        }
    }
}
