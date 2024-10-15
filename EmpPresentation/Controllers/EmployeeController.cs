using EmpDAl;
using EmpPresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpPresentation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository repository;
        public EmployeeController(IRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult RegisterEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterEmployee(EmployeeInfo empObj)
        {
            if(empObj != null) 
            {
                Employee emp = new Employee();
                emp.Id = empObj.Id;
                emp.EmpName = empObj.EmpName;
                emp.Age = empObj.Age;
                emp.Gender = empObj.Gender;
                emp.BloodGroup = empObj.BloodGroup;
                emp.ContactNumber = empObj.ContactNumber;
                emp.Email = empObj.Email;
                bool b=repository.RegisterEmployee(emp);
                return View();
            }
            else
            {
                return View();
            }

        }
        public IActionResult CancelRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CancelRegistration(int id)
        {
            bool x=repository.CancelEmployee(id);
            return RedirectToAction("RegisterEmployee");
        }
        public IActionResult UpdateEmail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateEmail(int id,string email)
        {
            bool x=repository.UpdateEmail(id,email);
            return RedirectToAction("RegisterEmployee");
        }

    }
}
