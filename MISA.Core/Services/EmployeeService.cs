using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    /// <summary>
    /// Employee Service implement BaseService, IEmployeeService
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        // Constructor
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployeesWithDepartmentName()
        {
            return _employeeRepository.GetEmployeesWithDepartmentName();
        }

        public IEnumerable<Employee> Search(string search)
        {
            return _employeeRepository.GetEmployeeByCodeNamePhone(search);
        }

        public string GetNewEmployeeCode()
        {
            return _employeeRepository.GetNewEmployeeCode();
        }


    }
}
