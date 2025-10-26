using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ten
{
    public class CustomerOperations
    {
        private const string path = @"ten\resources\Customers.csv";

        public List<Customer> GetAllCustomers()
        {
            string[] textArray = File.ReadAllLines(path).Skip(1).ToArray();
            List<Customer> customers = new List<Customer>();
            foreach (string text in textArray)
            {
                customers.Add(ParseCustomer(text));
            }

            return customers;
        }

        public Customer GetSingleCustomer(int customerId)
        {
            List<Customer> allCustomers = GetAllCustomers();
            foreach (Customer customer in allCustomers)
            {
                if (customer.Id == customerId)
                {
                    return customer;
                }
            }
            return null;
        }

        public int AddCustomer(Customer model)
        {
            List<Customer> allCustomers = GetAllCustomers();
            if (allCustomers.Count == 0)
            {
                model.Id = 1;
            }
            else
            {
                model.Id = allCustomers[allCustomers.Count - 1].Id + 1;
            }
            File.AppendAllText(path, Environment.NewLine + model.ToString());
            return model.Id;
        }

        public int UpdateCustomer(Customer model)
        {
            List<Customer> allCustomers = GetAllCustomers();
            bool exists = false;
            foreach (Customer customer in allCustomers)
            {
                if (customer.Id.Equals(model.Id))
                {
                    exists = true;
                    customer.Name = model.Name;
                    customer.IdentityNumber = model.IdentityNumber;
                    customer.PhoneNumber = model.PhoneNumber;
                    customer.Email = model.Email;
                    customer.Type = model.Type;
                    break;
                }
            }
            if (!exists)
            {
                return 0;
            }
            List<string> lines = new List<string> { "Id,Name,IdentityNumber,PhoneNumber,Email,Type" };
            foreach (Customer c in allCustomers)
            {
                lines.Add(c.ToString());
            }
            File.WriteAllLines(path, lines);

            return 1;
        }

        public int DeleteCustomer(int customerId)
        {
            List<Customer> allCustomers = GetAllCustomers();
            Customer customerToDelete = null;

            foreach (Customer customer in allCustomers)
            {
                if (customer.Id == customerId)
                {
                    customerToDelete = customer;
                    break;
                }
            }

            if (customerToDelete == null)
                return 0;

            allCustomers.Remove(customerToDelete);

            List<string> lines = new List<string> { "Id,Name,IdentityNumber,PhoneNumber,Email,Type" };
            foreach (Customer customer in allCustomers)
            {
                lines.Add(customer.ToString());
            }

            File.WriteAllLines(path, lines);

            return 1;
        }

        private Customer ParseCustomer(string text)
        {
            string[] parts = text.Split(',');
            if (parts.Length != 6)
                throw new Exception("Invalid CSV line: " + text);

            return new Customer
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                IdentityNumber = parts[2],
                PhoneNumber = parts[3],
                Email = parts[4],
                Type = int.Parse(parts[5])
            };
        }
    }
}