using System;

namespace _9._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MyException : Exception
    {
        public MyException()
        { 
        
        }

        public MyException(string message): base(message)
        { 
        
        }
    }
}
