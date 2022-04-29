using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Library.Data
{
    public class CsvFileAccess<T> : IFileAccess<T>
    {
        public IEnumerable<T> Read(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                return csv.GetRecords<T>().ToList();
        }

        public void Store(string filePath, T item)
        {
            using (var writer = new StreamWriter(filePath, true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.NextRecord();
                csv.WriteRecord(item);
            }
        }
    }
}