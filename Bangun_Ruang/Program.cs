namespace Bangun_Ruang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kubus kubus = new Kubus();
            Balok balok = new Balok();
            Prisma prisma = new Prisma();
            Limas_Segitiga limas_segitiga = new Limas_Segitiga();

            Console.WriteLine("==== List Bangun Ruang ====");

            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Prisma");
            Console.WriteLine("4. Limas Segitiga");
            Console.WriteLine("5. Limas Segiempat");
            Console.WriteLine("6. Limas Segilima");
            Console.WriteLine("7. Limas Segienam");
            Console.WriteLine("8. Tabung");
            Console.WriteLine("9. Kerucut");
            Console.WriteLine("10. Bola");

            Console.Write("Pilih Bangun Ruang : ");
            double bangun_ruang = Convert.ToDouble(Console.ReadLine());

            if (bangun_ruang >= 11 )
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
                    case 3:
                        if (choose == "luas")
                        {
                            Console.Write("Masukkan ukuran Luas alas prisma : ");
                            double la = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran Keliling atas prisma : ");
                            double ka = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran tinggi prisma : ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            double luas = prisma.luas_prisma(la, ka, t);
                            Console.WriteLine($"Luas Prisma : {luas} cm");
                        } 
                        else if (choose == "volume")
                        {
                            Console.Write("Masukkan Ukuran Luas alas prisma : ");
                            double la = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran Tinggi prisma : ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            double volume = prisma.volume_prisma(la, t);
                            Console.WriteLine($"Volume Prisma : {volume} cm");
                        }

                        break;
                    case 4:
                        if (choose == "luas")
                        {
                            Console.Write("Masukkan ukuran alas segitiga : ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukkan ukuran tinggi segitiga : ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            double luas = limas_segitiga.luas(a, t);
                            Console.WriteLine($"Luas Limas Segitiga : {luas} cm");
                        }
                        else if(choose == "volume")
                        {

                        }
                        break;
                }
            }
           
        }
    }
}
