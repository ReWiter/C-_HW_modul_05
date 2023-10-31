namespace N1
{
    class Jornal
    {
        //public DateTime Year {get; set;}
        public string Name { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public int A { get; set; }

        public static Jornal operator +(Jornal jhs, int b)
        {
            return new Jornal { A = jhs.A + b };
        }
        public static Jornal operator -(Jornal jhs, int b)
        {
            return new Jornal { A = jhs.A - b };
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(Jornal jhs, int b)
        {
            return jhs.Equals(b);
        }
        public static bool operator !=(Jornal jhs, int b)
        {
            return !(jhs.A == b);
        }
        public static bool operator <(Jornal jhs, int b)
        {
            return jhs.A < b;
        }
        public static bool operator >(Jornal jhs, int b)
        {
            return jhs.A > b;
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            Jornal student = new Jornal();
            student.A = 1;
            //student.Year=DateTime(13,11,1964);
            student.Name = "Joe";
            student.Email = "adwa.com";
            student.Title = "ABABABA";
            student.Number = "13123411964";
            Console.WriteLine(student.A += 1);
            Console.WriteLine(student.A -= 1);
            Console.WriteLine(student.A > 1);
            Console.WriteLine(student.A < 1);
            Console.WriteLine(student.A != 1);
            Console.WriteLine(student.A == 1);
        }
    }
}
namespace N2
{
    class Store
    {
        public string Addres { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int A { get; set; }
        public static Store operator +(Store jhs, int b)
        {
            return new Store { A = jhs.A + b };
        }
        public static Store operator -(Store jhs, int b)
        {
            return new Store { A = jhs.A - b };
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static bool operator ==(Store jhs, int b)
        {
            return jhs.Equals(b);
        }
        public static bool operator !=(Store jhs, int b)
        {
            return !(jhs.A == b);
        }
        public static bool operator <(Store jhs, int b)
        {
            return jhs.A < b;
        }
        public static bool operator >(Store jhs, int b)
        {
            return jhs.A > b;
        }

    }
    class Prog
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Name = Console.ReadLine();
            store.Addres = Console.ReadLine();
            store.Title = Console.ReadLine();
            store.Number = Console.ReadLine();
            store.Email = Console.ReadLine();
            store.A = 123412;
            Console.WriteLine($"название магазина:{store.Name}");
            Console.WriteLine($"адрес:{store.Addres}");
            Console.WriteLine($"описание профиля магазина:{store.Title}");
            Console.WriteLine($"контактный телефон:{store.Number}");
            Console.WriteLine($"контактный e-mail:{store.Email}");
            Console.WriteLine($"S:{store.A}");
            Console.WriteLine(store.A += 12);
            Console.WriteLine(store.A -= 12);
            Console.WriteLine(store.A != 12);
            Console.WriteLine(store.A == 12);
            Console.WriteLine(store.A > 12);
            Console.WriteLine(store.A < 12);
        }
    }
}
namespace N3
{
    class Book
    {
        public string book { set; get; }
        public Book(string book)
        {
            this.book = book;
        }
        public static bool operator ==(Book obf, string a)
        {
            return obf.book == a;
        }
        public static bool operator !=(Book obf, string a)
        {
            return !(obf.book == a);
        }
    }
    class Booklist
    {
        Book[] arr;
        public Booklist(Book[] ar)
        {
            this.arr = ar;
        }
        public Book this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        public int llenght()
        {
            return arr.Length;
        }
        public static bool operator ==(Booklist booklist, string book)
        {
            return booklist.Equals(book);
        }
        public static bool operator !=(Booklist booklist, string book)
        {
            return !(booklist.Equals(book));
        }
        public void addd(ref Booklist book)
        {
            int a;
            var boo = new Book[this.arr.Length + book.llenght()];
            for (a = 0; a < arr.Length; a++)
            {
                boo[a] = arr[a];
            }
            for (int i = 0; i < book.llenght(); i++, a++)
            {
                boo[a] = book[i];
            }
            arr = boo;
        }

        public void deletee(ref Booklist book)
        {
            var booi = new Book[book.llenght() - 1];
            var a = "qqqq";
            int b = 0;
            for (int i = 0; i < book.llenght(); b++, i++)
            {
                if (book[i] == a)
                {
                    i++;
                    booi[b] = arr[i];
                }
                else
                {
                    booi[b] = arr[i];
                }
            }
            arr = booi;
        }
    }
    class prog
    {
        static void Main(string[] args)
        {
            var book = new Booklist(new[]
            {
            new Book("eeee"),
            new Book("qewqr"),
            new Book("qr"),
        });
            var book1 = new Booklist(new[]
{
            new Book("qqqq"),
            new Book("qr")
        });
            for (int i = 0; i < book.llenght(); i++)
            {
                Console.WriteLine(book[i].book);
            }
            var c = Console.ReadLine();
            Console.WriteLine("EQUALS");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(book[a] == c);
            Console.WriteLine("ADD");
            book.addd(ref book1);
            for (int i = 0; i < book.llenght(); i++)
            {
                Console.WriteLine(book[i].book);
            }
            Console.WriteLine("DELETE");
            book.deletee(ref book);
            for (int i = 0; i < book.llenght(); i++)
            {
                Console.WriteLine(book[i].book);
            }
        }
    }
}