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

        [HttpGet("employeeFilter")]
        public IActionResult Search(string search)
        {
            var entities = _employeeService.Search(search);
            return Ok(entities);
        }

        [HttpGet("newEmployeeCode")]
        public IActionResult GetNewEmployeeCode()
        {
            try
            {
                var entities = _employeeService.GetNewEmployeeCode();
                string numberEmployeeCode = entities.Substring(3);//Cắt chuỗi lấy các số của mã nhân viên
                string newEmployeeCode = "VN-" + (Int32.Parse(numberEmployeeCode) + 1);//tăng thêm 1 và ghép trở lại thành mã nhân viên hoàn chỉnh
                return Ok(newEmployeeCode);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
