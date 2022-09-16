using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public class person
        {
            private DateTime _birthdate;

            public void setbirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }
            public DateTime getbirtdate()
            {
                return _birthdate;
            }
        }

    }
}
