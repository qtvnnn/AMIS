using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Đối tượng phòng ban implement BaseEntity
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class Department : BaseEntity
    {
        /// <summary>
        /// Khoá chính của bảng phòng ban
        /// </summary>
        [PrimaryKey]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        [Duplicate]
        [Required]
        [DisplayName("Tên phòng ban")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }
    }
}
