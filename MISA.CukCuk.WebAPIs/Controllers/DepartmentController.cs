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
    public class DepartmentController : BaseEntityController<Department>
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService) : base(departmentService)
        {
            _departmentService = departmentService;
        }
    }
}
