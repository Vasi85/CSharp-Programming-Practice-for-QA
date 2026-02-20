
using System.Drawing;

int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());
char type;

for (int i = floors; i >= 1 ; i--)
{
    for (int j = 0;  j < estates; j++)
    {
       if (i == floors)
        {
            type = 'L';
            Console.Write($"{type}{i}{j} ");
        }
       else if (i %2 == 0)
        {
            type = 'O';
            Console.Write($"{type}{i}{j} ");
        }
       else 
        {
            type = 'A';
            Console.Write($"{type}{i}{j} ");
        }

    }
    Console.WriteLine();
}