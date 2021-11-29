namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Salih");
            kisiler.Add("Derya");
            kisiler.Add("Alihan");
            Console.WriteLine(kisiler.Count);
            List<string> kisiler2 = new List<string>();
            kisiler2.Add("Salih");
            kisiler2.Add("Derya");
            kisiler2.Add("Alihan");
            kisiler2.Add("Emre");
            Console.WriteLine(kisiler2.Count);
        }
    }
    class MyList<T>
    {
        T[] _kisiler;
        T[] _tempKisiler;

        public MyList()
        {
            _kisiler = new T[0];
        }
        public void Add(T kisi)
        {
            _tempKisiler = _kisiler;
            _kisiler= new T[_kisiler.Length+1];
            for (int i = 0; i < _kisiler.Length; i++)
            {
                _kisiler[i] = _tempKisiler[i];
            }
            _kisiler[_kisiler.Length - 1] = kisi;
        }
        public int Count
        {
            get { return _kisiler.Length; }

        }

    }  
}