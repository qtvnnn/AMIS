using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class Department : BaseEntity
    {
        [PrimaryKey]
        public Guid DepartmentId { get; set; }
        [Duplicate]
        [Required]
        [DisplayName("Tên phòng ban")]
        public string DepartmentName { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
    }
}
