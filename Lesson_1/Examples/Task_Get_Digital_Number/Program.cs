Console.WriteLine("Please, input the integer number!");
int n = Convert.ToInt32(Console.ReadLine());

double GetNumberDigits(int n)
{
    if (n < 1) return 0;
    int nAbs = Math.Abs(n);
    double result = Math.Log10(nAbs);
    return (int)result + 1;
}
Console.WriteLine($"The number {n} has {GetNumberDigits(n)} digits");