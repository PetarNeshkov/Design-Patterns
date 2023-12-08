using System;

namespace CommandLibrary.EmailExample
{
    public class Email
    {
        public void Read() => Console.WriteLine("Email has been read.");
        
        public void Delete() => Console.WriteLine("Email has been deleted.");

        public void Forward() => Console.WriteLine("Email has been forwarded.");

    }
}