using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        enum Operation { None, Add, Subtract,Multiply, Divide};

        static void Main(string[] args)
        {
            bool exit_cond = false;

            while (!exit_cond)
            {
                Operation op = Operation.None;

                int a = 0;

                int b = 0;

                Console.Write("Input new calculation to be performed:\n");

                string input = Console.ReadLine();

                if (input == "exit")
                    exit_cond = true;

                if (!exit_cond && InputCheck(input))
                {

                    if (input.Contains("+") && CountChar(input, '+') == 1)
                    {
                        op = Operation.Add;
                    }
                    else if (input.Contains("-") && CountChar(input, '-') == 1)
                    {
                        op = Operation.Subtract;
                    }
                    else if (input.Contains("*") && CountChar(input, '*') == 1)
                    {
                        op = Operation.Multiply;
                    }
                    else if (input.Contains("/") && CountChar(input, '/') == 1)
                    {
                        op = Operation.Divide;
                    }
                    else
                    {
                        Console.WriteLine("Calculation contains invalid syntax.");
                        Console.WriteLine();
                    }

                    if (op != Operation.None)
                    {
                        switch (op)
                        {
                            case Operation.Add:
                                {
                                    a = Parser(input, '+', 0);
                                    b = Parser(input, '+', 1);

                                    Console.WriteLine("The answer is: " + Addition(a, b).ToString());
                                    Console.WriteLine();

                                    break;
                                }
                            case Operation.Subtract:
                                {
                                    a = Parser(input, '-', 0);
                                    b = Parser(input, '-', 1);

                                    Console.WriteLine("The answer is: " + Subtraction(a, b).ToString());
                                    Console.WriteLine();
                                    break;
                                }
                            case Operation.Multiply:
                                {
                                    a = Parser(input, '*', 0);
                                    b = Parser(input, '*', 1);

                                    Console.WriteLine("The answer is: " + Multiply(a, b).ToString());
                                    Console.WriteLine();
                                    break;
                                }
                            case Operation.Divide:
                                {
                                    a = Parser(input, '/', 0);
                                    b = Parser(input, '/', 1);

                                    Console.WriteLine("The answer is: " + Divide(a, b).ToString());
                                    Console.WriteLine();
                                    break;
                                }
                            case Operation.None:
                                {
                                    break;
                                }
                        }
                    }
                }

                if (exit_cond == true)
                {
                    Console.WriteLine("\nBye Bye!");
                    Console.ReadKey();
                }

            }
        }

        static bool InputCheck(string s)
        {
            char[] input_array = s.ToLower().Replace(" ", String.Empty).ToCharArray();

            for (int i = 0; i < input_array.Length; i++)
            {
                if (!((input_array[i] >= '0' && input_array[i] <= '9') || (input_array[i] == '+' || input_array[i] == '-' || input_array[i] == '*' || input_array[i] == '/')))
                {
                    Console.WriteLine("Invalid Character detected please reenter your calculation.");
                    Console.WriteLine();
                    return false;
                }

            }
            return true;
        }

        static int CountChar(string ss, char c)
        {
            int count = 0;

            foreach( char a in ss)
            {
                if(a == c)
                {
                    count++;
                }
            }

            return count;
        }

        static int Parser(string s, char c, int index)
        {
            string parse = s.Replace(" ", String.Empty).Split(c)[index];
            if (parse.Length != 0)
            {
                int i = Int32.Parse(parse);
                //Console.WriteLine(i.ToString());
                return i;
            }
            else
            {
                Console.WriteLine("Calculation must be in the format: a + b");
                return -1;
            }
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static float Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
    }
}
