using System;

namespace RefactoringOldCode
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int secretNum = 0;
            int dorsNumber;
            bool validIntEnter = true;

            do
            {
                Console.WriteLine(validIntEnter ? "Introdueix un número secret que sigui més gran que zero:" : "El valor introduit no es un nombre\nReintrodueix el número:");
                
                validIntEnter = Int32.TryParse(Console.ReadLine(), out secretNum);
            } while (!validIntEnter || secretNum <= 0);

            dorsNumber = random.Next(5, 16);
            Console.WriteLine("Hi ha {0} portes", dorsNumber);

            Console.Write("Pots obrir les portes: ");
            for (int i = 1; i < dorsNumber + 1; i++)
            {
                if (i % secretNum == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

        }
    }
}