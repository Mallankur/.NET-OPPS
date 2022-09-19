using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerChat_piolet_projet
{

    public class Program
    {
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor= ConsoleColor.White;
            Console.Clear();
            var stk = new stack();
            for (int i = 0; i < 500; i++)
            {
                stk.Push(i);

            }
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(stk.Pop());

            }
            Console.ReadLine();
          
        }

    }
}
