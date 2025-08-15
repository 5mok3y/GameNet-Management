using GameNet_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.DataLayer.Service
{
    public class CustomerRepository : GenericRepository<Customers>, ICustomerRepository
    {

        public CustomerRepository(GameNetDBEntities db) : base(db)
        {
        }

        public Customers GetByPhone(string phoneNumber)
        {
            return _dbSet.SingleOrDefault(c => c.Phone == phoneNumber);
        }

        public bool IsPhoneExists(string phoneNumber)
        {
            return _dbSet.Any(c => c.Phone == phoneNumber);
        }

    }
}
