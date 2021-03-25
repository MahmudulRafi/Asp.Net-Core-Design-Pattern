using CrudOperationDI.Data;
using CrudOperationDI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperationDI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Where(emp => emp.EmployeeID == id).SingleOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return  _context.Employees.ToList();
        }

        public void Insert(Employee employee)
        {
            _context.Add(employee);
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }

        public void Delete(int id)
        {
            Employee employee = GetById(id);
            _context.Remove(employee);
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
