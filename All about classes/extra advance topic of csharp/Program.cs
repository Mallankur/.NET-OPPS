using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace extra_advance_topic_of_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blha blha blha blha ...........";
            var shortendpost = post.Shorten(5);

        }
    }
   
}
