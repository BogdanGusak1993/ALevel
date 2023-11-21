namespace HW_3_1
{
    public class CustomList<T>
    {
        internal int _size;
        internal T[] _items;
        private static readonly T[] s_emptyArray = new T[0];
        public int Count => _size;

        public CustomList()
        {
            _items = s_emptyArray;
        }
        public CustomList<T> Sort()
        {
            return new CustomList<T>();
        }
        public void Add(T item)
        {
            T[] array = _items;

            int size = _size;

            _size = size + 1;

            array[size] = item;
        }
        public CustomList<T> SetDefaultAt()
        {
            return new CustomList<T>();
        }
    }
}