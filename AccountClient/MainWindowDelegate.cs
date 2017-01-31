using AccountClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClient
{
    public interface MainWindowDelegate
    {
        void addOrderClickedOk(Order order);
        void addCustomerClickedOk(Customer customer);
    }
}
