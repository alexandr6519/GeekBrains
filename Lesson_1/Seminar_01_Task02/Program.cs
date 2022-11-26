Console.WriteLine("Please, input the integer number!");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];

void printBlanks(int number)
{
    int numberBlank = (int)Math.Log10(number);
    for (int k = 0; k < 5 - numberBlank; k++)
        Console.Write(" ");
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        array[i, j] = n * i + j + 1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($" {array[i, j]}");
        printBlanks(array[i, j]);
    }
    Console.WriteLine();
}