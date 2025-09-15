using System.ComponentModel.DataAnnotations;

namespace En_Admin_Reporting_Domain_Layer.Entities
{
    public class Report_Schedules
    {
        /// <summary>
        /// Unique Schedule ID
        /// </summary>
        [Required] public int ScheduleId { get; set; }

        /// <summary>
        /// Related Report
        /// </summary>
        [Required] public int ReportId { get; set; }

        /// <summary>
        /// Cron-style schedule
        /// </summary>
        [Required] public string CronExpression { get; set; }

        /// <summary>
        /// Schedule active/inactive
        /// </summary>
        [Required] public bool IsActive { get; set; }
    }
}
