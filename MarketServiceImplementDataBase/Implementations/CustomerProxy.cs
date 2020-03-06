using MarketModel;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketServiceImplementDataBase.Implementations
{
    public class CustomerProxy : ICustomerService
    {
        private Dictionary<int, CustomerViewModel> cache;

        private CustomerServiceDB customerServiceDB;

        public CustomerProxy(MarketDbContext context)
        {
            cache = new Dictionary<int, CustomerViewModel>();
            customerServiceDB = new CustomerServiceDB(context);
        }
        public List<CustomerViewModel> GetList()
        {
            Console.WriteLine("Обращение к бд за всеми записями");

            var customerList = customerServiceDB.GetList();
            foreach (var customer in customerList) {
                cache[customer.Id] = customer;
            }
            return customerList;
        }
        public CustomerViewModel GetElement(int id)
        {
            Console.WriteLine($"Обращение к бд за записью {id}");

            CustomerViewModel customer = cache[id];
            if (customer == null) {
                if (customerServiceDB == null) {
                    throw new Exception("Ошибка подключения к бд");
                }

                customer = customerServiceDB.GetElement(id);
                cache[id] = customer;
            }
            return customer;
        }
        public void AddElement(CustomerBindingModel model)
        {
            Console.WriteLine("Добавление новой записи в бд");

            customerServiceDB.AddElement(model);

            Console.WriteLine("Успешное добавление новой записи в бд");
        }
        public void UpdElement(CustomerBindingModel model)
        {
            Console.WriteLine($"Изменение записи {model.Id} в бд");

            customerServiceDB.UpdElement(model);
            cache[model.Id] = customerServiceDB.GetElement(model.Id);

            Console.WriteLine($"Успешное изменение записи {model.Id} в бд");
        }
        public void DelElement(int id)
        {
            Console.WriteLine($"Удаление записи {id} из бд");

            customerServiceDB.DelElement(id);
            cache.Remove(id);

            Console.WriteLine($"Успешное удаление записи {id} из бд");
        }
    }
}
