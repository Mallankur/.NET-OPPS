using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace oppes
{

    public class Text : Shape
    {
        public int FrontSize { get; set; }
        public string  FrontName  { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added link to url"+ url );
        }


    }
}
