using System;

namespace BaileyBorweinPlouffe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a number: ");

                int N = Convert.ToInt32(Console.ReadLine());
                double sum = 0;

                for (int k = 0; k < N; k++)
                {
                    double A = 1 / Math.Pow(16, k);
                    double k8 = 8 * k;
                    double B = 4 / (k8 + 1) - 2 / (k8 + 4) - 1 / (k8 + 5) - 1 / (k8 + 6);

                    sum += A * B;
                }
                Console.WriteLine($"With N = {N} Pi is {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
