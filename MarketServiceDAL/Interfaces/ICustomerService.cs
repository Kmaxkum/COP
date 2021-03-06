﻿using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using System.Collections.Generic;

namespace MarketServiceDAL.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerViewModel> GetList();
        CustomerViewModel GetElement(int id);
        void AddElement(CustomerBindingModel model);
        void UpdElement(CustomerBindingModel model);
        void DelElement(int id);
    }
}
