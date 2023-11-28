using System;
using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators
{
    /// <summary>
    /// Concrete decorators must call methods on the wrapped object,
    /// but may add something of their own to the result.
    /// Decorators can execute the added behavior either before or after the call to a wrapped object.
    /// </summary>
    public class CompressionDecorator : DataSourceDecorator
    {
        private readonly string compressionBlock;
        
        public CompressionDecorator(IDataSource dataSource)
            : base(dataSource)
        {
            compressionBlock = "--COMPRESSED--";
        }

        public override void Write(string dataToWrite)
        {
            Console.WriteLine("Compression");
            
            var compressedData = Compress(dataToWrite);
            wrapee.Write(compressedData);
        }
        
        public override string Read()
        {
            var compressedData = wrapee.Read();
            return Decompress(compressedData);
        }

        private string Compress(string data)
            => $"{compressionBlock}{data}{compressionBlock}";

        private string Decompress(string data) 
            => data.Replace(compressionBlock, string.Empty);
    }
}