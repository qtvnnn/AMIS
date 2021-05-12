using Microsoft.AspNetCore.Mvc;
using MISA.Core.Enum;
using MISA.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.WebAPIs.Controllers
{
    /// <summary>
    /// Base Entity Controller implement ControllerBase
    /// </summary>
    /// <typeparam name="T">Đối tượng truyền vào</typeparam>
    /// CreatedBy: NNNANG (12/05/21)
    [Route("api/v1/[controller]s")]
    [ApiController]
    public abstract class BaseEntityController<T> : ControllerBase
    {
        IBaseService<T> _baseService;

        //Constructor
        public BaseEntityController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// Method Get: Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Danh sách dữ liệu</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.Get();
            return Ok(entities);
        }

        /// <summary>
        /// Method Get: Lấy dữ liệu theo id
        /// </summary>
        /// <param name="id">id đối tượng</param>
        /// <returns>Dữ liệu đối tượng có id tương ứng</returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var entity = _baseService.GetById(id);
            return Ok(entity);
        }

        /// <summary>
        /// Method Post: Thêm mới một bản ghi
        /// </summary>
        /// <param name="entity">Dữ liệu đối tượng cần thêm mới</param>
        /// <returns>Status code</returns>
        [HttpPost]
        public IActionResult Post(T entity)
        {
            var serviceResult = _baseService.Insert(entity);
            if (serviceResult.MISACode == MISACode.NotValid)
            {
                return BadRequest(serviceResult);
            }
            else
            {
                return Ok(serviceResult);
            }
        }

        /// <summary>
        /// Method Put: Cập nhật một bản ghi
        /// </summary>
        /// <param name="id">Id đói tượng muốn cập nhật</param>
        /// <param name="entity">Đối tượng muốn cập nhật</param>
        /// <returns>Status code</returns>
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] string id, [FromBody] T entity)
        {
            var keyProperty = entity.GetType().GetProperty($"{typeof(T).Name}Id");
            if (keyProperty.PropertyType == typeof(Guid))
            {
                keyProperty.SetValue(entity, Guid.Parse(id));
            }
            else if (keyProperty.PropertyType == typeof(int))
            {
                keyProperty.SetValue(entity, int.Parse(id));
            }
            else
            {
                keyProperty.SetValue(entity, id);
            }

            var serviceResult = _baseService.Update(entity);
            if (serviceResult.MISACode == MISACode.NotValid)
            {
                return BadRequest(serviceResult);
            }
            else
            {
                return Ok(serviceResult);
            }
        }

        /// <summary>
        /// Method Delete: Cập nhật một bản ghi
        /// </summary>
        /// <param name="id">Id đối tượng muốn xoá</param>
        /// <returns>Status code</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var serviceResult = _baseService.Delete(id);
            if (serviceResult.MISACode == MISACode.NotValid)
            {
                return BadRequest(serviceResult);

            }
            else
            {
                return Ok(serviceResult);
            }
        }
    }
}
