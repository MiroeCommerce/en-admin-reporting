using System.ComponentModel.DataAnnotations;

namespace En_Admin_Reporting_Domain_Layer.Entities
{
    public class Report_Parameters
    {
        /// <summary>
        /// Unique identifier for parameter
        /// </summary>
        [Required] public int ParameterId { get; set; }

        /// <summary>
        /// Related Report
        /// </summary>
        [Required] public int ReportId { get; set; }

        /// <summary>
        /// Name of filter/parameter
        /// </summary>
        [Required] public string ParameterName { get; set; }

        /// <summary>
        /// Value used for report generation
        /// </summary>
        public string ParameterValue { get; set; }
    }
}
