using System;

namespace ConsoleApp12
{
    class MyStack:IEnumerable
    {
        private int maxsize { get; set; } = 1000;
        private int _index;
        private object[] arr;

        public MyStack()
        {
            arr = new object[maxsize];
            _index = -1;
        }
        public bool IsEmpty()
        {
            return _index < 0;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("There is no element in stack");
            }

            object value = arr[_index];
            arr[_index] = null;
            _index--;
            return value;

        }
        public object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("There is no element in stack");

            }
            return arr[_index];
        }
        public void Push(object value)
        {
            if (_index >= maxsize - 1)
            {
                throw new Exception("Stac is Full");
            }
            else
            {
                _index++;
                arr[_index] = value;
            }
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                if (item != null)
                    Console.WriteLine(item);
            }
        }
 public IEnumerator GetEnumerator()
        {
            arr.GetEnumerator();
            foreach (var item in arr)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}
