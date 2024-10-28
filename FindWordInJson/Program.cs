using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FindWordInJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите имя файла для поиска");
            //string fileName = Console.ReadLine()?.ToLower();

            string fileName = "data.json";
            string searchTerm = "novel";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            var jsonData = File.ReadAllText(fileName);
            var books = JsonConvert.DeserializeObject<List<Book>>(jsonData);

            //Console.WriteLine("Введите слово для поиска (в заголовке или описании):");
            //string searchTerm = Console.ReadLine()?.ToLower();

            JsonSearch bookSearcher = new JsonSearch(books);
            var searchResults = bookSearcher.Search(searchTerm);

            // Вывод результатов
            if (searchResults.Count <= 0)
            {
                Console.WriteLine("Результаты не найдены.");
                return;
            }

            Console.WriteLine("Найденные результаты:");

            foreach (var book in searchResults)
            {
                Console.WriteLine($"ID: {book.Id}, Название: {book.Title}, Автор: {book.Author}, Описание: {book.Description}");
            }
        }
    }
}
