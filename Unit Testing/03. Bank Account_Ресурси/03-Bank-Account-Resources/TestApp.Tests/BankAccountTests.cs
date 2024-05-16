using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 50.0;

        // Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialBalance = 120.0;
        BankAccount account = new BankAccount(initialBalance);
        double deposit = 80.0;

        // Act
        account.Deposit(deposit);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance + deposit));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 120.0;
        BankAccount account = new BankAccount(initialBalance);
        double negative = -65.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Deposit(negative));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 80.0;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawal = 20.0;

        // Act
        account.Withdraw(withdrawal);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialBalance - withdrawal));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 80.0;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawal = -20.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawal));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 1000.0;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawal = 1400.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawal));
    }
}
