Console.WriteLine("Pleese, input the integer number");
int n = Convert.ToInt32(Console.ReadLine());

void printBlank(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(" ");
    }
}

int getNumberDigits(int n)
{
    int nAbs = Math.Abs(n);
    double result = Math.Log10(nAbs);
    return (int)result + 1;
}

int[,] a = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = n * i + j + 1;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j]);
        printBlank((5 - getNumberDigits(a[i, j])));
    }
    Console.WriteLine();
}


