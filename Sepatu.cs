using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypeBeast
{
    public interface Produk
    {
        string Nama { get; set; }
        double Harga { get; set; }
        void Informasi();
    }
    public abstract class NikeOffWhite : Produk
    {
        public string Nama { get; set; }
        public double Harga { get; set; }

    public NikeOffWhite(string nama, double harga)
    {
        Nama = nama;
        Harga = harga;
    }

    public abstract void Informasi();
    }

    public class NikeAirMax97 : NikeOffWhite
    {
        public string Ukuran { get; set; }

        public NikeAirMax97(string nama, double harga, string ukuran) : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        public override void Informasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Ukuran: {Ukuran}");
        }
    }

    public class NikeDunkPanda : NikeOffWhite
    {
        public string Ukuran { get; set; }

        public NikeDunkPanda(string nama, double harga, string ukuran) : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        public override void Informasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Ukuran: {Ukuran}");
        }
    }

    public class NikeDunkHighRetro : NikeOffWhite
    {
        public string Ukuran { get; set; }

        public NikeDunkHighRetro(string nama, double harga, string ukuran) : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        public override void Informasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Ukuran: {Ukuran}");
        }
    }

    public class Offwhite : NikeOffWhite
    {
        public string Ukuran { get; set; }

        public Offwhite(string nama, double harga, string ukuran) : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        public override void Informasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Ukuran: {Ukuran}");
        }
    }

    public class Chuck70VintageCanvas : NikeOffWhite
    {
        public string Ukuran { get; set; }

        public Chuck70VintageCanvas(string nama, double harga, string ukuran) : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        public override void Informasi()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Ukuran: {Ukuran}");
        }
    }

    public class Toko
    {
        public string Nama { get; set; }
        public List<NikeOffWhite> Products { get; set; }

        public Toko(string nama)
        {
            Nama = nama;
            Products = new List<NikeOffWhite>();
        }

        public void TambahProduk(NikeOffWhite product)
        {
            Products.Add(product);
        }

        public void TambahProduk(NikeAirMax97 product)
        {
            Products.Add(product);
        }

        public void TambahProduk(NikeDunkPanda product)
        {
            Products.Add(product);
        }

        public void TambahProduk(NikeDunkHighRetro product)
        {
            Products.Add(product);
        }

        public void TambahProduk(Offwhite product)
        {
            Products.Add(product);
        }

        public void TambahProduk(Chuck70VintageCanvas product)
        {
            Products.Add(product);
        }

        public void TampilkanProduk()
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"Daftar Produk di {Nama}:");
            Console.WriteLine(new string('=', 60));
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Products[i].Nama} (Rp {Products[i].Harga:N0})");
            }
        }
    }
}
