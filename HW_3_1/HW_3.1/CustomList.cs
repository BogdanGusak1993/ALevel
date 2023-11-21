using System.Collections;
using System.Collections.Immutable;
using System.Threading.Tasks.Dataflow;

namespace HW_3_1
{
    public class CustomList<T> : ICollection
    {
        private  T[] _items;
        public int Count { get; set; }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public CustomList() 
        {
            Count = 0;
            _items = new T[Count+1];   
        }

        public void Sort()
        {  
            Array.Sort(_items);
        }
        public void Add(T item)
        {
            Count++;
            T[] array = new T[Count];
            int index = 0;
            foreach (var part in _items)
            {
                array[index] = part;
                index++;
            }
            array[Count-1] = item;
            _items = array;  
        }
        public void SetDefaultAt(int index)
        {
           if (index >= 0 & Count > index)
            {
                Count--;
                _items = _items.Where((val, idx) => idx != index).ToArray();
            }
           
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public void ShowAsString() 
        {
            Console.WriteLine(String.Join(", ", _items));
        }
    }
}