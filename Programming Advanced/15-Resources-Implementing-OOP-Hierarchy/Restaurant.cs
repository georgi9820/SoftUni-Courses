using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ExerciseOopHierarchy;

public class Restaurant
{
    private List<Customer> _customers = new();
    private List<MenuItem> _menu = new();

    public void AddCustomer(Customer customer)
    {
        this._customers.Add(customer);
    }

    public MenuItem GetMenuItem(int index) 
    {
        if (index >= _menu.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return this._menu[index];
    }

    public void AddMenuItem(MenuItem menu) 
    {
        this._menu.Add(menu);
    }

    public void PlaceOrder(Customer customer, Order order) 
    {
        customer.AddOrder(order);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Items:");
        foreach (MenuItem item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    public void DisplayOrderHistory(Customer customer) 
    {
        Console.WriteLine($"{customer.Name}'s Order History:");
        foreach (Order order in customer.OrderHistory)
        {
            Console.WriteLine($"Order Total: ${order.GetTotal()}");
            foreach (MenuItem item in order.Items)
            {
                Console.WriteLine($" {item}");
            }
        }
    }

}
