using System;

namespace DigitalWarePrueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            int  max = myArray[0];
            Random rnd = new Random();
            int valor = 0;
            for (int i = 0; i < 5; i++)
            {
                valor = rnd.Next(1, 101);

                myArray[i] = valor ;

                if (valor > max)
                {
                    max = valor;
                }
            }

            Console.Write(max);
           
            Console.ReadKey();
        }


    }
}
