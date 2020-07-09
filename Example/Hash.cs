using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Hash
    {
        public static void exampleCalculateMD5()
        {
            Console.WriteLine();
            Console.Write("Enter String, witch will be converted to MD5: ");
            string Text = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateMD5(Text);

            Console.WriteLine("Calculated MD5: " + Hash);
        }

        public static void exampleCalculateMD5File()
        {
            Console.WriteLine();
            Console.Write("Enter Filename, witch file will be converted to MD5: ");
            string Filename = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateMD5File(Filename);

            Console.WriteLine("Calculated MD5: " + Hash);
        }

        public static void exampleCalculateSHA1()
        {
            Console.WriteLine();
            Console.Write("Enter String, witch will be converted to SHA1: ");
            string Text = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA1(Text);

            Console.WriteLine("Calculated SHA1: " + Hash);
        }

        public static void exampleCalculateSHA1File()
        {
            Console.WriteLine();
            Console.Write("Enter Filename, witch file will be converted to SHA1: ");
            string Filename = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA1File(Filename);

            Console.WriteLine("Calculated SHA1: " + Hash);
        }

        public static void exampleCalculateSHA256()
        {
            Console.WriteLine();
            Console.Write("Enter String, witch will be converted to SHA256: ");
            string Text = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA256(Text);

            Console.WriteLine("Calculated SHA256: " + Hash);
        }
        
        public static void exampleCalculateSHA256File()
        {
            Console.WriteLine();
            Console.Write("Enter Filename, witch file will be converted to SHA256: ");
            string Filename = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA256File(Filename);

            Console.WriteLine("Calculated SHA256: " + Hash);
        }

        public static void exampleCalculateSHA384()
        {
            Console.WriteLine();
            Console.Write("Enter String, witch will be converted to SHA384: ");
            string Text = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA384(Text);

            Console.WriteLine("Calculated SHA384: " + Hash);
        }

        public static void exampleCalculateSHA384File()
        {
            Console.WriteLine();
            Console.Write("Enter Filename, witch file will be converted to SHA256: ");
            string Filename = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA384File(Filename);

            Console.WriteLine("Calculated SHA384: " + Hash);
        }

        public static void exampleCalculateSHA512()
        {
            Console.WriteLine();
            Console.Write("Enter String, witch will be converted to SHA512: ");
            string Text = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA512(Text);

            Console.WriteLine("Calculated SHA512: " + Hash);
        }

        public static void exampleCalculateSHA512File()
        {
            Console.WriteLine();
            Console.Write("Enter Filename, witch file will be converted to SHA512: ");
            string Filename = Console.ReadLine();

            string Hash = Helpfull.Hash.CalculateSHA512File(Filename);

            Console.WriteLine("Calculated SHA512: " + Hash);
        }


    }
}
