using FluentValidation;
using System.Collections.Generic;
using TelefonRehberi.Business.Abstract;
using TelefonRehberi.Business.ValidationRules.FluentValidation;
using TelefonRehberi.DataAccess.Abstract;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        private CustomerValidator validator;
        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
            this.validator = new CustomerValidator();
        }
        public void Add(Customer customer)
        {
            var result = validator.Validate(customer);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            customerDal.Delete(customer);
        }

        public Customer Get(int id)
        {
            return customerDal.Get(id);
        }

        public List<Customer> GetAll()
        {
            return customerDal.GetAll();
        }

        public List<Customer> GetCustomerByTitle(string title)
        {
            return customerDal.GetAll();
        }

        public void Update(Customer customer)
        {
            var result = validator.Validate(customer);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            customerDal.Update(customer);
        }
    }
}
