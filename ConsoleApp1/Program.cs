using System;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please include number:  ");
            int eded = Convert.ToInt32(Console.ReadLine());
            int num;
            int num1;
            int[] arr = new int[1000];
            int i = 0;
            
            if (eded < 50)

            {
                num = eded / 3;
                num1 = num * 3;
                
                while (num1 > 0)
                {
                    
                    arr[i] = num1;
                    num1 -= 3;
                    i++;
                    
                    
                }

                for (int j = 0; j < num; j++)

                {
                    
                    Console.Write(" " + arr[j] + " ");
                }
            }

            else if (eded > 50 && eded < 100)
            {
                
                num = eded / 5;
                num1 = num * 5;
                while (num1 > 0)
                {
                    
                    arr[i] = num1;
                    num1 -= 5;
                    i++;
                    
                }

                for (int j = 0; j < num; j++)
                {
                    
                    Console.Write(" " + arr[j] + " ");
                }

            }

            else if (eded > 100)
            {
                num = eded / 8;
                num1 = num * 8;
                
                while (num1 > 0)
                {
                    
                    arr[i] = num1;
                    num1 -= 8;
                    i++;
                    
                }

                for(int j = 0; j < num; j++)
                {
                    
                    Console.Write(" " + arr[j] + " ");
                }


            }

            else
            {
                Console.WriteLine("Please, include posetive or int type number");
            }
        }
    }
}
