using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        // Arrange
        var employeeManagementSystem = new EmployeeManagementSystem();

        //Act & Assert
        Assert.That(employeeManagementSystem.EmployeeCount, Is.EqualTo(0));
    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        // Arrange
        EmployeeManagementSystem employeeCollection = new EmployeeManagementSystem();
        employeeCollection.AddEmployee("Petar Petrov");

        // Act
        var result = employeeCollection.GetAllEmployees();

        // Assert
        Assert.AreEqual(employeeCollection.EmployeeCount, result.Count);

        // Option 2
        // string employeeName = "Petar Petrov"";
        // var employeeManagementSystem = new EmployeeManagementSystem();

        // List<string> expected = new List<string>();
        // expected.Add("Petar Petrov");

        // Act
        // employeeManagementSystem.AddEmployee(employeeName);
        // List<string> actualEmployee = employeeManagementSystem.GetAllEmployees();
    }

    [Test]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        // Arrange
        string employee = "";

        // Act & Assert
        EmployeeManagementSystem emptyName = new EmployeeManagementSystem();
        Assert.That(() => emptyName.AddEmployee(employee), Throws.ArgumentException);

        // Option 2:
        // Arrange
        // var employeeManagementSystem = new EmployeeManagementSystem();

        //Act & Assert
        //Assert.Throws<ArgumentException>(() => employeeManagementSystem.AddEmployee(""));
    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        string employeeName = "Ivo Ivo";
        string employeeName2 = "Ivan Ivanov";
        string employeeName3 = "Petar Petrov";


        var employeeManagementSystem = new EmployeeManagementSystem();

        List<string> expected = new List<string>();
        expected.Add("Ivo Ivo");
        expected.Add("Ivan Ivanov");


        //Act
        employeeManagementSystem.AddEmployee(employeeName);
        employeeManagementSystem.AddEmployee(employeeName2);
        employeeManagementSystem.AddEmployee(employeeName3);
        employeeManagementSystem.RemoveEmployee(employeeName3);

        //Assert
        Assert.That(employeeManagementSystem.EmployeeCount, Is.EqualTo(2));
        List<string> actualEmployee = employeeManagementSystem.GetAllEmployees();
        Assert.That(actualEmployee, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        // Arrange
        string employee = "";

        // Act & Assert
        EmployeeManagementSystem emptyName = new EmployeeManagementSystem();
        Assert.That(() => emptyName.RemoveEmployee(employee), Throws.ArgumentException);

        // Option 2
        // string employeeName = "Ivo Ivo";
        // string employeeName2 = "Ivan Ivanov";
        // string employeeName3 = "Petar Petrov";

        // var employeeManagementSystem = new EmployeeManagementSystem();

        //Act
        // employeeManagementSystem.AddEmployee(employeeName);
        // employeeManagementSystem.AddEmployee(employeeName2);
        // employeeManagementSystem.AddEmployee(employeeName3);

        //Assert
        // Assert.Throws<ArgumentException>(() => employeeManagementSystem.RemoveEmployee("Sasho"));
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        string employeeName = "Ivo Ivo";
        string employeeName2 = "Ivan Ivanov";
        string employeeName3 = "Petar Petrov";


        var employeeManagementSystem = new EmployeeManagementSystem();
        List<string> expected = new List<string>();
        expected.Add("Ivo Ivo");
        expected.Add("Ivan Ivanov");
        expected.Add("Petar Petrov");

        //Act
        employeeManagementSystem.AddEmployee(employeeName);
        employeeManagementSystem.AddEmployee(employeeName2);
        employeeManagementSystem.AddEmployee(employeeName3);
        List<string> actualEmployee = employeeManagementSystem.GetAllEmployees();


        //Assert
        Assert.That(actualEmployee, Is.EqualTo(expected));
    }   
}

