using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Business.Abstract
{
    public interface ICustomerService
    {

        Customer Get(int id);
        List<Customer> GetAll();
        List<Customer> GetCustomerByTitle(string title);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
