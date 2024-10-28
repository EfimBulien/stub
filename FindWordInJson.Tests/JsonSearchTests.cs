using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FindWordInJson.Tests
{
    [TestClass]
    public class JsonSearchTests
    {
        List<Book> _testBooks;
        JsonSearch _jsonSearch;

        [TestInitialize]
        public void Setup()
        {
            TestDataObject testData = new TestDataObject();
            _testBooks = testData.GetFiles();
            _jsonSearch = new JsonSearch(_testBooks);
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
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInJson_WithEmptyTerm_ReturnsAllBooks()
        {
            int expected = _testBooks.Count;
            string searchTerm = "";
            var searchResults = _jsonSearch.Search(searchTerm.ToLower());
            int actual = searchResults.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}