using System;
namespace inllämningsuppgift
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(störst(9,7));
          
            Console.WriteLine(störst(5,8));
           
            Console.WriteLine(störst(6,6));
        }
        static int störst(int tal1, int tal2)
        {
            if (tal1 == tal2)
            {
                return tal1;
            }
            else if (tal1 > tal2)
            {
                return tal1;
                
            }
            else
                return tal2;
        }
    }
}