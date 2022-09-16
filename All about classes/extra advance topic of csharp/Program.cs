using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace extra_advance_topic_of_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bk= new BookRepositary ().GetBooks();

            //LINQ Extension Methods
            try { 
               var binbook =bk.
                    Single(b=>b.Title == "Add.Net MVC+++ ");
                Console.WriteLine(binbook.Title);
            

            }
            catch (Exception)
            {

                Console.WriteLine ("Not Found");
            }


             
            Console.ReadLine();

        }
    }
   
}
