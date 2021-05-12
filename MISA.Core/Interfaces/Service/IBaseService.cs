using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Service
{
    /// <summary>
    /// Interface Base Service
    /// </summary>
    /// <typeparam name="T">Đối tượng truyền vào</typeparam>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IBaseService<T>
    {
        /// <summary>
        /// Service thông tin toàn bộ dự liệu trong db
        /// </summary>
        /// <returns>Danh sách đối tượng</returns>
        IEnumerable<T> Get();

        /// <summary>
        /// Service lấy dữ liệu một đối tượng theo id
        /// </summary>
        /// <param name="entityId">Id của đối tượng</param>
        /// <returns>Dữ liệu đối tượng có id tương ứng</returns>
        T GetById(Guid entityId);

        /// <summary>
        /// Service tạo mới một bản ghi vào db
        /// </summary>
        /// <param name="entity">Dữ liệu đối tượng muốn tạo mới</param>
        /// <returns>Đối tượng trả về theo chuẩn RESful API</returns>
        ServiceResult Insert(T entity);

        /// <summary>
        /// Service cập nhật một bản ghi dữ liệu đối tượng theo id trong db
        /// </summary>
        /// <param name="entity">Dữ liệu đối tượng muốn cập nhật</param>
        /// <returns>Đối tượng trả về theo chuẩn RESful API</returns>
        ServiceResult Update(T entity);

        /// <summary>
        /// Service xoá một bản ghi dữ liệu đối tượng theo id trong db
        /// </summary>
        /// <param name="entityId">Id của đối tượng muốn xoá</param>
        /// <returns>Đối tượng trả về theo chuẩn RESful API</returns>
        ServiceResult Delete(Guid entityId);
    }
}
