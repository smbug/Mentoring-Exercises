using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearch.Tests
{
    [TestClass]
    public class BinarySearchSpecification
    {
        [TestMethod]
        public void Searching_An_Empty_Array_Returns_Null()
        {
            var emptyArray = new int[0];
            Assert.IsNull(ExecuteFind(emptyArray, 1));
        }

        [TestMethod]
        public void Searching_Single_Item_Array_Returns_Null()
        {
            var singleItemArray = new int[1] { 10 };
            Assert.IsNull(ExecuteFind(singleItemArray, 1));
        }

        [TestMethod]
        public void Searching_Single_Item_Array_Returns_Index()
        {
            var singleItemArray = new int[1] { 10 };
            Assert.AreEqual(ExecuteFind(singleItemArray, 10), 0);
        }

        [TestMethod]
        public void Searching_Even_Sized_Array_Returns_Null()
        {
            var evenArray = new int[4] { 72, 80, 84, 98 };
            Assert.IsNull(ExecuteFind(evenArray, 100));
        }

        [TestMethod]
        public void Searching_Even_Sized_Array_Returns_First_Index()
        {
            var evenArray = new int[4] { 72, 80, 84, 98 };
            Assert.AreEqual(ExecuteFind(evenArray, 72), 0);
        }

        [TestMethod]
        public void Searching_Even_Sized_Array_Returns_Last_Index()
        {
            var evenArray = new int[4] { 72, 80, 84, 98 };
            Assert.AreEqual(ExecuteFind(evenArray, 98), 3);
        }

        [TestMethod]
        public void Searching_Even_Sized_Array_Returns_Lower_Middle_Index()
        {
            var evenArray = new int[4] { 72, 80, 84, 98 };
            Assert.AreEqual(ExecuteFind(evenArray, 80), 1);
        }

        public void Searching_Even_Sized_Array_Returns_Upper_Middle_Index()
        {
            var evenArray = new int[4] { 72, 80, 84, 98 };
            Assert.AreEqual(ExecuteFind(evenArray, 84), 2);
        }

        [TestMethod]
        public void Searching_Odd_Sized_Array_Returns_Null()
        {
            var oddArray = new int[5] { 40, 46, 59, 67, 69 };
            Assert.IsNull(ExecuteFind(oddArray, 47));
        }

        [TestMethod]
        public void Searching_Odd_Sized_Array_Returns_First_Index()
        {
            var oddArray = new int[5] { 40, 46, 59, 67, 69 };
            Assert.AreEqual(ExecuteFind(oddArray, 40), 0);
        }

        [TestMethod]
        public void Searching_Odd_Sized_Array_Returns_Last_Index()
        {
            var oddArray = new int[5] { 40, 46, 59, 67, 69 };
            Assert.AreEqual(ExecuteFind(oddArray, 69), 4);
        }

        [TestMethod]
        public void Searching_Odd_Sized_Array_Returns_Middle_Index()
        {
            var oddArray = new int[5] { 40, 46, 59, 67, 69 };
            Assert.AreEqual(ExecuteFind(oddArray, 59), 2);
        }

        private int? ExecuteFind( int[] array, int value )
        {
            var searcher = new BinarySearch();
            return searcher.Find(array, value);
        }
    }
}
