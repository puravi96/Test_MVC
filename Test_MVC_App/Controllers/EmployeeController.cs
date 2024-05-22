using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_MVC_App.Models;

namespace Test_MVC_App.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            //Lets create list department for dropdownlist
            List<Department> ListDepartments = new List<Department>()
            {
                new Department() {Id = 1, Name="IT" },
                new Department() {Id = 2, Name="HR" },
                new Department() {Id = 3, Name="Payroll" },
            };
            ViewBag.Departments = ListDepartments;
            //lets create one employee
            Employee emp = new Employee()
            {
                EmployeeId = 1,
                Name = "Pranaya",
                Gender = "Male",
                DepartmentID = 1
            };
            //Pass that employee to the view
            return View(emp);
        }

        public ActionResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };
            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }

}