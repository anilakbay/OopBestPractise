﻿namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Muğla");
            sehirler.Add("Muğla");
            sehirler.Add("Muğla");

            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");
            sehirler2.Add("İzmir");

            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //generics class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
