using MemoryList;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyMemoryListTest
{
    public class MyMemoryListTest
    { 
        [Theory]
        [InlineData (new int(), 1)]
        public void AddingElementShouldIncreaseLength(int item, int expected)
        {
            // arrange
            var list = new MyMemoryList<int>();

            // act
            list.Add(item);
            int actual = list.Length;

            // assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new char[] { 's', '4', 'r' }, 's', 2)]
        public void RemovingElementShouldDecreaseLength(char[] list, char item, int expected)
        {
            // arrange
            var memoryList = new MyMemoryList<char>();
            foreach (var element in list)
            {
                memoryList.Add(element);
            }

            // act
            memoryList.Remove(item);
            int actual = memoryList.Length;

            // assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData (new int[] { 7, 15, 8, 69, 42 }, 7, true)]
        [InlineData (new int[] { 10 }, 10, true)]
        [InlineData (new int[] { 0, 8, 69, 42 }, 7, false)]
        public void WasThisHereBefore(int[] list, int item, bool expected)
        {
            // arrange
            MyMemoryList<int> memoryList = new MyMemoryList<int>();
            foreach (var element in list)
            {
                memoryList.Add(element);
            }

            // act
            bool contained = memoryList.Contained(item);

            //assert
            Assert.Equal(expected, contained);
        }
    }
}
