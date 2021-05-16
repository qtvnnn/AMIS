using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Service
{
    /// <summary>
    /// Interface Department Service implement IBaseService
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IDepartmentService : IBaseService<Department>
    {
        Department GetDepartmentById(Guid departmentId);

    }
}
