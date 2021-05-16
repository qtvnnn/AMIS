using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Repository
{
    /// <summary>
    /// Interface Department Repository implement IBaseRepository
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        Department GetDepartmentById(Guid departmentId);
    }
}
