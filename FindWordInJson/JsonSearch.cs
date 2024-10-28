using System.Collections.Generic;
using System.Linq;

namespace FindWordInJson
{
    public class JsonSearch
    {
        private readonly List<Book> _data;
        public JsonSearch(List<Book> data) => _data = data;
        public List<Book> Search(string searchTerm)
        {
            return _data.Where(b => b.Title.ToLower().Contains(searchTerm) || b.Description.ToLower().Contains(searchTerm)).ToList();
        }
    }
}