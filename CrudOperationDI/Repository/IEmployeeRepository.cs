using CrudOperationDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperationDI.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();
        void SaveChange();
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        Employee GetById(int id);
    }
}
