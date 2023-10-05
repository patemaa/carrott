namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir değişkendeki sayının pozitif mi, negatif mi ya da nötr mü olduğunu ekrana yazdıran kodu yazın.

            int sayi = 0;
            if (sayi > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Nötr");
            }
        }
    }
}