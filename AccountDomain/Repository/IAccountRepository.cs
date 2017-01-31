using AccountDomain.Entity;
using System.Collections.Generic;

namespace AccountDomain
{
    public interface IAccountRepository
    {
        Customer getCustomer(int id);
        List<Customer> getCustomerList();
        void addCustomer(Customer customer);
        void deleteCustomer(Customer customer);
        void addOrder(Order order);
        void deleteOrder(Order order);
        List<Order> getOrders();
    }
}
