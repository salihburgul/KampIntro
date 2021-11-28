namespace Generics
{
    class Program
    {
        

        static void Main(string[] args)
        {//generic yapılarda parantez içine hani tipi verirsek onu çalştırır
            List<string> sehirler = new List<string>();
            //count property dir
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);//count property dir
            
            MyList<string> sehirler2= new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            

            
        }
        
        
    }
    class MyList<T> //generic class
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
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            //-1 kümenin son elemanı anlamı anlamına geliyor ve ona kadar ekliyor
            _array[_array.Length-1] = item;
        }
        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}