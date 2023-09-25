using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CafeManagementSystem.Data.DataConstants;

namespace CafeManagementSystem.Data.Models
{
    public class Employee
    {
        /// <summary>
        /// Gets or sets the primary key for this employee
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name for this employee
        /// </summary>
        [Required]
        [StringLength(EmployeeNameMaxLength, MinimumLength = EmployeeNameMinLength)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the last name of this employee
        /// </summary>
        [Required]
        [StringLength(EmployeeNameMaxLength, MinimumLength = EmployeeNameMinLength)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the email of this employee
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(EmployeeEmailMaxLength, MinimumLength = EmployeeEmailMinLength)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or sets the salary of this employee
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Foreign key to Roles table
        /// </summary>
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }


        /// <summary>
        /// Navigation property
        /// </summary>
        [Required]
        public virtual Role Role { get; set; } = null!;

        /// <summary>
        /// Navigation property
        /// </summary>
        public virtual ICollection<WorkShift> WorkShifts { get; set; } = new List<WorkShift>();
    }
}
