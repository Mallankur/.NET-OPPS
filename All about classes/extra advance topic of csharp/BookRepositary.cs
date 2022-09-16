using System.Collections;
using System.Collections.Generic;

namespace extra_advance_topic_of_csharp
{
    public class BookRepositary
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Add.Net Step by step " ,Price = 15},
                new Book() {Title = "Add.Net MVC " ,Price = 79.99f},
                new Book() {Title = "Add.Net web API  " ,Price = 5},
                new Book() {Title = "Add.Net aDVANCE Topic  " ,Price = 12},
                new Book() {Title = "Add.Net Intermediate " ,Price = 7},
            };

        }

    }
   
}
