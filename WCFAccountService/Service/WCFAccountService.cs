using System;
using System.Collections.Generic;
using AccountDomain;
using AccountDomain.Entity;

namespace WCFAccountService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "WCFAccountService" в коде и файле конфигурации.
    public class AccountService : IAccountService
    {

        private IAccountRepository _accountRepo;

        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }

        public void addCustomer(Customer customer)
        {
            _accountRepo.addCustomer(customer);
        }

        public void addOrder(Order order)
        {
            _accountRepo.addOrder(order);
        }

        public void deleteCustomer(Customer customer)
        {
            _accountRepo.deleteCustomer(customer);
        }

        public void deleteOrder(Order order)
        {
            _accountRepo.deleteOrder(order);
        }


        public Customer getCustomer(int id)
        {
            return _accountRepo.getCustomer(id);
        }

        public List<Customer> getCustomerList()
        {
            return _accountRepo.getCustomerList();
        }

        public List<Order> getOrders()
        {
            return _accountRepo.getOrders();
        }
    }
}
