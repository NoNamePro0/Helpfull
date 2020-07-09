using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Hash
            Hash.exampleCalculateMD5();
            Hash.exampleCalculateMD5File();
            Hash.exampleCalculateSHA1();
            Hash.exampleCalculateSHA1File();
            Hash.exampleCalculateSHA256();
            Hash.exampleCalculateSHA256File();
            Hash.exampleCalculateSHA384();
            Hash.exampleCalculateSHA384File();
            Hash.exampleCalculateSHA512();
            Hash.exampleCalculateSHA512File();
        }
    }
}
