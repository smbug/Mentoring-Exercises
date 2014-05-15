using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearch.Tests
{
    [TestClass]
    public class BinarySearchSpecification
    {
        [TestMethod]
        public void Searching_an_empty_array_returns_null()
        {
            var emptyArray = new int[0];

            Assert.IsNull(ExecuteFind(emptyArray, 1));
        }

        private int? ExecuteFind( int[] array, int value )
        {
            var searcher = new BinarySearch();
            return searcher.Find(array, value);
        }
    }
}
