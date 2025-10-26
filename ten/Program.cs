using System;
using ten;
class Program
{
    static void Main()
    {
        CustomerOperations operations = new CustomerOperations();
        List<Customer> customers = operations.GetAllCustomers();
        foreach (Customer customer1 in customers)
        {
            Console.WriteLine(customer1);
        }

        Console.Write("Enter customer Id: ");
        int id = int.Parse(Console.ReadLine());
        Customer customer = operations.GetSingleCustomer(id);
        if (customer != null)
        {
            Console.WriteLine(customer.ToString());
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
        Customer newCustomer = new Customer();
        Console.Write("Name: ");
        newCustomer.Name = Console.ReadLine();
        Console.Write("IdentityNumber: ");
        newCustomer.IdentityNumber = Console.ReadLine();
        Console.Write("PhoneNumber: ");
        newCustomer.PhoneNumber = Console.ReadLine();
        Console.Write("Email: ");
        newCustomer.Email = Console.ReadLine();
        Console.Write("Type (0 - individual, 1 - company): ");
        newCustomer.Type = int.Parse(Console.ReadLine());

        int newId = operations.AddCustomer(newCustomer);
        Console.WriteLine("Customer added with Id: " + newId);

        Console.Write("Enter Id to update: ");
        int updateId = int.Parse(Console.ReadLine());
        Customer existing = operations.GetSingleCustomer(updateId);
        if (existing == null)
        {
            Console.WriteLine("Customer not found");
        }
        else
        {
            Console.Write("New Name: ");
            existing.Name = Console.ReadLine();
            Console.Write("New IdentityNumber: ");
            existing.IdentityNumber = Console.ReadLine();
            Console.Write("New PhoneNumber: ");
            existing.PhoneNumber = Console.ReadLine();
            Console.Write("New Email: ");
            existing.Email = Console.ReadLine();
            Console.Write("New Type: ");
            existing.Type = int.Parse(Console.ReadLine());

            operations.UpdateCustomer(existing);
            Console.WriteLine("Customer updated successfully.");
        }
        Console.Write("Enter Id to delete: ");
        int deleteId = int.Parse(Console.ReadLine());
        int result = operations.DeleteCustomer(deleteId);
        if (result == 1)
            Console.WriteLine("Deleted successfully.");
        else
        {
            Console.WriteLine("Customer not found.");
        }
    }
}
