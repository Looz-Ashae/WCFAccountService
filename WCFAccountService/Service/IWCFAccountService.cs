using AccountDomain.Entity;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFAccountService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IWCFAccountService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        Customer getCustomer(int id);
        [OperationContract]
        List<Customer> getCustomerList();
        [OperationContract]
        void addCustomer(Customer customer);
        [OperationContract]
        void deleteCustomer(Customer customer);
        [OperationContract]
        void addOrder(Order order);
        [OperationContract]
        void deleteOrder(Order order);
        [OperationContract]
        List<Order> getOrders();
    }
}
