using System;

namespace PiRelayServer
{
    class Program
    {
        int num = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void Count()
        {
            Console.WriteLine(num);
            num++;
            Count();
        }
    }
}
