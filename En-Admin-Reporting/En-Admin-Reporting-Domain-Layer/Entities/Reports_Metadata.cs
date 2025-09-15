using System.ComponentModel.DataAnnotations;

namespace En_Admin_Reporting_Domain_Layer.Entities
{
    public class Reports_Metadata
    {
        /// <summary>
        /// Unique Report Identifier
        /// </summary>
        [Required] public int ReportId { get; set; }

        /// <summary>
        /// Name of Report
        /// </summary>
        [Required] public string ReportName { get; set; }

        /// <summary>
        /// Format/Type of report(CSV,XLS,PDF)
        /// </summary>
        [Required] public string ReportType { get; set; }

        /// <summary>
        /// Timestamp when report was generated
        /// </summary>
        [Required] public DateTime GeneratedAt { get; set; }

        /// <summary>
        /// Admin user who generated the report
        /// </summary>
        [Required] public int GeneratedBy { get; set; }
    }
}
