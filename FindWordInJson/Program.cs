using System;

namespace FindWordInJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonSearch jsonSearch = new JsonSearch();
            string searchTerm = "test";
            //string searchTerm = "novel";
            var searchResults =  jsonSearch.Search(searchTerm);

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
