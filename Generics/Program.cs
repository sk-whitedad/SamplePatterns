namespace GenericsApp
{
    class Programm
    {
        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>();
            Account<string> acc2 = new Account<string>();
            Account<int> acc3 = new Account<int>();
            acc1.Id = 45;
            acc2.Id = "45858";
            acc1.Sum = "50";
            int intId = (int)acc1.Id;
            string strId = (string)acc2.Id;
            Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>()
            {
                FromAcc = acc1,
                InAcc = acc3,
                Code = "4584"
            };

            Transaction<int, string> transaction2 = new Transaction<int, string>()
            {
                FromAcc = 77,
                InAcc = 88,
                Code = "4584"
            };

            Console.WriteLine($"acc1: {intId}   acc2: {strId}  sum: {acc1.Sum}");

            int x = 55;
            int y = 10;
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x= {x}  y= {y}");

            string s1 = "Hi";
            string s2 = "Bye";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1= {s1}  s2= {s2}");

        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    class Transaction<U, V>
    {
        public U FromAcc { get; set; }
        public U InAcc { get; set; }
        public V Code { get; set; }
    }

    class Account<T>
    {
        public T Id { get; set; }
        public string Sum { get; set; }
    }
}