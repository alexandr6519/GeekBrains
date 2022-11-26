Console.WriteLine("Please, input the first integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the second integer number different from the first!");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2 * n2)
{
    Console.WriteLine("Первое число является квадратом второго!");
}
else if (n2 == n1 * n1)
{
    Console.WriteLine("Второе число является квадратом первого!");
}
else 
{
    Console.WriteLine("Квадраты чисел отсутствуют!");
}



