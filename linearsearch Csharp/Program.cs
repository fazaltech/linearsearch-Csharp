using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearsearch_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int  i, num, n, c = 0;
            int pos = 0;

            Console.WriteLine("Enter the array size : ");
            n= int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter Array Elements : ");
            for (i = 0; i < n; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Enter the number to be search : ");
            num= int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (arr[i] == num)
                {
                    c = 1;
                    pos = i + 1;
                    break;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Number not found..!!");
            }
            else
            {
                
                Console.WriteLine(num+" found at position "+pos);
            }
            Console.Read();

        }
    }
}
