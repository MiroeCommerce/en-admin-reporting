namespace En_Admin_Reporting_Service_Layer.Application_Interfaces
{
    public interface IAdminReportingService
    {
        Task<bool> GenerateReportAsync();
        Task GetReportMetadataAsync(); //Add return type of DTO once DTO has been defined
        Task DownloadReportAsync(int id); //Add return type of DTO once DTO has been defined
        Task GetAllSchedulesAsync(); //Add return type of DTO once DTO has been defined
        Task<bool> CreateScheduleAsync();
    }
}
