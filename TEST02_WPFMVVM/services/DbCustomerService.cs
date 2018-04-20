using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST02_WPFMVVM.interfaces;
using TEST02_WPFMVVM.model;


namespace TEST02_WPFMVVM.services
{
    public class DbCustomerService : ICustomersService
    {
        private readonly ShopWitDbEntities context;

        public DbCustomerService()
        {
            context = new ShopWitDbEntities();
        }

        public void Add(CustomerModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public ICollection<CustomerModel> Get()
        {
            return context.Customers.ToList();
           
        }

        public CustomerModel Get(int id)
        {
            var customer = context.Customers.Single(c => c.Id == id);

            return customer;
        }

        public CustomerModel Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            var customer = Get(id);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
       

        public void Update(CustomerModel customer, string name, string address, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
