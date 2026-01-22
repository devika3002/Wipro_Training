using SolidReportingSystem.Interfaces;

namespace SolidReportingSystem.Services
{
    public class PdfFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[PDF FORMAT]: {content}";
        }
    }
}

