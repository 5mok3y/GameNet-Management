using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.DataLayer.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customers>
    {
        bool IsPhoneExists(string phoneNumber);
        Customers GetByPhone(string phoneNumber);
    }
}
