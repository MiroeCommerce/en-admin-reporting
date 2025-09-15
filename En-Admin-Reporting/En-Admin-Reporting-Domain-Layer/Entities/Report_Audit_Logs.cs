using System.ComponentModel.DataAnnotations;

namespace En_Admin_Reporting_Domain_Layer.Entities
{
    public class Report_Audit_Logs
    {
        /// <summary>
        /// Unique log identifier
        /// </summary>
        public int LogId { get; set; }

        /// <summary>
        /// Related Report
        /// </summary>
        [Required] public int ReportId { get; set; }

        /// <summary>
        /// Generated, Viewed, Downloaded, etc.
        /// </summary>
        [Required] public string ActionType { get; set; }

        /// <summary>
        /// Admin user performing the action
        /// </summary>
        [Required] public int UserId { get; set; }

        /// <summary>
        /// Log Creation timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
