namespace Mod1
{
    using System;
    using System.Text.RegularExpressions;
    internal static class Program
    {
        public enum Translator
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6,
            G = 7,
            H = 8,
            I = 9,
            J = 10,
            K = 11,
            L = 12,
            M = 13,
            N = 14,
            O = 15,
            P = 16,
            Q = 17,
            R = 18,
            S = 19,
            T = 20,
            U = 21,
            V = 22,
            W = 23,
            X = 24,
            Y = 25,
            Z = 26,
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("write amount of N: ");
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

            Array.Resize(ref paired, j);
            Array.Resize(ref unpaired, k);
            Cheker(paired);
            Console.WriteLine();
            Cheker(unpaired);
            Console.WriteLine();
            Compare(paired.Length, unpaired.Length);

            void Cheker(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool result = false;
                    for (int j = 0; j < upper.Length; j++)
                    {
                        if (upper[j] == array[i])
                        {
                            Console.Write((Translator)array[i] + " ");
                            result = true;
                            break;
                        }
                    }

                    if (result)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(ToLower((Translator)array[i]) + ' ');
                    }
                }
            }

            void Compare(int a, int b)
            {
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
        }

        public static string ToLower(this object obj)
        {
            return obj.ToString().ToLower();
        }
    }
}