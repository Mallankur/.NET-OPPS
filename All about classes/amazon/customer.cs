using System.Collections.Generic;
using System;

namespace Amazon
{
    public class customer
    {

        public string Name { get; set; }
        public int Id { get; set; }





        public customer(string name, int id)
        {
            Name = name;
            Id = id;

        }
        public void prmoate()
        {
            Console.WriteLine("Promate logic changed ");


        }


    }
}
