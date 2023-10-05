namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eğer değişkendeki sayı tek ise ekrana “Tektir” yazsın, değilse ekrana “Çifttir” yazsın.

            int sayi6 = 4;

            if (sayi6 % 2 == 0)
            {
                Console.WriteLine("Çifttir");
            }
            else if (sayi6 % 2 != 0)
            {
                Console.WriteLine("Tektir");
            }
        }
    }
}
