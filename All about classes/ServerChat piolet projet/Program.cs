using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServerChat_piolet_projet
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            var stk= new Stack<int>(); // define a new stack
            stk.Push(1);
            stk.Push(2);
                stk.Push(3);
                 stk.Push(8);
                stk.Push(4);
            while (stk.Count>0)
            {
                Console.WriteLine(stk.Pop());
                //  print the stack count 
                Console.WriteLine("current stack is count is {0}",stk.Count);

            }

            // Peek() will return at the top of the without removing it 
           // Console.WriteLine(stk.Peek());


            


            // DictonariesDemo
            // Auto - car 












            Console.ReadLine();

        }

    }


}
