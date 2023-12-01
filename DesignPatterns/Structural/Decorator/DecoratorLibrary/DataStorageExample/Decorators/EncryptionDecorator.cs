using System;
using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        private readonly string encryptionBlock;
        
        public EncryptionDecorator(IDataSource dataSource) 
            : base(dataSource)
        {
            encryptionBlock = "##3NCRYPT3D##";
        }
        
        public override void Write(string data)
        {
            Console.WriteLine("Encryption");

            var encryptedData = Encrypt(data);
            wrapee.Write(encryptedData);
        }
        
        public override string Read()
        {
            var encryptedData = wrapee.Read();
            return Decrypt(encryptedData);
        }
        
        private string Encrypt(string data)
            => $"{encryptionBlock}{data}{encryptionBlock}";
        
        private string Decrypt(string data)
            => data.Replace(encryptionBlock, string.Empty);
    }
}