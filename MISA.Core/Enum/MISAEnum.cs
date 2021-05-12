using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Enum
{
    /// <summary>
    /// Trạng thái của validate
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public enum MISACode
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        IsValid = 100,

        /// <summary>
        /// Dữ liệu chưa hợp lệ
        /// </summary>
        NotValid = 900,

        /// <summary>
        /// Thành công
        /// </summary>
        Success = 200,

        /// <summary>
        /// Exception
        /// </summary>
        Exception = 500
    }
    /// <summary>
    /// Xác định trạng thái Object Request
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public enum EntityState
    {
        /// <summary>
        /// Thêm mới
        /// </summary>
        Insert = 1,

        /// <summary>
        /// Cập nhật
        /// </summary>
        Update = 2,

        /// <summary>
        /// Xoá
        /// </summary>
        Delete = 3
    }
}
