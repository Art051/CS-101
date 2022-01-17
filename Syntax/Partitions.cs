using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try101LinqSamples;

namespace Intro_to_LINQ
{
    internal class Partitions
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;


        public int TakeSyntax()
        {
            #region take-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }

        public int NestedTake()
        {
            #region nested-take
            List<Customer> customers = GetCustomerList();

            var first3WAOrders = (
                from cust in customers
                from order in cust.Orders
                where cust.Region == "WA"
                select (cust.CustomerID, order.OrderID, order.OrderDate))
                .Take(3);

            Console.WriteLine("First 3 orders in WA:");
            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }
            #endregion
            return 0;

        }
        public int TakeWhileSyntax()
        {
            #region takewhile-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }


    }
}
