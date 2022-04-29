using System.Collections.Generic;

namespace Library.Tools
{
    /// <summary>Interface defining methods for flat file access.</summary>
    public interface IFileAccess<T>
    {
        /// <summary>Reads data from file of given T type. If file is not found, or is empty, empty collection will be returned.</summary>
        IEnumerable<T> Read(string filePath);

        /// <summary>Append single entity of T type data.</summary>
        void Store(string filePath, T data);
    }
}