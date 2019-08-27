using System;

namespace SimpleCrypto
{
    class Program
    {
        static public string enque(string s, string dup, int l, int cons)
        {
            for (int i = 0; i < l; i++)
            {
                int x = Convert.ToInt32(s[i]) + cons;
                int y = x + cons;
                char c = Convert.ToChar(x);
                Console.WriteLine(s[i] + "\t" + c);
                dup = dup + c;
            }
            Console.WriteLine("dup value is " + dup);
            return dup;
        }
        static public string deque(string s, string dup, int l, int cons)
        {
            for (int i = 0; i < l; i++)
            {
                int x = Convert.ToInt32(s[i]) - cons;
                char c = Convert.ToChar(x);
                Console.WriteLine(s[i] + "\t" + c);
                dup = dup + c;
            }

            return dup;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int[] x = new int[5] { 1,30,4,20,2};

            string s = "Hi How are you bro??";

            int cons = 10;
            int l = s.Length;
            string dup = null;//new string[l];

            string e = enque(s, dup, l, cons);

            Console.WriteLine("The encrypted string is: ");
            Console.WriteLine(e);

            string o = deque(e, dup, l, cons);

            Console.WriteLine("The original string is: ");

            Console.WriteLine(o);

            Console.Read();
        }
    }

}
