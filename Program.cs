namespace Mod1
{
    using System;
    using System.Text.RegularExpressions;
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wrire an amout of N: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] starter = new int[n];
            int[] paired = new int[n];
            int j = 0;
            int[] unpaired = new int[n];
            int k = 0;
            int[] upper = new int[6] { 1, 4, 5, 8, 9, 10 };

            for (int i = 0; i < n; i++)
            {
                starter[i] = random.Next(1, 27);
                if (starter[i] % 2 == 0)
                {
                    paired[j] = starter[i];
                    j++;
                }
                else
                {
                    unpaired[k] = starter[i];
                    k++;
                }
            }

            Compare(j, k);
            Output(paired);
            Output(unpaired);

            void Output(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool check = true;
                    for (int k = 0; k < upper.Length; k++)
                    {
                        if (upper[k] == array[i])
                        {
                            check = false;
                            Console.Write(char.ToUpper(Number2String(array[i], false)) + " ");
                            break;
                        }
                    }

                    if (check)
                    {
                        Console.Write(Number2String(array[i], false) + " ");
                    }
                }

                Console.WriteLine();
            }

            void Compare(int a, int b)
            {
                Array.Resize(ref paired, j);
                Array.Resize(ref unpaired, k);

                if (a > b)
                {
                    Console.WriteLine(a + " больше чем " + b);
                    Console.WriteLine("паарных больше");
                }
                else if (a < b)
                {
                    Console.WriteLine(b + " больше чем " + a);
                    Console.WriteLine("непарных больше");
                }
                else
                {
                    Console.WriteLine(a + " равно " + b);
                    Console.WriteLine("их поровну");
                }
            }

            char Number2String(int number, bool isCaps)
            {
                char c = (char)(isCaps ? 65 : 97 + (number - 1));
                return c;
            }
        }
    }
}
