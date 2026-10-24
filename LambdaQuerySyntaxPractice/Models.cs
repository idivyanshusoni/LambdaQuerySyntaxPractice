using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaQuerySyntaxPractice
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int? DepartmentId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Revenue { get; set; }
    }

    public class UserLogin
    {
        public int LoginId { get; set; }
        public int UserId { get; set; }
        public DateTime LoginDate { get; set; }
    }

    public class NumberSequence
    {
        public int NumberValue { get; set; }
    }

    public class DateRange
    {
        public int RangeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class DuplicateRecord
    {
        public int RecordId { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
    }

    public class MonthlyDepartmentData
    {
        public string DepartmentName { get; set; } = string.Empty;
        public string MonthName { get; set; } = string.Empty;
        public int EmployeeCount { get; set; }
    }

    public class TextRecord
    {
        public int TextId { get; set; }
        public string? TextContent { get; set; }
    }

    public class NullableRecord
    {
        public int RecordId { get; set; }
        public string? RecordValue { get; set; }
    }

}
