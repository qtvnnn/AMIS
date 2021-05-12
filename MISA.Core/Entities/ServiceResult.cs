using MISA.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Đối tượng trả về 
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class ServiceResult
    {
        /// <summary>
        /// Dữ liệu trả về sau request
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Lời nhắn trả về
        /// </summary>
        public string Messenger { get; set; }

        /// <summary>
        /// Mã lỗi trả về
        /// </summary>
        public MISACode MISACode { get; set; }
    }
}
