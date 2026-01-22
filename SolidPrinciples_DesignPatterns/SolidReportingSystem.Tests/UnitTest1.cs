using SolidReportingSystem.Services;
using SolidReportingSystem.Interfaces;
using Xunit;

namespace SolidReportingSystem.Tests
{
    public class ReportServiceTests
    {
        [Fact]
        public void ReportGenerator_ShouldGenerateReport()
        {
            // Arrange
            IReportGenerator generator = new ReportGenerator();

            // Act
            string result = generator.GenerateReport();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
