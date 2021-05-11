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
    }
}
