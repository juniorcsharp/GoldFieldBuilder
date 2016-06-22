using System;

namespace FieldGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldGenerator generator = new FieldGenerator();
            generator.Width = 9;
            generator.Height = 9;

            try
            {
                string[,] massPole = generator.СreateField();
                for (int i = 0; i < massPole.GetLength(0); i++)
                {
                    for (int y = 0; y < massPole.GetLength(1); y++)
                    {
                        Console.Write(massPole[i, y] + " ");
                    }
                    Console.WriteLine();
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
