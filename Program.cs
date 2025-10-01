using System.Security.Cryptography.X509Certificates;

int row = 12;
int column = 12;

for (int x = 1; x <= row; x++)
{
    for (int y = 1; y <= column; y++)
    {
        int z = x * y;
        Console.Write($"|{z}|" + "    ");
        if (y == 12)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
    Console.WriteLine();
}