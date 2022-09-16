using System;

namespace oppes
{
    public class person
    {
        public string Name  { get; set; }
        public string  username  { get; set; }
        public DateTime Birthdate { get;  private set; }
        public person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int age
        {
            get
            {
                var year = (DateTime.Now - Birthdate);
                Console.WriteLine(year);
                var cuurentage = year.Days / 365;
                Console.WriteLine(cuurentage);
                return cuurentage;
            }
        }

        
        


      

    }
}
