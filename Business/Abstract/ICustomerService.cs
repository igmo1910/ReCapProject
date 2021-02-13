using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<List<Customer>> GetCustomers();
        IDataResult<Customer> GetCustomerById(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
