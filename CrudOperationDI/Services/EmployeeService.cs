using CrudOperationDI.Models;
using CrudOperationDI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperationDI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public Employee GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetEmployees(); 
        }

        public void Insert(Employee employee)
        {
            _repository.Insert(employee);
        }

        public void Update(Employee employee)
        {
            _repository.Update(employee);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public void SaveChange()
        {
            _repository.SaveChange();
        }


    }
}
