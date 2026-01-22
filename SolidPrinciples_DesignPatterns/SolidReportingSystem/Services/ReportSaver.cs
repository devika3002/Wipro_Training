using SolidReportingSystem.Interfaces;

namespace SolidReportingSystem.Services
{
    public class ReportSaver : IReportSaver
    {
        public void Save(string reportContent)
        {
            Console.WriteLine("Report saved successfully:");
            Console.WriteLine(reportContent);
        }
    }
}

