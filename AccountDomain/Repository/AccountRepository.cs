using System;
using System.Data;
using System.Collections.Generic;
using AccountDomain.Entity;
using Dapper;
using Slapper;
using System.Configuration;
using Npgsql;
using System.Linq;

namespace AccountDomain
{
    public class AccountRepository : IAccountRepository
    {

        private string _connectionString = ConfigurationManager.ConnectionStrings["AccountDB"].ConnectionString;

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(_connectionString);
                
            }
        }

        public void addCustomer(Customer customer)
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                c.Execute("INSERT INTO account.customers (name,email) VALUES(@Name,@Email)", new {Name = customer.Name, Email = customer.Email });
            }
        }

        public void addOrder(Order order)
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                c.Execute("INSERT INTO account.orders (price,createdDate,customerid) VALUES(@price,@createdDate,@customerid)", new { price = order.Price, createdDate = DateTime.Now, customerid = order.CustomerId });
            }
        }

        public void deleteCustomer(Customer customer)
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                c.Execute("DELETE FROM account.customers c WHERE c.customersid=@Id", new { Id = customer.Id });
            }
        }

        public void deleteOrder(Order order)
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                c.Execute("DELETE FROM account.orders o WHERE o.ordersid=@Id", new { Id = order.Id });
            }
        }

        public Customer getCustomer(int id)
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                dynamic result = c.Query<dynamic>("SELECT c.customersid, c.name, c.email, o.ordersid as Orders_OrdersId, o.price as Orders_Price, o.createddate as Orders_CreatedDate, o.customerid as Orders_CustomerId from account.customers c INNER JOIN account.orders o ON c.customersid = o.customerid WHERE c.customersid = @customersid;", new { customersid = id });
                Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Customer), new List<string> { "customersid" });
                Slapper.AutoMapper.Configuration.AddIdentifiers(typeof(Order), new List<string> { "ordersid" }); 

                var asa = (Slapper.AutoMapper.MapDynamic<Customer>(result) as IEnumerable<Customer>).ToList().FirstOrDefault();
                return asa;
            }
        }

        public List<Customer> getCustomerList()
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                var asa = c.Query<Customer>("SELECT * FROM account.customers").AsList();
                return asa;
            }
        }

        public List<Order> getOrders()
        {
            using (IDbConnection c = Connection)
            {
                c.Open();
                var asa = c.Query<Order>("SELECT * FROM account.orders").AsList();
                return asa;
            }
        }
    }
}
