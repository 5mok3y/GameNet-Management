using GameNet_Management.DataLayer.Repositories;
using GameNet_Management.DataLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameNet_Management.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly GameNetDBEntities _db;

        public UnitOfWork()
        {
            _db = new GameNetDBEntities();
        }

        //private IGenericRepository<Customers> _customerRepository;
        //public IGenericRepository<Customers> CustomerRepository
        //{
        //    get
        //    {
        //        if (_customerRepository == null)
        //        {
        //            _customerRepository = new GenericRepository<Customers>(_db);
        //        }
        //        return _customerRepository;
        //    }
        //}


        private IGenericRepository<Devices> _devicesRepository;
        public IGenericRepository<Devices> DevicesRepository
        {
            get
            {
                if (_devicesRepository == null)
                {
                    _devicesRepository = new GenericRepository<Devices>(_db);
                }
                return _devicesRepository;
            }
        }


        private IGenericRepository<Personnel> _personnelRepository;
        public IGenericRepository<Personnel> PersonnelRepository
        {
            get
            {
                if (_personnelRepository == null)
                {
                    _personnelRepository = new GenericRepository<Personnel>(_db);
                }
                return _personnelRepository;
            }
        }


        private IGenericRepository<ServiceOptions> _serviceOptionsRepository;
        public IGenericRepository<ServiceOptions> ServiceOptionsRepository
        {
            get
            {
                if (_serviceOptionsRepository == null)
                {
                    _serviceOptionsRepository = new GenericRepository<ServiceOptions>(_db);
                }
                return _serviceOptionsRepository;
            }
        }


        private IGenericRepository<Services> _servicesRepository;
        public IGenericRepository<Services> ServicesRepository
        {
            get
            {
                if (_servicesRepository == null)
                {
                    _servicesRepository = new GenericRepository<Services>(_db);
                }
                return _servicesRepository;
            }
        }


        private IGenericRepository<Sessions> _sessionsRepository;
        public IGenericRepository<Sessions> SessionsRepository
        {
            get
            {
                if (_sessionsRepository == null)
                {
                    _sessionsRepository = new GenericRepository<Sessions>(_db);
                }
                return _sessionsRepository;
            }
        }

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_db);
                }
                return _customerRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
