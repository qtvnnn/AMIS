using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Đối tượng nhân viên implement BaseEntity
    /// </summary>
    /// CreatedBy: NNNANG (12/05/21)
    public class Employee : BaseEntity
    {
        /// <summary>
        /// Khoá chính của bảng nhân viên
        /// </summary>
        [PrimaryKey]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [Duplicate]
        [Required]
        [DisplayName("Mã nhân viên")]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        [Required]
        [DisplayName("Tên nhân viên")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Ngày sinh nhân viên
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính nhân viên
        /// </summary>
        public int? gender { get; set; }

        /// <summary>
        /// Id phòng ban của nhân viên
        /// </summary>
        [Required]
        [DisplayName("ID phòng ban")]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Số chứng minh thư
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp số chứng minh thư
        /// </summary>
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp số chứng minh thư
        /// </summary>
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Vị trí của nhân viên
        /// </summary>
        public string EmployeePosition { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Số tài khoản ngân hàng
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Tên chi nhánh ngân hàng
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        /// Vị trí chi nhánh
        /// </summary>
        public string BankProvinceName { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số điện thoại bàn
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Đại chỉ email
        /// </summary>
        public string Email { get; set; }
    }
}
