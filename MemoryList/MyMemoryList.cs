using System;
using System.Collections.Generic;

namespace MemoryList
{
    public class MyMemoryList<T> where T: new()
    {
        private List<T> _list = new List<T>();

        private List<T> _oldList = new List<T>();

        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
        }
        

        public void Add(T item)
        {
            _list.Add(item);
            _oldList.Add(item);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public bool Contained(T item)
        {
            return _oldList.Contains(item);
        }



    }
}
