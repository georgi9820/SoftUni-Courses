﻿using System.Collections.Generic;

namespace ExerciseOopHierarchy;

public class Customer
{
    private List<Order> _orderHistory = new();

    public string Name { get; set; }

    public string Email { get; set; }

    public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();

    public Customer(string name, string email)
    {
        this.Name = name;
        this.Email = email;
    }

    public void AddOrder(Order order)
    {
        this._orderHistory.Add(order);
    }
}
