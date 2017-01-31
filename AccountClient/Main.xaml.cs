using AccountClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountClient.View
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window, MainWindowDelegate
    {
        private ServiceReference1.AccountServiceClient _accountService;
        private Order _selectedOrder;
        private Customer _selectedCustomer;
        private Boolean _isCustomersSelected = true;
        public Order[] ordersDataSource;
        public Customer[] customersDataSource;
        public Main()
        {
            _accountService = new ServiceReference1.AccountServiceClient("NetTcpBinding_IAccountService");
            ordersDataSource = _accountService.getOrders();
            customersDataSource = _accountService.getCustomerList();
            InitializeComponent();
            customers.ItemsSource = customersDataSource;
            orders.ItemsSource = ordersDataSource;
            buttonAddOrder.IsEnabled = false;
            buttonDelete.IsEnabled = false;
        }

        private void reloadAll()
        {
            customersDataSource = _accountService.getCustomerList();
            reloadCustomers(customersDataSource);
            _selectedCustomer = null;
            ordersDataSource = _accountService.getOrders();
            reloadOrders(ordersDataSource);
            _selectedOrder = null;
        }

        private void reloadOrders(Order[] list)
        {
            orders.ItemsSource = null;
            orders.ItemsSource = list;
        }

        private void reloadCustomers(Customer[] list)
        {
            customers.ItemsSource = null;
            customers.ItemsSource = list;
        }

        private void customers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDelete.IsEnabled = false;
            buttonAddOrder.IsEnabled = false;
            _selectedCustomer = (Customer)((DataGrid)sender).SelectedItem;
            if (_selectedCustomer != null)
            {
                buttonAddOrder.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }
        }

        private void orders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDelete.IsEnabled = false;
            _selectedOrder = (Order)((DataGrid)sender).SelectedItem;
            if (_selectedOrder != null)
            {
                buttonDelete.IsEnabled = true;
            }
        }

        private async void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete selected entry?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    if (_selectedCustomer != null)
                    {
                        await _accountService.deleteCustomerAsync(_selectedCustomer);
                        reloadAll();
                    }
                    else if (_selectedOrder != null)
                    {
                        await _accountService.deleteOrderAsync(_selectedOrder);
                        ordersDataSource = _accountService.getOrders();
                        reloadOrders(ordersDataSource);
                        _selectedOrder = null;
                    }
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void Customers_Selected(object sender, RoutedEventArgs e)
        {
            _isCustomersSelected = true;
        }

        private void Orders_Selected(object sender, RoutedEventArgs e)
        {   
            _isCustomersSelected = false;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var asa = _accountService.getCustomer(5);
            if (_isCustomersSelected)
            {
                var addCustomerWindow = new AddCustomer();
                addCustomerWindow.superView = this;
                addCustomerWindow.ShowDialog();
            }
        }

        public async void addOrderClickedOk(Order order)
        {
            await _accountService.addOrderAsync(order);
            ordersDataSource = _accountService.getOrders();
            reloadOrders(ordersDataSource);

        }

        public async void addCustomerClickedOk(Customer customer)
        {
            await _accountService.addCustomerAsync(customer);
            customersDataSource = _accountService.getCustomerList();
            reloadCustomers(customersDataSource);

        }

        private void buttonAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (_isCustomersSelected)
            {
                var customer = _selectedCustomer;
                var order = new Order() { CustomerId = customer.Id };
                if (_selectedCustomer != null)
                {
                    var addOrderWindow = new AddOrder();
                    addOrderWindow.order = order;  
                    addOrderWindow.superView = this;
                    addOrderWindow.ShowDialog();
                }
            }
        }
    }
}
