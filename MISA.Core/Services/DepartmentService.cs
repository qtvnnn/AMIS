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
    /// Department Service implement BaseService, IDepartmentService
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        IDepartmentRepository _departmentRepository;

        // Constructor
        public DepartmentService(IDepartmentRepository departmentRepository) : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public Department GetDepartmentById(Guid departmentId)
        {
            return _departmentRepository.GetDepartmentById(departmentId);
        }
    }
}
