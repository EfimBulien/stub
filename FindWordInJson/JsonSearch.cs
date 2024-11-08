using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindWordInJson
{
    public class JsonSearch
    {
        private List<Book> _data;
        public List<Book> Search(string searchTerm)
        {
            /*
            string fileName = "data.json";
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден");
                return null;
            }

            var jsonData = File.ReadAllText(fileName);
            _data = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            */

            TestDataObject testData = new TestDataObject();
            _data = testData.GetFiles();

            return _data.Where(b => b.Title.ToLower().Contains(searchTerm) || b.Description.ToLower().Contains(searchTerm)).ToList();
        }
    }
}