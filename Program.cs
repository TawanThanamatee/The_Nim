using System;

namespace The_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = 0, t2 = 0, t3 = 0;
            Console.Write("Input Tank1 : ");
            t1 = int.Parse(Console.ReadLine());
            Console.Write("Input Tank2 : ");
            t2 = int.Parse(Console.ReadLine());
            Console.Write("Input Tank3 ; ");
            t3 = int.Parse(Console.ReadLine());
            int A = 0, B = 0;

            bool isEnd = false;
            while (isEnd == false)
            {

                Console.WriteLine("Tank1 = {0},Tank2 = {1},Tank3 = {2}", t1, t2, t3);
                int t, b;
                if (t1 >= 0 || t2 >= 0 || t3 >= 0)
                {
                    Console.Write("Input Player : ");
                    string p = Console.ReadLine();
                    switch (p)
                    {
                        case "A":
                            Console.Write("Input Tank : ");
                            t = int.Parse(Console.ReadLine());
                            Console.Write("Input Box : ");
                            b = int.Parse(Console.ReadLine());
                            if (t >= 1 && t <= 3)
                            {
                                if (t == 1)
                                {
                                    if (b == 1)
                                    {
                                        if (t1 != 0)
                                        {
                                            t1 -= 1;                                         
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t1 != 1)
                                        {
                                            t1 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                else if (t == 2)
                                {
                                    if (b == 1)
                                    {
                                        if (t2 != 0)
                                        {
                                            t2 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t2 != 1)
                                        {
                                            t2 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                else if (t == 3)
                                {
                                    if (b == 1)
                                    {
                                        if (t3 != 0)
                                        {
                                            t3 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t3 != 1)
                                        {
                                            t3 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                if(t1 == 0 && t2 == 0 && t3 == 0)
                                {
                                    A++;
                                    isEnd = true;
                                }
                            }
                            else
                                Console.WriteLine("Please input tank try agian.");
                            break;
                        case "B":
                            Console.Write("Input Tank : ");
                            t = int.Parse(Console.ReadLine());
                            Console.Write("Input Box : ");
                            b = int.Parse(Console.ReadLine());
                            if (t >= 1 && t <= 3)
                            {
                                if (t == 1)
                                {
                                    if (b == 1)
                                    {
                                        if (t1 != 0)
                                        {
                                            t1 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t1 != 1)
                                        {
                                            t1 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                else if (t == 2)
                                {
                                    if (b == 1)
                                    {
                                        if (t2 != 0)
                                        {
                                            t2 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t2 != 1)
                                        {
                                            t2 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                else if (t == 3)
                                {
                                    if (b == 1)
                                    {
                                        if (t3 != 0)
                                        {
                                            t3 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Box empty.");
                                    }
                                    else if (b == 2)
                                    {
                                        if (t3 != 1)
                                        {
                                            t3 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Please input box try again.");
                                    }
                                    else
                                        Console.WriteLine("Please input box try again.");
                                }
                                if (t1 == 0 && t2 == 0 && t3 == 0)
                                {
                                    B++;
                                    isEnd = true;                                  
                                }
                            }
                            else
                                Console.WriteLine("Please input tank try agian.");
                            break;
                        default:
                            Console.WriteLine("Please input player try again.");
                            break;
                    }
                }
            }
            if (A > B)
            {
                Console.WriteLine("B Winner");
            }
            else if(B > A)
            {
                Console.WriteLine("A Winner");
            }
        }
    }
}
