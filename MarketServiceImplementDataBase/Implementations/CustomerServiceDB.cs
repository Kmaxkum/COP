﻿using MarketModel;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketServiceImplementDataBase.Implementations
{
    public class CustomerServiceDB : ICustomerService
    {
        private MarketDbContext context;
        public CustomerServiceDB(MarketDbContext context)
        {
            this.context = context;
        }
        public List<CustomerViewModel> GetList()
        {
            List<CustomerViewModel> result = context.Customers.Select(rec => new CustomerViewModel
            {
                Id = rec.Id,
                CustomerFIO = rec.CustomerFIO,
                State = rec.State.ToString(),
                Sum = rec.Sum
            })
            .ToList();
            return result;
        }
        public CustomerViewModel GetElement(int id)
        {
            Customer element = context.Customers.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new CustomerViewModel
                {
                    Id = element.Id,
                    CustomerFIO = element.CustomerFIO,
                    State = element.State.ToString(),
                    Sum = element.Sum
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(CustomerBindingModel model)
        {
            Customer element = context.Customers.FirstOrDefault(rec => rec.CustomerFIO == model.CustomerFIO);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Customers.Add(new Customer
            {
                CustomerFIO = model.CustomerFIO,
                State = model.State,
                Sum = model.Sum
            });
            context.SaveChanges();
        }
        public void UpdElement(CustomerBindingModel model)
        {
            Customer element = context.Customers.FirstOrDefault(rec => rec.CustomerFIO == model.CustomerFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Customers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.CustomerFIO = model.CustomerFIO;
            element.State = model.State;
            element.Sum = model.Sum;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Customer element = context.Customers.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Customers.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
