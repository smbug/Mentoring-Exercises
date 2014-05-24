using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void Searching_Array_Where_Target_Less_Than_First_Val_Returns_Null()
        {
            var array = new int[15] { -50, 1, 8, 10, 12, 31, 32, 34, 69, 80, 84, 100, 121, 200, 211 };
            Assert.IsNull(ExecuteFind(array, -60));
        }

        [TestMethod]
        public void Searching_Array_Where_Target_Larger_Than_Last_Val_Returns_Null()
        {
            var array = new int[15] { -50, 1, 8, 10, 12, 31, 32, 34, 69, 80, 84, 100, 121, 200, 211 };
            Assert.IsNull(ExecuteFind(array, 800));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Searching_Unsorted_Array_Throws_Exception()
        {
            var array = new int[10] { 89, 60, 98, 8, 25, 400, 32, 230, 90, 91 };
            ExecuteFind(array, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Searching_Mostly_Sorted_Array_Throws_Exception()
        {
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 9 };
            ExecuteFind(array, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Searching_Null_Array_Throws_Exception()
        {
            ExecuteFind(null, 1);
        }

        private int? ExecuteFind( int[] array, int value )
        {
            var searcher = new BinarySearch();
            return searcher.Find(array, value);
        }
    }
}
