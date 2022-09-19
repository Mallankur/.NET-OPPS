  using System;
using System.Threading;

namespace ServerChat_piolet_projet
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        


        public Post(string title, string description, DateTime created)
        {
            _title = title;
            _description = description;
            _created = created;
            
        }

        

        public void upvoting( )
        {
            var count = 0;
            var numcount= Int32.Parse(Console.ReadLine());             

            if (numcount > 0) Console.WriteLine("butten hit of upvoying ");
            else
            {
                Console.WriteLine("not voting ");
            }


            
            



        }
        public void downvote()
        {
            var count = 0;
            if (count < 0) Console.WriteLine("butten not hit ");
            else Console.WriteLine("not voting");

        }

    }
}
