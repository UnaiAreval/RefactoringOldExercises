# RefactoringOldExercises
### Exercise 4

Old code: 
```
Random random = new Random();
int secretNum = 0;
int dorsNumber;

do
{
    Console.WriteLine("Introdueix un número secret que sigui més gran que zero");
    try
    {
        secretNum = Int32.Parse(Console.ReadLine());
    }
    catch{
        Console.WriteLine("Error a l'hora d'introduir el nombre");
    }
} while (secretNum <= 0);

dorsNumber = random.Next(5, 16);
Console.WriteLine("Hi ha {0} portes", dorsNumber);

Console.Write("Pots obrir les portes: ");
for (int i = 1; i < dorsNumber + 1; i++)
{
    if (i%secretNum == 0)
    {
        Console.Write("{0}, ", i);
    }
}
```