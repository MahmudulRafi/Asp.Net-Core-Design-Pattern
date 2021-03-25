using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudOperationDI.Data;
using CrudOperationDI.Models;
using CrudOperationDI.Services;

namespace CrudOperationDI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(ApplicationDbContext context, IEmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.GetEmployees());
        }

        public IActionResult Details(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Insert(employee);
                _employeeService.SaveChange();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        public IActionResult Edit(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(employee);
                _employeeService.SaveChange();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
     
        public IActionResult Delete(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeService.Delete(id);
            _employeeService.SaveChange();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
