using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaQuerySyntaxPractice
{
    public static class InMemoryDatabase
    {
        public static List<Department> Departments =>
        [
            new() { DepartmentId = 1, DepartmentName = "IT" },
            new() { DepartmentId = 2, DepartmentName = "HR" },
            new() { DepartmentId = 3, DepartmentName = "Finance" },
            new() { DepartmentId = 4, DepartmentName = "Sales" },
            new() { DepartmentId = 5, DepartmentName = "Marketing" },
            new() { DepartmentId = 6, DepartmentName = "Operations" }
        ];

        public static List<Employee> Employees =>
        [
            new() { EmployeeId = 1, FirstName = "Amit", LastName = "Sharma", Salary = 90000, DepartmentId = 1, ManagerId = null, DateOfBirth = new(1985, 4, 12), HireDate = new(2020, 1, 15), Email = "amit@example.com", City = "Jaipur" },
            new() { EmployeeId = 2, FirstName = "Priya", LastName = "Verma", Salary = 85000, DepartmentId = 2, ManagerId = null, DateOfBirth = new(1988, 7, 21),    HireDate = new(2021, 3, 10), Email = "priya@example.com", City = "Delhi" },
            new() { EmployeeId = 3, FirstName = "Rahul", LastName = "Singh", Salary = 95000, DepartmentId = 3, ManagerId = null, DateOfBirth = new(1984, 9, 5),     HireDate = new(2019, 6, 20), Email = "rahul@example.com", City = "Mumbai" },
            new() { EmployeeId = 4, FirstName = "Neha", LastName = "Gupta", Salary = 80000, DepartmentId = 4, ManagerId = null, DateOfBirth = new(1990, 2, 18),     HireDate = new(2022, 4, 11), Email = "neha@example.com", City = "Jaipur" },
            new() { EmployeeId = 5, FirstName = "Vikas", LastName = "Patel", Salary = 75000, DepartmentId = 1, ManagerId = 1, DateOfBirth = new(1992, 11, 30),  HireDate = new(2023, 2, 1), Email = "vikas@example.com", City = "Pune" },
            new() { EmployeeId = 6, FirstName = "Anjali", LastName = "Mehta", Salary = 75000, DepartmentId = 1, ManagerId = 1, DateOfBirth = new(1994, 1, 15),  HireDate = new(2024, 5, 10), Email = "anjali@example.com", City = "Jaipur" },
            new() { EmployeeId = 7, FirstName = "Rohit", LastName = "Kumar", Salary = 60000, DepartmentId = 2, ManagerId = 2, DateOfBirth = new(1995, 6, 25),   HireDate = new(2025, 8, 15), Email = "rohit@example.com", City = "Delhi" },
            new() { EmployeeId = 8, FirstName = "Sneha", LastName = "Joshi", Salary = 65000, DepartmentId = 3, ManagerId = 3, DateOfBirth = new(1991, 12, 3),   HireDate = new(2025, 11, 1), Email = "sneha@example.com", City = "Mumbai" },
            new() { EmployeeId = 9, FirstName = "Karan", LastName = "Malhotra", Salary = 55000, DepartmentId = 4, ManagerId = 4, DateOfBirth = new(1993, 3, 19),    HireDate = new(2026, 3, 1), Email = "karan@example.com", City = "Jaipur" },
            new() { EmployeeId = 10, FirstName = "Pooja", LastName = "Reddy", Salary = 50000, DepartmentId = 1, ManagerId = 1, DateOfBirth = new(1996, 8, 14),  HireDate = new(2026, 5, 15), Email = "pooja@example.com", City = "Hyderabad" },
            new() { EmployeeId = 11, FirstName = "Arjun", LastName = "Nair", Salary = 45000, DepartmentId = 4, ManagerId = 4, DateOfBirth = new(1997, 5, 23),   HireDate = new(2026, 7, 1), Email = "arjun@example.com", City = "Kochi" },
            new() { EmployeeId = 12, FirstName = "Kavita", LastName = "Shah", Salary = 60000, DepartmentId = 3, ManagerId = 3, DateOfBirth = new(1989, 10, 9),  HireDate = new(2026, 8, 10), Email = "kavita@example.com", City = "Mumbai" },
            new() { EmployeeId = 13, FirstName = "Manish", LastName = "Yadav", Salary = 40000, DepartmentId = null, ManagerId = null, DateOfBirth = new(1998, 1,    11), HireDate = new(2026, 9, 1), Email = "manish@example.com", City = "Jaipur" },
            new() { EmployeeId = 14, FirstName = "Riya", LastName = "Kapoor", Salary = 75000, DepartmentId = 1, ManagerId = 1, DateOfBirth = new(1993, 4, 28),  HireDate = new(2026, 9, 15), Email = "riya@example.com", City = "Delhi" },
            new() { EmployeeId = 15, FirstName = "Dev", LastName = "Mishra", Salary = 55000, DepartmentId = 2, ManagerId = 2, DateOfBirth = new(1995, 9, 17), HireDate = new(2026, 10, 1), Email = "dev@example.com", City = "Jaipur" }
        ];

        public static List<Customer> Customers =>
        [
            new() { CustomerId = 1, FirstName = "Aarav", LastName = "Sharma", Email = "aarav@example.com", City = "Jaipur", RegistrationDate = new(2024, 1, 10) },
            new() { CustomerId = 2, FirstName = "Isha", LastName = "Verma", Email = "isha@example.com", City = "Delhi", RegistrationDate = new(2024, 3, 15) },
            new() { CustomerId = 3, FirstName = "Kabir", LastName = "Singh", Email = "kabir@example.com", City = "Mumbai", RegistrationDate = new(2024, 6, 20) },
            new() { CustomerId = 4, FirstName = "Meera", LastName = "Gupta", Email = "meera@example.com", City = "Pune", RegistrationDate = new(2025, 1, 5) },
            new() { CustomerId = 5, FirstName = "Aditya", LastName = "Patel", Email = "aditya@example.com", City = "Jaipur", RegistrationDate = new(2025, 4, 12) },
            new() { CustomerId = 6, FirstName = "Tanya", LastName = "Joshi", Email = "tanya@example.com", City = "Delhi", RegistrationDate = new(2025, 8, 25) }
        ];

        public static List<Product> Products =>
        [
            new() { ProductId = 1, ProductName = "Laptop", Category = "Electronics", UnitPrice = 60000 },
            new() { ProductId = 2, ProductName = "Mouse", Category = "Electronics", UnitPrice = 800 },
            new() { ProductId = 3, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 1500 },
            new() { ProductId = 4, ProductName = "Monitor", Category = "Electronics", UnitPrice = 12000 },
            new() { ProductId = 5, ProductName = "Desk", Category = "Furniture", UnitPrice = 8000 },
            new() { ProductId = 6, ProductName = "Chair", Category = "Furniture", UnitPrice = 5000 },
            new() { ProductId = 7, ProductName = "Headphones", Category = "Electronics", UnitPrice = 2500 },
            new() { ProductId = 8, ProductName = "Webcam", Category = "Electronics", UnitPrice = 3500 }
        ];

        public static List<Order> Orders =>
        [
            new() { OrderId = 1, CustomerId = 1, OrderDate = new(2025, 1, 5), TotalAmount = 60800 },
            new() { OrderId = 2, CustomerId = 2, OrderDate = new(2025, 1, 15), TotalAmount = 1500 },
            new() { OrderId = 3, CustomerId = 1, OrderDate = new(2025, 2, 5), TotalAmount = 12000 },
            new() { OrderId = 4, CustomerId = 3, OrderDate = new(2025, 2, 20), TotalAmount = 8000 },
            new() { OrderId = 5, CustomerId = 2, OrderDate = new(2025, 3, 10), TotalAmount = 62500 },
            new() { OrderId = 6, CustomerId = 4, OrderDate = new(2025, 3, 15), TotalAmount = 5000 },
            new() { OrderId = 7, CustomerId = 1, OrderDate = new(2025, 4, 5), TotalAmount = 4100 },
            new() { OrderId = 8, CustomerId = 2, OrderDate = new(2025, 4, 18), TotalAmount = 12000 },
            new() { OrderId = 9, CustomerId = 3, OrderDate = new(2025, 5, 5), TotalAmount = 60000 },
            new() { OrderId = 10, CustomerId = 1, OrderDate = new(2025, 5, 20), TotalAmount = 2500 },
            new() { OrderId = 11, CustomerId = 2, OrderDate = new(2025, 6, 10), TotalAmount = 800 },
            new() { OrderId = 12, CustomerId = 3, OrderDate = new(2025, 6, 25), TotalAmount = 1500 },
            new() { OrderId = 13, CustomerId = 1, OrderDate = new(2025, 7, 5), TotalAmount = 12000 },
            new() { OrderId = 14, CustomerId = 2, OrderDate = new(2025, 7, 15), TotalAmount = 8000 },
            new() { OrderId = 15, CustomerId = 3, OrderDate = new(2025, 8, 5), TotalAmount = 5000 },
            new() { OrderId = 16, CustomerId = 1, OrderDate = new(2025, 8, 20), TotalAmount = 60000 },
            new() { OrderId = 17, CustomerId = 2, OrderDate = new(2025, 9, 10), TotalAmount = 2500 },
            new() { OrderId = 18, CustomerId = 3, OrderDate = new(2025, 9, 25), TotalAmount = 3500 },
            new() { OrderId = 19, CustomerId = 1, OrderDate = new(2025, 10, 5), TotalAmount = 8000 },
            new() { OrderId = 20, CustomerId = 2, OrderDate = new(2025, 10, 15), TotalAmount = 12000 },
            new() { OrderId = 21, CustomerId = 3, OrderDate = new(2025, 11, 5), TotalAmount = 1500 },
            new() { OrderId = 22, CustomerId = 1, OrderDate = new(2025, 11, 20), TotalAmount = 5000 },
            new() { OrderId = 23, CustomerId = 2, OrderDate = new(2025, 12, 5), TotalAmount = 60000 },
            new() { OrderId = 24, CustomerId = 3, OrderDate = new(2025, 12, 20), TotalAmount = 800 },
            new() { OrderId = 25, CustomerId = 4, OrderDate = new(2026, 1, 10), TotalAmount = 12000 },
            new() { OrderId = 26, CustomerId = 5, OrderDate = new(2026, 2, 15), TotalAmount = 60000 },
            new() { OrderId = 27, CustomerId = 6, OrderDate = new(2026, 3, 20), TotalAmount = 2500 },
            new() { OrderId = 28, CustomerId = 4, OrderDate = new(2026, 4, 10), TotalAmount = 8000 },
            new() { OrderId = 29, CustomerId = 5, OrderDate = new(2026, 5, 15), TotalAmount = 1500 },
            new() { OrderId = 30, CustomerId = 6, OrderDate = new(2026, 6, 20), TotalAmount = 5000 },
            new() { OrderId = 31, CustomerId = 1, OrderDate = new(2026, 7, 10), TotalAmount = 60000 },
            new() { OrderId = 32, CustomerId = 2, OrderDate = new(2026, 8, 15), TotalAmount = 3500 },
            new() { OrderId = 33, CustomerId = 3, OrderDate = new(2026, 9, 20), TotalAmount = 12000 },
            new() { OrderId = 34, CustomerId = 4, OrderDate = new(2026, 10, 5), TotalAmount = 800 }
        ];

        public static List<OrderItem> OrderItems =>
        [
            new() { OrderItemId = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 800 },
            new() { OrderItemId = 3, OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 1500 },
            new() { OrderItemId = 4, OrderId = 3, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 5, OrderId = 4, ProductId = 5, Quantity = 1, UnitPrice = 8000 },
            new() { OrderItemId = 6, OrderId = 5, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 7, OrderId = 5, ProductId = 7, Quantity = 1, UnitPrice = 2500 },
            new() { OrderItemId = 8, OrderId = 6, ProductId = 6, Quantity = 1, UnitPrice = 5000 },
            new() { OrderItemId = 9, OrderId = 7, ProductId = 7, Quantity = 1, UnitPrice = 2500 },
            new() { OrderItemId = 10, OrderId = 7, ProductId = 2, Quantity = 2, UnitPrice = 800 },
            new() { OrderItemId = 11, OrderId = 8, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 12, OrderId = 9, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 13, OrderId = 10, ProductId = 7, Quantity = 1, UnitPrice = 2500 },
            new() { OrderItemId = 14, OrderId = 11, ProductId = 2, Quantity = 1, UnitPrice = 800 },
            new() { OrderItemId = 15, OrderId = 12, ProductId = 3, Quantity = 1, UnitPrice = 1500 },
            new() { OrderItemId = 16, OrderId = 13, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 17, OrderId = 14, ProductId = 5, Quantity = 1, UnitPrice = 8000 },
            new() { OrderItemId = 18, OrderId = 15, ProductId = 6, Quantity = 1, UnitPrice = 5000 },
            new() { OrderItemId = 19, OrderId = 16, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 20, OrderId = 17, ProductId = 7, Quantity = 1, UnitPrice = 2500 },
            new() { OrderItemId = 21, OrderId = 18, ProductId = 8, Quantity = 1, UnitPrice = 3500 },
            new() { OrderItemId = 22, OrderId = 19, ProductId = 5, Quantity = 1, UnitPrice = 8000 },
            new() { OrderItemId = 23, OrderId = 20, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 24, OrderId = 21, ProductId = 3, Quantity = 1, UnitPrice = 1500 },
            new() { OrderItemId = 25, OrderId = 22, ProductId = 6, Quantity = 1, UnitPrice = 5000 },
            new() { OrderItemId = 26, OrderId = 23, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 27, OrderId = 24, ProductId = 2, Quantity = 1, UnitPrice = 800 },
            new() { OrderItemId = 28, OrderId = 25, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 29, OrderId = 26, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 30, OrderId = 27, ProductId = 7, Quantity = 1, UnitPrice = 2500 },
            new() { OrderItemId = 31, OrderId = 28, ProductId = 5, Quantity = 1, UnitPrice = 8000 },
            new() { OrderItemId = 32, OrderId = 29, ProductId = 3, Quantity = 1, UnitPrice = 1500 },
            new() { OrderItemId = 33, OrderId = 30, ProductId = 6, Quantity = 1, UnitPrice = 5000 },
            new() { OrderItemId = 34, OrderId = 31, ProductId = 1, Quantity = 1, UnitPrice = 60000 },
            new() { OrderItemId = 35, OrderId = 32, ProductId = 8, Quantity = 1, UnitPrice = 3500 },
            new() { OrderItemId = 36, OrderId = 33, ProductId = 4, Quantity = 1, UnitPrice = 12000 },
            new() { OrderItemId = 37, OrderId = 34, ProductId = 2, Quantity = 1, UnitPrice = 800 }
        ];

        public static List<Sale> Sales =>
        [
            new() { SaleId = 1, SaleDate = new(2024, 1, 5), Revenue = 10000 },
            new() { SaleId = 2, SaleDate = new(2024, 1, 15), Revenue = 15000 },
            new() { SaleId = 3, SaleDate = new(2024, 2, 5), Revenue = 12000 },
            new() { SaleId = 4, SaleDate = new(2024, 2, 20), Revenue = 18000 },
            new() { SaleId = 5, SaleDate = new(2024, 3, 10), Revenue = 20000 },
            new() { SaleId = 6, SaleDate = new(2024, 3, 15), Revenue = 17000 },
            new() { SaleId = 7, SaleDate = new(2025, 1, 5), Revenue = 22000 },
            new() { SaleId = 8, SaleDate = new(2025, 1, 15), Revenue = 25000 },
            new() { SaleId = 9, SaleDate = new(2025, 2, 5), Revenue = 28000 },
            new() { SaleId = 10, SaleDate = new(2025, 2, 20), Revenue = 23000 },
            new() { SaleId = 11, SaleDate = new(2025, 3, 10), Revenue = 30000 },
            new() { SaleId = 12, SaleDate = new(2025, 3, 15), Revenue = 32000 },
            new() { SaleId = 13, SaleDate = new(2025, 4, 5), Revenue = 28000 },
            new() { SaleId = 14, SaleDate = new(2025, 4, 18), Revenue = 35000 },
            new() { SaleId = 15, SaleDate = new(2025, 5, 5), Revenue = 40000 },
            new() { SaleId = 16, SaleDate = new(2025, 5, 20), Revenue = 38000 },
            new() { SaleId = 17, SaleDate = new(2025, 6, 10), Revenue = 42000 },
            new() { SaleId = 18, SaleDate = new(2025, 6, 25), Revenue = 45000 },
            new() { SaleId = 19, SaleDate = new(2025, 7, 5), Revenue = 41000 },
            new() { SaleId = 20, SaleDate = new(2025, 7, 15), Revenue = 48000 },
            new() { SaleId = 21, SaleDate = new(2025, 8, 5), Revenue = 50000 },
            new() { SaleId = 22, SaleDate = new(2025, 8, 20), Revenue = 47000 },
            new() { SaleId = 23, SaleDate = new(2025, 9, 10), Revenue = 52000 },
            new() { SaleId = 24, SaleDate = new(2025, 9, 25), Revenue = 55000 },
            new() { SaleId = 25, SaleDate = new(2025, 10, 5), Revenue = 51000 },
            new() { SaleId = 26, SaleDate = new(2025, 10, 15), Revenue = 58000 },
            new() { SaleId = 27, SaleDate = new(2025, 11, 5), Revenue = 60000 },
            new() { SaleId = 28, SaleDate = new(2025, 11, 20), Revenue = 62000 },
            new() { SaleId = 29, SaleDate = new(2025, 12, 5), Revenue = 65000 },
            new() { SaleId = 30, SaleDate = new(2025, 12, 20), Revenue = 68000 },
            new() { SaleId = 31, SaleDate = new(2026, 1, 10), Revenue = 70000 },
            new() { SaleId = 32, SaleDate = new(2026, 1, 20), Revenue = 72000 },
            new() { SaleId = 33, SaleDate = new(2026, 2, 10), Revenue = 75000 },
            new() { SaleId = 34, SaleDate = new(2026, 2, 20), Revenue = 78000 },
            new() { SaleId = 35, SaleDate = new(2026, 3, 10), Revenue = 80000 },
            new() { SaleId = 36, SaleDate = new(2026, 3, 20), Revenue = 85000 },
            new() { SaleId = 37, SaleDate = new(2026, 4, 10), Revenue = 82000 },
            new() { SaleId = 38, SaleDate = new(2026, 4, 20), Revenue = 90000 },
            new() { SaleId = 39, SaleDate = new(2026, 5, 10), Revenue = 95000 },
            new() { SaleId = 40, SaleDate = new(2026, 5, 20), Revenue = 98000 },
            new() { SaleId = 41, SaleDate = new(2026, 6, 10), Revenue = 100000 },
            new() { SaleId = 42, SaleDate = new(2026, 6, 20), Revenue = 105000 }
        ];

        public static List<UserLogin> UserLogins =>
        [
            new() { LoginId = 1, UserId = 101, LoginDate = new(2026, 9, 1) },
            new() { LoginId = 2, UserId = 101, LoginDate = new(2026, 9, 2) },
            new() { LoginId = 3, UserId = 101, LoginDate = new(2026, 9, 3) },
            new() { LoginId = 4, UserId = 101, LoginDate = new(2026, 9, 5) },
            new() { LoginId = 5, UserId = 101, LoginDate = new(2026, 9, 6) },
            new() { LoginId = 6, UserId = 101, LoginDate = new(2026, 9, 7) },
            new() { LoginId = 7, UserId = 101, LoginDate = new(2026, 9, 8) },
            new() { LoginId = 8, UserId = 102, LoginDate = new(2026, 9, 1) },
            new() { LoginId = 9, UserId = 102, LoginDate = new(2026, 9, 3) },
            new() { LoginId = 10, UserId = 102, LoginDate = new(2026, 9, 4) },
            new() { LoginId = 11, UserId = 102, LoginDate = new(2026, 9, 5) },
            new() { LoginId = 12, UserId = 103, LoginDate = new(2026, 9, 10) },
            new() { LoginId = 13, UserId = 103, LoginDate = new(2026, 9, 11) },
            new() { LoginId = 14, UserId = 103, LoginDate = new(2026, 9, 12) },
            new() { LoginId = 15, UserId = 103, LoginDate = new(2026, 9, 13) },
            new() { LoginId = 16, UserId = 103, LoginDate = new(2026, 9, 14) }
        ];

        public static List<NumberSequence> NumberSequence =>
        [
            new() { NumberValue = 1 },
            new() { NumberValue = 2 },
            new() { NumberValue = 3 },
            new() { NumberValue = 4 },
            new() { NumberValue = 5 },
            new() { NumberValue = 6 },
            new() { NumberValue = 8 },
            new() { NumberValue = 9 },
            new() { NumberValue = 12 },
            new() { NumberValue = 13 },
            new() { NumberValue = 15 }
        ];

        public static List<DateRange> DateRanges =>
        [
            new() { RangeId = 1, StartDate = new(2026, 1, 1), EndDate = new(2026, 1, 15) },
            new() { RangeId = 2, StartDate = new(2026, 1, 10), EndDate = new(2026, 1, 25) },
            new() { RangeId = 3, StartDate = new(2026, 1, 26), EndDate = new(2026, 2, 5) },
            new() { RangeId = 4, StartDate = new(2026, 2, 1), EndDate = new(2026, 2, 10) },
            new() { RangeId = 5, StartDate = new(2026, 3, 1), EndDate = new(2026, 3, 15) }
        ];

        public static List<DuplicateRecord> DuplicateRecords =>
        [
            new() { RecordId = 1, EmployeeCode = "E001", EmployeeName = "Amit Sharma", DepartmentName = "IT", Salary = 90000 },
            new() { RecordId = 2, EmployeeCode = "E002", EmployeeName = "Priya Verma", DepartmentName = "HR", Salary = 85000 },
            new() { RecordId = 3, EmployeeCode = "E003", EmployeeName = "Rahul Singh", DepartmentName = "Finance", Salary = 95000 },
            new() { RecordId = 4, EmployeeCode = "E001", EmployeeName = "Amit Sharma", DepartmentName = "IT", Salary = 90000 },
            new() { RecordId = 5, EmployeeCode = "E004", EmployeeName = "Neha Gupta", DepartmentName = "Sales", Salary = 80000 },
            new() { RecordId = 6, EmployeeCode = "E002", EmployeeName = "Priya Verma", DepartmentName = "HR", Salary = 85000 },
            new() { RecordId = 7, EmployeeCode = "E005", EmployeeName = "Vikas Patel", DepartmentName = "IT", Salary = 75000 },
            new() { RecordId = 8, EmployeeCode = "E006", EmployeeName = "Anjali Mehta", DepartmentName = "IT", Salary = 75000 }
        ];

        public static List<DuplicateRecord> SourceRecords =>
        [
            new() { RecordId = 1, EmployeeCode = "E001", EmployeeName = "Amit Sharma", DepartmentName = "IT", Salary = 90000 },
            new() { RecordId = 2, EmployeeCode = "E002", EmployeeName = "Priya Verma", DepartmentName = "HR", Salary = 85000 },
            new() { RecordId = 3, EmployeeCode = "E003", EmployeeName = "Rahul Singh", DepartmentName = "Finance", Salary = 95000 },
            new() { RecordId = 4, EmployeeCode = "E001", EmployeeName = "Amit Sharma", DepartmentName = "IT", Salary = 90000 },
            new() { RecordId = 5, EmployeeCode = "E004", EmployeeName = "Neha Gupta", DepartmentName = "Sales", Salary = 80000 }
        ];

        public static List<MonthlyDepartmentData> MonthlyDepartmentData =>
        [
            new() { DepartmentName = "IT", MonthName = "January", EmployeeCount = 5 },
            new() { DepartmentName = "IT", MonthName = "February", EmployeeCount = 6 },
            new() { DepartmentName = "HR", MonthName = "January", EmployeeCount = 3 },
            new() { DepartmentName = "HR", MonthName = "February", EmployeeCount = 4 },
            new() { DepartmentName = "Finance", MonthName = "January", EmployeeCount = 4 },
            new() { DepartmentName = "Finance", MonthName = "February", EmployeeCount = 5 },
            new() { DepartmentName = "Sales", MonthName = "January", EmployeeCount = 6 },
            new() { DepartmentName = "Sales", MonthName = "February", EmployeeCount = 7 }
        ];

        public static List<TextRecord> TextRecords =>
        [
            new() { TextId = 1, TextContent = "SQL is powerful and SQL is useful" },
            new() { TextId = 2, TextContent = "C# and SQL are useful" },
            new() { TextId = 3, TextContent = "SQL practice improves SQL skills" },
            new() { TextId = 4, TextContent = "  Trim this text  " }
        ];

        public static List<NullableRecord> NullableRecords =>
        [
            new() { RecordId = 1, RecordValue = "Available" },
            new() { RecordId = 2, RecordValue = null },
            new() { RecordId = 3, RecordValue = "Pending" },
            new() { RecordId = 4, RecordValue = null },
            new() { RecordId = 5, RecordValue = "Completed" }
        ];
    }
}
