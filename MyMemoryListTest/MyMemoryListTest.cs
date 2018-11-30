using MemoryList;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyMemoryListTest
{
    public class MyMemoryListTest<T> where T: new()
    {
        [Fact]
        public void Test()
        {
            var sut = new MyMemoryList();
        }

        [Theory]
        [InlineData (new int(), 1)]
        public void AddingElementShouldIncreaseLength(T item, int expected)
        {
            // arrange
            var list = new MyMemoryList();

            // act
            list.Add(item);
            int actual = list.Length;

            // assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new char[] { 's', '4', 'r' }, 's', 3)]
        public void RemovingElementShouldDecreaseLength(char[] list, T item, int expected)
        {
            // arrange
            var memoryList = new MyMemoryList();
            foreach (var element in list)
            {
                memoryList.Add(element);
            }

            // act
            list.Remove(item);
            int actual = list.Length;

            // assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData (new int[] { 7, 15, 8, 69, 42 }, 7, true)]
        [InlineData (new int[] { 10 }, 10, true)]
        [InlineData (new int[] { 0, 8, 69, 42 }, 7, true)]
        public void WasThisHereBefore(int[] list, T item, bool expected)
        {
            // arrange
            list.Remove(item);

            // act
            bool contained = list.Contained(item);

            //assert
            Assert.Equal(expected, contained);
        }
    }
}
