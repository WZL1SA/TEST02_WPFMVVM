﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST02_WPFMVVM.interfaces;
using TEST02_WPFMVVM.model;

namespace TEST02_WPFMVVM.services
{
    public class MocCustomersServices : ICustomersService
    {
        private ICollection<CustomerModel> customers;

        public MocCustomersServices()
        {
            customers = new List<CustomerModel>
            {
                new CustomerModel {Id=1, Name = "Name01", Address = "Adres01", Email = "mail@mail.pl", Password = "new password" },
                new CustomerModel {Id=2, Name = "Name02", Address = "Adres02", Email = "mail2@mail.pl", Password = "new password 2" },
                new CustomerModel {Id=3, Name = "Name03", Address = "Adres03", Email = "mail3@mail.pl", Password = "new password 3" },
                new CustomerModel {Id=4, Name = "Name04", Address = "Adres04", Email = "mail4@mail.pl", Password = "new password 4"  },
            };
        }

        public void Add(CustomerModel customer)
        {
            customer.Id = customers.Max(c => c.Id) + 1;
            customers.Add(customer);
        }

        public ICollection<CustomerModel> Get()
        {
            return customers;
        }

        public CustomerModel Get(int id)
        {
            return customers.Single(c => c.Id == id);//wyrażenie Linq
        }

        public CustomerModel Get(string name)
        {
            //jeśli będzie więcej niż 1 to zwróci wyjątek
            return customers.Single(c => c.Name == name);

            //jeśli będzie więcej niż 1 to zwraca pierwszy element
            // return products.First(p => p.Name == name);
        }

        public void Remove(int id)
        {
            var customer = Get(id);
            customers.Remove(customer);
        }

        public void Update(CustomerModel customer, string name, string address, string email, string password)
        {
            customers.Where(c => c.Id == customer.Id).ToList()
                .ForEach(x =>
                {
                    x.Name = name;
                    x.Address = address;
                    x.Email = email;
                    x.Password = password;
                }            
            );
                        
        }
    }
}
