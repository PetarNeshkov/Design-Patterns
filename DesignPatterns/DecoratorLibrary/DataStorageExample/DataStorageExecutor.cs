using System;
using DecoratorLibrary.DataStorageExample.Components;
using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators;

namespace DecoratorLibrary.DataStorageExample
{
    public static class DataStorageExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Data storage example");

            ProcessFileWithPlainData();
            ProcessFileWithCompressedData();
            ProcessFileWithCompressedAndEncryptedData();
        }
        
        private static void ProcessFileWithPlainData()
        {
            IDataSource source = new File("file.dat");

            WriteAndRead(source);
        }
        
        private static void ProcessFileWithCompressedData()
        {
            IDataSource source = new File("file.dat");
            source = new CompressionDecorator(source);

            WriteAndRead(source);
        }

        private static void ProcessFileWithCompressedAndEncryptedData()
        {
            IDataSource source = new File("file.dat");
            source = new EncryptionDecorator(source);
            source = new CompressionDecorator(source);

            WriteAndRead(source);
        }
        
        private static void WriteAndRead(IDataSource source)
        {
            source.Write("Hello world");
            Console.WriteLine($"Read: {source.Read()}\n");
        }
    }
}