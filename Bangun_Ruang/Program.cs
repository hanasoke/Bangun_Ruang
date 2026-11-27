namespace Bangun_Ruang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kubus kubus = new Kubus();
            Balok balok = new Balok();

            Console.WriteLine("==== List Bangun Ruang ====");

            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Prisma");
            Console.WriteLine("4. Limas");
            Console.WriteLine("5. Tabung");
            Console.WriteLine("6. Kerucut");
            Console.WriteLine("7. Bola");

            Console.Write("Pilih Bangun Ruang : ");
            double bangun_ruang = Convert.ToDouble(Console.ReadLine());

            if (bangun_ruang >= 8 )
            {
                Console.WriteLine("Silahkan pilih bangun ruang yang ada dilist");
            }
            else 
            {
                Console.Write("Mau Hitung Luas / Volume : ");
                string choose = Convert.ToString(Console.ReadLine());

                switch (bangun_ruang)
                {
                    case 1:
                        if (choose == "luas")
                        {
                            Console.Write("Masukkan ukuran rusuk kubus: ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            double luas = kubus.luas_kubus(r);
                            Console.WriteLine($"Luas Kubus : {luas} cm");
                        }
                        else if (choose == "volume")
                        {
                            Console.Write("Masukkan ukuran rusuk kubus : ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            double volume = kubus.volume_kubus(r);
                            Console.WriteLine($"Keliling Kubus : {volume} cm");
                        }

                        break;
                    case 2:
                        if (choose == "luas")
                        {
                            Console.Write("Masukkan ukuran panjang balok : ");
                            double p = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran lebar balok : ");
                            double l = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran tinggi balok : ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            double luas = balok.luas_balok(p, l, t);
                            Console.WriteLine($"Luas Balok : {luas} cm");
                        }
                        else if (choose == "volume")
                        {
                            Console.Write("Masukkan ukuran panjang balok : ");
                            double p = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran lebar balok : ");
                            double l = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran tinggi balok : ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            double volume = balok.volume_balok(p, l, t);
                            Console.WriteLine($"Volume Balok : {volume} cm");
                        }
                        break;
                }
            }
           
        }
    }
}
