namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan istenen vize ve final notu ile,
            //öğrencinin geçip geçmediğini hesaplayan programın kodunu yazın.

            //Vize: _
            //Final: _

            //Öğrencinin geçme notu hesaplanır.
            //Bunun için vizenin % 40’ı, finalin % 60’ı toplanır. (vize * 0.4)

            //Not: X

            //Öğrencinin geçip geçmediğini ekrana yazdırın.
            //Geçme notu en az 50 ve final notu en az 60 olmak zorundadır.

            Console.Write("Vize: ");
            double vize = double.Parse(Console.ReadLine());

            Console.Write("Final: ");
            double final = double.Parse(Console.ReadLine());

            double gecmeNotu = (vize * 0.4) + (final * 0.6);

            Console.WriteLine("Not: " + gecmeNotu);

            if (gecmeNotu >= 50 && final >= 60)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }
        }
    }
}
