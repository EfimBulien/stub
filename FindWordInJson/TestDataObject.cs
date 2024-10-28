using System.Collections.Generic;

namespace FindWordInJson
{
    public class TestDataObject
    {
        public List<Book> GetFiles()
        {
            List<Book> list = new List<Book> 
            {
                new Book(1, "test", "test", "test"),
                new Book(2, "test", "test", "test"),
                new Book(3, "test", "test", "test"),
                new Book(4, "test", "test", "test"),
                new Book(5, "test", "test", "test"),
                new Book(6, "test", "test", "test"),
            }; return list;
        }
    }
}
