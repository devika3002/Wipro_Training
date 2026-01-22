using SolidReportingSystem.Interfaces;

namespace SolidReportingSystem.Services
{
    public class ExcelFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[EXCEL FORMAT]: {content}";
        }
    }
}

