using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialAmount = 1000;

        // Act
        BankAccount account = new BankAccount(initialAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(initialAmount));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialAmount = 1000;
        double addMoney = 800;
        double expectedMoney = 1800;

        // Act
        BankAccount account = new BankAccount(initialAmount);
        account.Deposit(addMoney);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(expectedMoney));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 1000;
        double negativeMoney = -800;

        // Act & Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Deposit(negativeMoney), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialAmount = 1000;
        double getMoney = 800;
        double expectedMoney = 1800;

        // Act
        BankAccount account = new BankAccount(initialAmount);
        account.Deposit(getMoney);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(expectedMoney));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 1000;
        double negativeMoney = -800;

        // Act & Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Withdraw(negativeMoney), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialAmount = 1000;
        double amountGreaterThanBalance = 1800;

        // Act & Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Withdraw(amountGreaterThanBalance), Throws.ArgumentException);
    }
}
