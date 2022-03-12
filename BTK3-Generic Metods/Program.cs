﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK3_Generic_Metods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utilitis utilitis = new Utilitis();

            List<Customer> customersId =  utilitis.BuildList<Customer>(new Customer { Id=1 }, new Customer {  Id=2});

            foreach (var item in customersId)
            {
                Console.WriteLine(item.Id);
            }

            Console.ReadLine();

        }

        public class Customer
        {
            public int Id { get; set; }
        }

        interface ICustomerDal:IRespository<Customer>
        {
            
        }

        public class Products
        {

        }

        interface IProductsDal:IRespository<Products>
        {
            
        }


        interface IRespository<T> where T : class, new()
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);   
            void Update(T entity);

            
        }


        class ProductsDal : IProductsDal
        {
            public void Add(Products entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Products entity)
            {
                throw new NotImplementedException();
            }

            public Products Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Products> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Products entity)
            {
                throw new NotImplementedException();
            }
        }


        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Utilitis
    {
        public List<T> BuildList<T>(params T[] items)
        {

            return new List<T>(items);
        }
    }
}
