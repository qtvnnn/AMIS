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
    /// Department Reposiotry implement BaseReposiotry, IDepartmentRepository
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class DepartmentRepository : BaseReposiotry<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public Department GetDepartmentById(Guid departmentId)
        {
            var sql = "  SELECT * FROM Department e WHERE e.DepartmentId = '" + departmentId + "'";
            var res = _dbConnection.Query<Department>(sql, commandType: CommandType.Text).FirstOrDefault();

            return res;
        }
    }
}
