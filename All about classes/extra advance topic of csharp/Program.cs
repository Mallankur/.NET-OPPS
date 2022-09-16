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
             var cheaperbook =
                from b in bk
                where b.Price <10
                orderby b.Title 
                select b;
            // writing same code using LINQ QUERY OPERATORS 

            // LINQ EXTENSION METHODS 
            // shorted by Where // .orderby /.select
            var cheapbooklst = bk
                                 .Where(b => b.Price < 100)
                                 .OrderBy(b => b.Title)
                                 .Select(b => b.Title);
           
           
            foreach (var book in cheapbooklst)
            {
                Console.WriteLine(book);
               // Console.WriteLine(book.Title + "   "+  book.Price);
            }
            Console.ReadLine();

        }
    }
   
}
