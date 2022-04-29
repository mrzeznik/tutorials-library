using Library.Repository;
using Xunit;

namespace Library.Data.Tests
{
    public class CsvFileAccessTests
    {
        [Fact]
        public void Read_EmptyFile_Pass()
        {
            // Arrange
            var fileAccess = new CsvFileAccess<Day>();
            var filePath = "../../../TestData/no_days.csv";

            // Act
            var days = fileAccess.Read(filePath);

            // Assert
            Assert.Empty(days);
        }

        [Fact]
        public void Read_File_Pass()
        {
            // Arrange
            var fileAccess = new CsvFileAccess<Day>();
            var filePath = "../../../TestData/days.csv";

            // Act
            var days = fileAccess.Read(filePath);

            // Assert
            Assert.NotEmpty(days);
        }

        [Fact]
        public void Read_NoFile_Fail()
        {
            // Arrange
            var fileAccess = new CsvFileAccess<Day>();
            var filePath = "not_existing_file.csv";

            // Act
            var days = fileAccess.Read(filePath);

            // this should fail by returning empty collection, without an Exception
            // Assert
            Assert.Empty(days);
        }

        private class Day
        {
            public int DayOfWeek { get; set; }
            public string Name { get; set; }
        }
    }
}