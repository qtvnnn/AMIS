using MISA.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Base entity
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class BaseEntity
    {
        /// <summary>
        /// Trạng thái của đối tượng
        /// </summary>
        public EntityState EntityState { get; set; } = EntityState.Insert;

        /// <summary>
        /// Ngày tạo đối tượng
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo đối tượng
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngáy sửa đối tượng
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa đối tượng
        /// </summary>
        public string ModifiedBy { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Duplicate : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayName : Attribute
    {
        public string Name { get; set; }
        public DisplayName(string name = null)
        {
            this.Name = name;
        }
    }
}
