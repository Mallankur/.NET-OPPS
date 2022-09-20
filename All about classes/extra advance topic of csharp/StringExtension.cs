using System;

namespace extra_advance_topic_of_csharp
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberofWords)
        {
            if (numberofWords == 0)
                return "";
           var words=  str.Split(' ');
            if (words.Length < numberofWords)
                return str;

        }
    }
   
}
