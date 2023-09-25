using System.ComponentModel.DataAnnotations;

namespace CafeManagementSystem.Data.Models
{
    public class WorkShift
    {
        /// <summary>
        /// Gets or sets a primary key for this work shift
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets date for this work shift
        /// </summary>
        public DateTime ShiftDate { get; set; }

        /// <summary>
        /// Gets or sets time for the start of this work shift
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets time for the end of this work shift
        /// </summary>
        public TimeSpan EndTime { get; set; }
    }
}
