using En_Admin_Reporting_Domain_Layer.Entities;

namespace En_Admin_Reporting_Domain_Layer.RepositoryInterfaces
{
    public interface IAdminReportingRepository
    {
        Task<bool> GenerateReportAsync();
        Task<Reports_Metadata> GetReportMetadataAsync();
        Task<Report_Files> DownloadReportAsync(int id);
        Task<List<Report_Schedules>> GetAllSchedulesAsync();
        Task<bool> CreateScheduleAsync();
    }
}
