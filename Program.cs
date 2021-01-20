using System;
using System.Collections.Generic;
using System.IO;

namespace NamaSpace
{
    class Kelas
    {
        static void Main(string[]args)
        {
            // Buat list string baru untuk file baru teks yang akan dirutkan
            List<string> list = new List<string>();

            // Panggil metode membaca file teks, tentukan lokasi text dan nama file
            // Perhatikan double slashnya sebagai pemisah folder
            baca("E:\\2021\\KST\\NameSorter\\namesorter\\unsorted-names-list.txt", list);

            // Panggil metode mengurutkan nama pada baris list
            urutkanLast(list);
        }


        // METODE UNTUK MEMBACA FILE TEXT PADA DIREKTORI PROJEK
        protected static void baca(string path, List<string> list)
        {
            string line;

            try
            {
                // Lewatkan parameter path dan nama file
                StreamReader sr = new StreamReader(path);
                // Baca baris pertama teks pada file
                line = sr.ReadLine();
                // Lanjut baca sampai EOF (end of file)
                while (line != null)
                {
                    // Cetak baris pada konsol / terminal
                    Console.WriteLine(line);

                    // Tambahkan baris ke list untuk menambah elemen list
                    // yang nantinya untuk dibuatkan file baru
                    list.Add(line);

                    // Baca baris berikutnya
                    line = sr.ReadLine();
                }
                
                // Tutup file text yang telah dibaca
                sr.Close();

                Console.ReadLine();
            }
            // Eksepsi jika ada error
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            // Eksekusi final yaitu menampilkan jumlah baris pada teks yg telah dibaca
            finally
            {
                // (Opsional) jika ingin mengecek apakah kapasitas list
                // sesuai jumlah baris pada text file
                Console.WriteLine("Jumlah baris = "+list.Capacity);
            }
        }


        // METODE MENGURUTKAN LIST<STRING>
        // PARAMETER List<string> l UNTUK VARIABEL LIST
        // YANG AKAN DIURUTKAN
        private static void urutkanLast(List<string> l)
        {
            Console.WriteLine("Urutkan nama terakhir:");
            System.Console.WriteLine();

            // Jika kapasitas list tidak = 0 berarti file tidak kosong
            if (l.Capacity != 0)
            {
                // Urutkan
                l.Sort(
                    // n1 yaitu parameter elemen list
                    // n2 untuk parameter elemen list lain (berikutnya)
                    (n1, n2) => 
                    // split/pecah elemen list pertama menjadi array berdasar spasi
                    // bandingkan dengan elemen list kedua yang juga displit 
                    // menjadi array berdasar spasi
                    n1.Split(" ")[1].CompareTo(
                        n2.Split(" ")[1]
                    )
                );
                // Cetak ke konsol list baru yang sudah diurutkan diatas
                // dan gabungkan tiap elemen list yang diakhiri \n (new line)
                Console.WriteLine(string.Join(",\n", l));
            } else
            // jika list kosong maka tidak meneruskan operasi pengurutan
            {
                System.Console.WriteLine("List kosong");
            }
        }
    }
}