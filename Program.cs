using System;

namespace NamaSpace
{
    class Kelas
    {
        static void Main(string[]args)
        {
            // Buat list string baru untuk file baru teks yang akan dirutkan
            List<string> list = new List<string>();
        }
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
            Console.WriteLine("Jumlah baris = "+list.Capacity);
        }
    }
}