using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class Employee : BaseEntity
    {
        [PrimaryKey]
        public Guid EmployeeId { get; set; }
        [Duplicate]
        [Required]
        [DisplayName("Mã nhân viên")]
        public string EmployeeCode { get; set; }
        [Required]
        [DisplayName("Tên nhân viên")]
        public string EmployeeName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? gender { get; set; }
        [Required]
        [DisplayName("ID phòng ban")]
        public Guid DepartmentId { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? IdentityDate { get; set; }
        public string IdentityPlace { get; set; }
        public string EmployeePosition { get; set; }
        public string Address { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string BankProvinceName { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
    }
}
