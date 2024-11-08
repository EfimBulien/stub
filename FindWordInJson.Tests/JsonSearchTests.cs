using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FindWordInJson.Tests
{
    [TestClass]
    public class JsonSearchTests
    {
        JsonSearch _jsonSearch;

        [TestInitialize]
        public void Setup()
        {
            _jsonSearch = new JsonSearch();
        }

        [TestMethod]
        public void SearchInJson_WithExistingTermInTitle_ReturnsMatchingBooks()
        {
            int expected = 6;
            string searchTerm = "test";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInJson_WithNonExistingTerm_ReturnsEmptyList()
        {
            int expected = 0;
            string searchTerm = "nonexistent";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.IsTrue(actual == expected, "Ожидался пустой список для несуществующего термина.");
        }

        [TestMethod]
        public void SearchInJson_WithEmptyTerm_ReturnsAllBooks()
        {
            int expected = 0;
            string searchTerm = "";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.AreNotEqual(expected, actual, "Ожидалось, что будут возвращены все книги для пустого термина поиска.");
        }

        [TestMethod]
        public void SearchInJson_WithExistingTermInAuthor_ReturnsMatchingBooks()
        {
            int expected = 0;
            string searchTerm = "test1";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.IsTrue(actual == expected, "Ожидался хотя бы один результат для существующего термина автора.");
        }

        [TestMethod]
        public void SearchInJson_WithPartialMatch_ReturnsMatchingBooks()
        {
            int expected = 0;
            string searchTerm = "test";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.IsFalse(actual == expected, "Ожидались некоторые результаты для частичного совпадения.");
        }
    }
}