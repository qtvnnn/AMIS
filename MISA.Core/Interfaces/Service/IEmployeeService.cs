using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Service
{
    /// <summary>
    /// Interface Employee Service implement IBaseService
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IEmployeeService : IBaseService<Employee>
    {
        IEnumerable<Employee> Search(string search);

        IEnumerable<Employee> GetEmployeesWithDepartmentName();
        string GetNewEmployeeCode();

    }
}
