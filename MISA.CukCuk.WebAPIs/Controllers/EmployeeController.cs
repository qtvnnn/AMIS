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
    /// Employee Controller implement BaseEntityController
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class EmployeeController : BaseEntityController<Employee>
    {
        IEmployeeService _employeeService;

        // Constuctor
        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }
    }
}
