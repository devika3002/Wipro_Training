using SolidReportingSystem.Interfaces;

namespace SolidReportingSystem.Services
{
    public class ReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportFormatter _formatter;
        private readonly IReportSaver _saver;

        public ReportService(
            IReportGenerator generator,
            IReportFormatter formatter,
            IReportSaver saver)
        {
            _generator = generator;
            _formatter = formatter;
            _saver = saver;
        }

        public void ProcessReport()
        {
            var report = _generator.GenerateReport();
            var formatted = _formatter.Format(report);
            _saver.Save(formatted);
        }
    }
}

