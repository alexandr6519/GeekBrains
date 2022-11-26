void printBlank(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(" ");
    }
}
Console.Write(123);
printBlank(3);
Console.Write(12);
Console.Write(12345);
printBlank(1);
Console.Write(23);

Console.WriteLine("Please, input the integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input jne more the integer number!");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = (n1 > n2) ? n1 : n2;
Console.WriteLine("The maximum number from {0} and {1} is {2}!", n1, n2, max);