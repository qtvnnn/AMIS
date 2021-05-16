using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Respository
{
    /// <summary>
    /// Employee Reposiotry implement BaseReposiotry, IEmployeeRepository
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class EmployeeRepository : BaseReposiotry<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public Employee GetEmployeeByCode(string code)
        {
            var res = _dbConnection.Query<Employee>("Proc_GetEmployeeByCode", new { EmployeeCode = code }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return res;
        }

        public IEnumerable<Employee> GetEmployeesWithDepartmentName()
        {
            var res = _dbConnection.Query<Employee>("Proc_GetEmployeesWithDepartmentName", commandType: CommandType.StoredProcedure);
            return res;
        }

        public IEnumerable<Employee> GetEmployeeByCodeNamePhone(string search)
        {

            var sql = "  SELECT * FROM Employee e WHERE e.EmployeeCode LIKE '%" + search + "%' OR e.EmployeeName LIKE '%" + search + "%' OR e.PhoneNumber LIKE '%" + search + "%' ORDER BY e.CreatedDate DESC";
            var res = _dbConnection.Query<Employee>(sql, commandType: CommandType.Text);

            return res;
        }

        public string GetNewEmployeeCode()
        {
            var sql = "SELECT e.EmployeeCode FROM Employee e ORDER BY e.EmployeeCode DESC LIMIT 1;";
            var res = _dbConnection.QueryFirstOrDefault<string>(sql);

            return res;
        }
    }
}
