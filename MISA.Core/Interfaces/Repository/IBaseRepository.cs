using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Repository
{
    /// <summary>
    /// Interface Base Repository
    /// </summary>
    /// <typeparam name="T">Kiểu của đối tượng truyền vào</typeparam>
    /// CreatedBy: NNNANG (12/05/21)
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu trong db
        /// </summary>
        /// <returns>Danh sách đối tượng</returns>
        IEnumerable<T> Get();

        /// <summary>
        /// Lấy thông tin một đối tượng theo id
        /// </summary>
        /// <param name="entityId">Đối tượng có id tương ứng</param>
        /// <returns></returns>
        T GetById(Guid entityId);

        /// <summary>
        /// Tạo mới một bản ghi dữ liệu đối tượng trong db
        /// </summary>
        /// <param name="entity">Dữ liệu đối tượng muốn tạo mới</param>
        /// <returns>Số bản ghi bị thay đổi trong db</returns>
        int Insert(T entity);

        /// <summary>
        /// Cập nhật một bản ghi dữ liệu đối tượng theo id trong db
        /// </summary>
        /// <param name="entity">Dữ liệu đối tượng muốn cập nhật</param>
        /// <returns>Số bản ghi bị thay đổi trong db</returns>
        int Update(T entity);

        /// <summary>
        /// Xoá một bản ghi dữ liệu đối tượng theo id trong db
        /// </summary>
        /// <param name="entityId">Id của đối tượng muốn xoá</param>
        /// <returns>Số bản ghi bị thay đổi trong db</returns>
        int Delete(Guid entityId);

        /// <summary>
        /// Lấy dữ liệu theo một property truyền vào
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <param name="property">Property điều kiện của đối tượng</param>
        /// <returns>Dữ liệu của đối tượng đó theo property</returns>
        T GetEntityBySpecs(T entity, PropertyInfo property);
    }
}
