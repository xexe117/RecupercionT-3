using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacioTema_2
{
    class DataAcces
    {
        public List<Customer> GetCustomer()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GamesPerson;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conec = new SqlConnection(connectionString))
            {
                string sql = @"SELECT customerNumber, customerName FROM customers";
                var customer = conec.Query<Customer>(sql).ToList();
                return customer;
            }
        }

        public List<Order> GetOrdersToCustomer(string idCustomer)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GamesPerson;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conec = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT * FROM orders WHERE orders.customerNumber = { idCustomer }";
                var order = conec.Query<Order>(sql).ToList();
                return order;
            }
        }

        public List<Order> GetOrders(string idOrder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GamesPerson;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conec = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT orderDate, requiredDate, shippedDate, status  FROM orders WHERE orderNumber = { idOrder } ";
                var order = conec.Query<Order>(sql).ToList();
                return order;
            }
        }

        public static List<OrderDetaills> GetDetalls(string idproduct)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GamesPerson;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conec = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT productCode, quantityOrdered, priceEach  FROM orderdetails WHERE orderNumber = { idproduct }";
                var order = conec.Query<OrderDetaills>(sql).ToList();
                return order;
            }
        }

    }
}
