using En_Admin_Reporting_Service_Layer.Application_Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace En_Admin_Reporting
{
    [ApiController]
    [Route("api/admin/reports")]
    public class AdminReportingController : ControllerBase
    {
        private readonly IAdminReportingService _adminReportingService;
        public AdminReportingController(IAdminReportingService adminReportingService)
        {
            _adminReportingService = adminReportingService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateReport()
        {
            var result = await _adminReportingService.GenerateReportAsync();
            return Ok(result);
        }

        [HttpGet("metadata")]
        public async Task<IActionResult> FetchMetadata()
        {
            await _adminReportingService.GetReportMetadataAsync();
            return Ok();
        }

        [HttpGet("download/{id}")]
        public async Task<IActionResult> DownloadGeneratedReport(int id)
        {
            await _adminReportingService.DownloadReportAsync(id);
            return Ok();
        }

        [HttpGet("schedules")]
        public async Task<IActionResult> GetAllReportSchedules()
        {
            await _adminReportingService.GetAllSchedulesAsync();
            return Ok();
        }

        [HttpPost("schedules")]
        public async Task<IActionResult> CreateNewReportSchedules()
        {
            var result = await _adminReportingService.CreateScheduleAsync();
            return Ok(result);
        }
    }
}
