using System;

namespace oppes
{
    public class car : vehical
    {
        public car( string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine(registrationNumber);
        }
    }
}
