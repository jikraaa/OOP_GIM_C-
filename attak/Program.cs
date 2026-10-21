// game
// Genre : Fighting
// karakter : nama,kesehatan

using System;
using System.Collections.Generic;
namespace KerangkaGame
{
    class Karakter
    {
        //public string  kesehatan, senjata;
        public int totalSenjata, power;
        public string nama { get; private set; } // enskapsulasi (pake parameter get set )bisa diakses di class tidak bisa diubah
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        // membuat constructor
        public Karakter(string nama, int kesehatan, int senjata, int tambahKesehatan)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
            this.kesehatan += tambahKesehatan;
        }

        public void Serang(Karakter target) // membuat method menyerang
        {
            Console.WriteLine("===> MULAI SERANGAN");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan 
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan}. Sisa kesehatan {kesehatan}");
        }

        public void Healing()
        {
            kesehatan += 20;
            Console.WriteLine($"{nama} heal HP,Kesehatan sekarang {kesehatan}");
        }

        //public int totalSenjata { get; private set; }
        //public int power { get; private set; }

        //public void setNama(string namaBaru, string kesehatanBaru, string senjataBaru, int jumlahSenjata, int kekuatan)
        //{
        //    this.nama = namaBaru; //this buat nunjuk variabel
        //    this.kesehatan = kesehatanBaru;
        //    this.senjata = senjataBaru;
        //    this.totalSenjata = jumlahSenjata;
        //    this.power = kekuatan;
        //}

        //public void getData()
        //{
        //    Console.WriteLine(nama);
        //    Console.WriteLine(kesehatan);
        //    Console.WriteLine(senjata);
        //    Console.WriteLine(totalSenjata);
        //    Console.WriteLine(power);
        //}

        public void getData()
        {
            Console.WriteLine($"Karakter : {nama}");
        }

    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("Jikra", 100, 10); //membuat objek (kalo udah ada constructor kita ga usah pake get data)
            Karakter musuh = new Karakter("jikro", 100, 100);

            //interaksi
            player1.Serang(musuh);
            musuh.Serang(player1);

            // kode sebelumnya 
            //Karakter karakter1 = new Karakter();
            //karakter1.nama = "Giant";
            //Console.WriteLine(karakter1.nama);

            //Karakter karakter2 = new Karakter();
            //karakter2.nama = "Goblin";
            //Console.WriteLine(karakter2.nama);

            //List<Karakter> daftaHero = new List<Karakter>(); // array menyimpan pahlawan
            //Karakter player1 = new Karakter();
            //player1.setNama("Archer","Sehat","Pedang", 3,99);
            ////player1.getData();

            //Karakter player2 = new Karakter();
            //player2.setNama("Artur","Kritis","Panah", 5,100);
            ////player2.getData();

            //// objek musuh
            //Karakter enemy = new Karakter();
            //enemy.setNama("Zombie", "Sedang", "Pisau", 2, 80);
            //enemy.getData();

            //Karakter enemy2 = new Karakter();
            //enemy.setNama("jikro", "Sedang", "Pistol", 3, 89);
            //enemy.getData();


            //daftaHero.Add(player1);
            //daftaHero.Add(player2);

            ////menampilkan data dari array, foreach
            //foreach(Karakter player in daftaHero)
            //{
            //    player.getData();
            //}



        }

    }
}