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

            int enBuyuk = a;
            if (b > enBuyuk)
            {
                enBuyuk = b;
            }
            if (c > enBuyuk)
            {
                enBuyuk = c;
            }
            if (d > enBuyuk)
            {
                enBuyuk = d;
            }

            Console.WriteLine(enBuyuk);
        }
    }
}
