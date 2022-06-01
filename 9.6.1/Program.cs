using System;

namespace _9._6._1
{
    class Program
    {


        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5] { new ArgumentException(), new MyException("Мое исключение"), new TimeoutException(), new NotSupportedException(), new DivideByZeroException() };

            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("ArgumentException");
                }
                catch (MyException)
                {
                    Console.WriteLine("Мое исключение");
                }

                catch (TimeoutException)
                {
                    Console.WriteLine("TimeoutException");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("NotSupportedException");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("DivideByZeroException");
                }


            }


        }
    }


}
