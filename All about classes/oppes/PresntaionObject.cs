using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace oppes
{

    public class PresntaionObject
    {
        public int Width { get; set; }
        public int height  { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copyed to clipboard ");
        }
        public void Duplicate()
        {
            Console.WriteLine("object duplicate to clipboard ");
        }


    }
}
