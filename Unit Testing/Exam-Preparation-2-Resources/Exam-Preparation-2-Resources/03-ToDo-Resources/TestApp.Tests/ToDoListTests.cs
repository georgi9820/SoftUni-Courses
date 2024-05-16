using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NUnit.Framework;
using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "Homework";
        DateTime dueDate = new DateTime(2023, 12, 10);

        // Act
        this._toDoList.AddTask(title, dueDate);

        // Assert
        string expected = $"To-Do List:{Environment.NewLine}[ ] {title} - Due: {dueDate.ToString("MM/dd/yyyy")}";
        Assert.AreEqual(expected, this._toDoList.DisplayTasks());
    }
    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Homework";
        DateTime dueDate = new DateTime(2023, 12, 10);
        this._toDoList.AddTask(title, dueDate);

        // Act
        this._toDoList.CompleteTask("Homework");

        // Assert
        string expected = $"To-Do List:{Environment.NewLine}[✓] {title} - Due: {dueDate.ToString("MM/dd/yyyy")}";
        Assert.AreEqual(expected, this._toDoList.DisplayTasks());
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "Homework";
        DateTime dueDate = new DateTime(2023, 12, 10);
        this._toDoList.AddTask(title, dueDate);

        //Act & Assert
        Assert.That(() => this._toDoList.CompleteTask("Reading"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        // No tasks added

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        DateTime cleaningDueDate = new DateTime(2023, 12, 23);
        DateTime dancingDueDate = new DateTime(2023, 12, 15);

        this._toDoList.AddTask("Cleaning", cleaningDueDate);
        this._toDoList.AddTask("Dancing", dancingDueDate);

        // Act
        string result = this._toDoList.DisplayTasks();
        //this._toDoList.CompleteTask("Cleaning");

        // Assert
        string expectedDisplayAfterCompletion = $"To-Do List:" +
            $"{Environment.NewLine}[ ] Cleaning - Due: {cleaningDueDate.ToString("MM/dd/yyyy")}" +
            $"{Environment.NewLine}[ ] Dancing - Due: {dancingDueDate.ToString("MM/dd/yyyy")}";
        Assert.That(result, Is.EqualTo(expectedDisplayAfterCompletion));

    }
}
