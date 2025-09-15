using System.ComponentModel.DataAnnotations;

namespace En_Admin_Reporting_Domain_Layer.Entities
{
    public class Report_Files
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        [Required] public int FileId { get; set; }

        /// <summary>
        /// Related report
        /// </summary>
        [Required] public int ReportId { get; set; }

        /// <summary>
        /// File storage path
        /// </summary>
        [Required] public string FilePath { get; set; }

        /// <summary>
        /// Size of report size in MB
        /// </summary>
        public double FileSizeMB { get; set; }

        /// <summary>
        /// Timestamp of file creation
        /// </summary>
        [Required] public DateTime CreatedAt { get; set; }
    }
}
