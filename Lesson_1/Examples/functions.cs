namespace Lesson_1.Examples
{
    public class functions
    {
        void printBlank(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
        }
        double getNumberDigits(int n)
        {
            int nAbs = Math.Abs(n);
            double result = Math.Log10(nAbs);
            return (int)result + 1;
        }
    }
}