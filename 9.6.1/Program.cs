using System;

namespace _9._6._1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];
            Exception exp1 = new ArgumentException("Недопустимый аргумент");
            
 


            try
            {
              int result =  Div(4,4);
                Console.WriteLine(result);
                foreach (Exception ex in exceptions)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            catch(ArgumentException)
            {
                Console.WriteLine(" ");  
            }
            catch (MyException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }

            catch (TimeoutException)
            {
                Console.WriteLine(" ");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine(" ");
            }
            

            static int Div(int a,int b)
            {
                return a / b;
            }
        }
    }

    class MyException : DivideByZeroException
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
