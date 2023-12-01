using System;
using System.Text;
using DecoratorLibrary.DataStorageExample.Components.Common;

namespace DecoratorLibrary.DataStorageExample.Components
{
    /// <summary>
    /// Concrete components provide default implementations for the operations.
    /// There might be several variations of these classes in a program.
    /// </summary>
    public class File : IDataSource
    {
        private readonly string name;
        private readonly StringBuilder data;

        public File(string name)
        {
            this.name = name;
            data = new StringBuilder();
        }

        public void Write(string dataToWrite)
        {
            data.Append(dataToWrite);

            Console.WriteLine($"Writing to the file: {name}");
            Console.WriteLine($"Written: {data}");
        }

        public string Read()
            => data.ToString();


        public void ClearContent()
            => data.Clear();
    }
}