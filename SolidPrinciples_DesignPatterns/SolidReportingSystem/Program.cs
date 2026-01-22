using SolidReportingSystem.Interfaces;
using SolidReportingSystem.Services;

class Program
{
    static void Main()
    {
        IReportGenerator generator = new ReportGenerator();
        IReportFormatter formatter = new PdfFormatter(); // if needed we change to ExcelFormatter 
        IReportSaver saver = new ReportSaver();

        ReportService service = new ReportService(generator, formatter, saver);
        service.ProcessReport();

        Console.ReadLine();
    }
}

