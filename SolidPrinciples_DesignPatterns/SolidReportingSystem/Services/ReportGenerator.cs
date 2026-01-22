using SolidReportingSystem.Interfaces;

namespace SolidReportingSystem.Services
{
    public class ReportGenerator : IReportGenerator
    {
        public string GenerateReport()
        {
            return "This is the generated report content.";
        }
    }
}

