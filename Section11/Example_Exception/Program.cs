using System;

namespace Example_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            // Podia colocar também "exception e" no lugar do DivideByZeroException 
            //contudo é melhor colocar sempre a exceção mais específica
            catch (DivideByZeroException)
            {
                // neste caso podemos retirar o "e" da condição pois estamos a usar uma mensagem de erro personalizada
                Console.WriteLine("Division by zero is not allowed");
                //Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
