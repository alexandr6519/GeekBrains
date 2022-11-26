Console.WriteLine("Please, input the integer number!");
int n = Convert.ToInt32(Console.ReadLine());

double getNumberDigits(int n)
{
    int nAbs = Math.Abs(n);
    double result = Math.Log10(nAbs);
    return (int)result + 1;
}
Console.WriteLine($"The number {n} has {getNumberDigits(n)} digits");