using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.WebAPIs.Controllers
{
    /// <summary>
    /// Department Controller implement BaseEntityController
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class DepartmentController : BaseEntityController<Department>
    {
        IDepartmentService _departmentService;

        // Constructor
        public DepartmentController(IDepartmentService departmentService) : base(departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("departmentById")]
        public IActionResult Search(Guid id)
        {
            var entities = _departmentService.GetDepartmentById(id);
            return Ok(entities);
        }
    }
}
