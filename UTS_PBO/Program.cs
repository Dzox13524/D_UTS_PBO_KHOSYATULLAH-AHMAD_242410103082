
public class Db
{
    private string NIM;
    private string Nama;
    private string Jurusan;
    private string data;
    private List<string> ListNim = new List<string>();
    private List<string> ListNama = new List<string>();
    private List<string> listJurusan = new List<string>();

    public Db()
    {
    }

    public string _NIM
    {
        get { return NIM; }
        set { this.NIM = value; }
    }
    public string _Nama
    {
        get { return Nama; }
        set { this.Nama = value; }
    }
    public string _Jurusan
    {
        get { return Jurusan; }
        set { this.Jurusan = value; }
    }

    public void TambahData(string NIM, string Nama, string Jurusan)
    {
        this.NIM = NIM;
        this.Nama = Nama;
        this.Jurusan = Jurusan;
    }
    public void updateData(string nim)
    {
        if (ListNim.Count == 0)
        {
            Console.WriteLine("Data tidak ada");
        }
        else if (cekNim(nim))
        {
            for (var i = 0; i < ListNim.Count; i++)
            {
                if (nim == ListNim[i])
                {
                    Console.WriteLine("===Ubah data===");
                    Console.Write("Masukkan Nama Baru: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Masukkan Jurusan Baru:");
                    string jurusan = Console.ReadLine();
                    ListNama[i] = nama;
                    listJurusan[i] = jurusan;
                    Console.Clear();
                    Console.WriteLine("Data Berhasil Diubah!");
                }
            }
        } else
        {
            Console.WriteLine("Data tidak ada");
        }
    }
    public void deleteData(string nim)
    {
        if (ListNim.Count == 0)
        {
            Console.WriteLine("Data tidak ada");
        }
        else if (cekNim(nim))
        {
            for (var i = 0; i < ListNim.Count; i++)
            {
                if (nim == ListNim[i])
                {
                    ListNama.Remove(ListNama[i]);
                    ListNim.Remove(ListNim[i]);
                    listJurusan.Remove(listJurusan[i]);
                    Console.Clear();
                    Console.WriteLine("Data Berhasil Dihapus!");
                }
            }
        }
        else
        {
            Console.WriteLine("Data tidak ada");
        }
    }
    public void dataMahasiswa()
    {
        if (ListNim.Count == 0)
        {
            Console.WriteLine("Data tidak ada");
        } else
        {
            for (var i = 0; i < ListNim.Count; i++)
            {
                Console.WriteLine($"Nama: {ListNama[i]}");
                Console.WriteLine($"Nim: {ListNim[i]}");
                Console.WriteLine($"Jurusan: {listJurusan[i]}");
                Console.WriteLine($"==========================");
            }
        }
    }
    public bool cekNim(string NIM)
    {
        var hasil = true;
        if (ListNim.Count > 0)
        {
            for (var i = 0; i > ListNim.Count; i++)
            {
                if (ListNim[i] == NIM)
                {
                    hasil = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        else
        {
            return false;
        }
        return hasil;
    }

}

class Program
{
    static void Main()
    {
        bool keluar = false;

        while (!keluar)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Update Data");
            Console.WriteLine("3. Hapus Data");
            Console.WriteLine("4. Lihat Data");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih menu (1-5): ");
            Db database = new Db();
            string pilih = Console.ReadLine();

            switch (pilih)
            {
                case "1":
                    Console.Write("Masukkan NIM: ");
                    string nimTambah = Console.ReadLine();
                    Console.Write("Masukkan Nama: ");
                    string namaTambah = Console.ReadLine();
                    Console.Write("Masukkan Jurusan: ");
                    string jurusanTambah = Console.ReadLine();
                    database.TambahData("3082", "ahmad", "informatika");
                    break;
                case "2":
                    Console.Write("Masukkan NIM yang ingin diubah: ");
                    string nimUpdate = Console.ReadLine();
                    database.updateData(nimUpdate);
                    break;
                case "3":
                    Console.Write("Masukkan NIM yang ingin dihapus: ");
                    string nimHapus = Console.ReadLine();
                    database.deleteData(nimHapus);
                    break;
                case "4":
                    Console.WriteLine("Data Mahasiswa:");
                    database.dataMahasiswa();
                    Console.WriteLine("Tekan Enter untuk melanjutkan...");
                    Console.ReadLine();
                    break;
                case "5":
                    keluar = true;
                    Console.WriteLine("Keluar dari program.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih lagi.");
                    break;
            }

            if (!keluar)
            {
                Console.WriteLine("Tekan Enter untuk melanjutkan...");
                Console.ReadLine();
            }
        }
    }
}
