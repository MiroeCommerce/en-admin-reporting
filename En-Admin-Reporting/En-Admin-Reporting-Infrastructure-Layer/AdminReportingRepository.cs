using En_Admin_Reporting_Domain_Layer.Entities;
using En_Admin_Reporting_Domain_Layer.RepositoryInterfaces;

namespace En_Admin_Reporting_Infrastructure_Layer
{
    public class AdminReportingRepository : IAdminReportingRepository
    {
        public Task<bool> CreateScheduleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Report_Files> DownloadReportAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GenerateReportAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Report_Schedules>> GetAllSchedulesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Reports_Metadata> GetReportMetadataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
