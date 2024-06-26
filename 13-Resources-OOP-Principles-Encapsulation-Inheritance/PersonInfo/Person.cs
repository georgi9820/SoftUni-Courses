﻿using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName 
    {
        get { return this._firstName; }
        private set 
        { 
            if (value.Length < 3) 
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this._firstName = value; 
        }
    }

    public string LastName 
    {
        get { return this._lastName; }
        private set 
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this._lastName = value; 
        }
    }

    public int Age
    {
        get { return this._age; }
        private set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this._age = value; 
        }
    }

    public Person(string firstName, string lastName, int age)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
}
