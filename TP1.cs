
using System;

namespace TP1
{
    class Program
    {
         
         * 
         * Exo 1
         * 
         * private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        static void Main(string[] args)
        {


            var myParam = AskUserForParameter();
            Mulutiplication(myParam);
          
            




        }

        private static void Mulutiplication(int table)
        {
            int T1 = 0;

            
                for (int z = 1; z < 11; z++)
                {
                    T1 = z * table;

                    if (T1 % 2 == 1)
                    {
                        Console.WriteLine(table + "x" + z + "=" + T1);
                    }
                }

        }


        public static void OddResult(int table)
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = i * table;
                if (result % 2 == 1)
                {
                    string str = table.ToString() + " * " + i.ToString() + " = " + result.ToString();
                    Console.WriteLine(str);
                }
            }
        }

        public static void Prime()
        {
            // This function displays all prime number between 1 and 1000
            Console.WriteLine("2");
            for (int i = 3; i <= 1000; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static double Factorial(int nb)
        {
            if (nb == 0)
                return 1;
            return nb * Factorial(nb - 1);
        }

        public static double FibonacciFunction(int nb)
        {
            if (nb == 0 || nb == 1)
            {
                return 1;
            }
            return FibonacciFunction(nb - 2) + FibonacciFunction(nb - 1);
        }

        public static void Fibonacci()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            double fibo = FibonacciFunction(result);
            Console.WriteLine("F(" + result.ToString() + ") = " + fibo.ToString());
        }

        private static void PowerFunctionTryCatch(int x)
        {
            try
            {
                Console.WriteLine(10 / PowerFunction(x));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division By Zero");
            }
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        private static void Rectangle(int N, int M)
        {
            if (N >= 2)
            {
                string nRect = new string('-', N - 2);
                nRect = "0" + nRect + "0";
                Console.WriteLine(nRect);
                for (int i = 1; i < M - 1; i++)
                {
                    string mRect = new string(' ', N - 2);
                    mRect = "|" + mRect + "|";
                    Console.WriteLine(mRect);
                }
                if (M > 1)
                {
                    Console.WriteLine(nRect);
                }
            }
            else
            {
                Console.WriteLine("0");
                for (int i = 1; i < M - 1; i++)
                {
                    Console.WriteLine("|");
                }
                if (M > 1)
                {
                    Console.WriteLine("0");
                }
            }
        }

        private static void Rectangle2(int N, int M)
        {
            if (N >= 2)
            {
                string nRect = new string('-', N - 2);
                nRect = "0" + nRect + "0";
                Console.WriteLine(nRect);
                for (int i = 1; i < M - 1; i++)
                {
                    if (i % 3 == 1)
                    {
                        string mRect = "|";
                        for (int j = 1; j <= N - 2; j++)
                        {
                            if (j % 3 == 1)
                            {
                                mRect += "*";
                            }
                            else
                            {
                                mRect += " ";
                            }
                        }
                        mRect += "|";
                        Console.WriteLine(mRect);
                    }
                    else if (i % 3 == 2)
                    {
                        string mRect = "|";
                        for (int j = 1; j <= N - 2; j++)
                        {
                            if (j % 3 == 2)
                            {
                                mRect += "*";
                            }
                            else
                            {
                                mRect += " ";
                            }
                        }
                        mRect += "|";
                        Console.WriteLine(mRect);
                    }
                    else
                    {
                        string mRect = "|";
                        for (int j = 1; j <= N - 2; j++)
                        {
                            if (j % 3 == 0)
                            {
                                mRect += "*";
                            }
                            else
                            {
                                mRect += " ";
                            }
                        }
                        mRect += "|";
                        Console.WriteLine(mRect);
                    }
                }
                if (M > 1)
                {
                    Console.WriteLine(nRect);
                }
            }
            else
            {
                Console.WriteLine("0");
                for (int i = 1; i < M - 1; i++)
                {
                    Console.WriteLine("|");
                }
                if (M > 1)
                {
                    Console.WriteLine("0");
                }
            }
    }


