using System;

namespace Helpfull.Exeption
{
    public class IsNotLinuxExeption : Exception
    {
        public IsNotLinuxExeption()
        {
            throw new IsNotLinuxExeption("A operating system based on the linux kernel is needed.");
        }

        public IsNotLinuxExeption(string message)
            : base(message)
        {
        }

        public IsNotLinuxExeption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}