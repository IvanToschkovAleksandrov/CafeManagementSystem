using System.ComponentModel.DataAnnotations;

namespace CafeManagementSystem.Data.Models
{
    public class Role
    {
        /// <summary>
        /// Gets or sets the primary key of this role
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of this role
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
    }
}
