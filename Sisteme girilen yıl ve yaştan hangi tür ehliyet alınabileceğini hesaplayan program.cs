namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"yil" adında bir değişken oluşturun ve değerine bulunduğumuz yılı atayın,            
            //"dogumYili" adında bir değişken oluşturun, değerine doğum yılınızı atayın.
            //"yas" adında bir değişkende bu verilerle yaşınızı hesaplatın.
            //"yas" değişkenini ekrana yazdırın.



            int yil = 2023;
            int dogumYili = 2000;
            int yas = yil - dogumYili;
            Console.WriteLine(yas);

            if (yas >= 25)
            {
                Console.WriteLine("Kişi kamyon ehliyeti alabilir");
            }
            else if (yas >= 18)
            {
                Console.WriteLine("Kişi araba ehliyeti alabilir");
            }
            else if (yas >= 16)
            {
                Console.WriteLine("Kişi motor ehliyeti alabilir");
            }
            else
            {
                Console.WriteLine("Kişi ehliyet alamaz");
            }

            Console.WriteLine("Uygulama Bitti");
        }
    }
}