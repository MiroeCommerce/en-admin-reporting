using En_Admin_Reporting_Domain_Layer.RepositoryInterfaces;
using En_Admin_Reporting_Service_Layer.Application_Interfaces;

namespace En_Admin_Reporting_Service_Layer
{
    public class AdminReportingService : IAdminReportingService
    {
        private readonly IAdminReportingRepository _adminReportingRepository;
        public AdminReportingService(IAdminReportingRepository adminReportingRepository)
        {
            _adminReportingRepository = adminReportingRepository;
        }
        public async Task<bool> CreateScheduleAsync()
        {
            var result = await _adminReportingRepository.CreateScheduleAsync();
            //Add mapping to DTO using AutoMapper once DTOs are defined
            return result;
        }

        public async Task DownloadReportAsync(int id)
        {
            var result = await _adminReportingRepository.DownloadReportAsync(id);
            //Add mapping to DTO using AutoMapper once DTOs are defined
            //return result;
        }

        public async Task<bool> GenerateReportAsync()
        {
            var result = await _adminReportingRepository.GenerateReportAsync();
            return result;
        }

        public async Task GetAllSchedulesAsync()
        {
            var result = await _adminReportingRepository.GetAllSchedulesAsync();
            //Add mapping to DTO using AutoMapper once DTOs are defined
            //return result;
        }

        public async Task GetReportMetadataAsync()
        {
            var result = await _adminReportingRepository.GetReportMetadataAsync();
            //Add mapping to DTO using AutoMapper once DTOs are defined
            //return result;
        }
    }
}
