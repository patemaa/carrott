namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 300;
            int c = 110;
            int d = 2342;

            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c)
            {
                Console.WriteLine(d);
            }
        }
    }
}
