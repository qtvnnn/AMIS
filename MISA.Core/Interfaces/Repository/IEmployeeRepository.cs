using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Repository
{
    /// <summary>
    /// Interface Employee Repository implement IBaseRepository
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        /// <summary>
        /// Lấy dữ liệu của một nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="code">Mã nhân viên</param>
        /// <returns>Dữ liệu đối tượng nhân viên</returns>
        Employee GetEmployeeByCode(string code);

        IEnumerable<Employee> GetEmployeesWithDepartmentName();

        IEnumerable<Employee> GetEmployeeByCodeNamePhone(string search);

        string GetNewEmployeeCode();
    }
}
