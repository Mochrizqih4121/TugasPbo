using System;
using System.Collections.Generic;
using HypeBeast;

namespace TokoGaruda71
{
    class Program
    {
        static void Main(string[] args)
        {
            var nikeAirMax = new NikeAirMax97("Nike Air Max 97", 2849000, "42");
            var nikeDunkPanda = new NikeDunkPanda("Nike Dunk Panda", 1499000, "43");
            var nikeDunkHighRetro = new NikeDunkHighRetro("Nike Dunk High Retro", 1859000, "44");
            var jordanFightMVP = new Offwhite("Nike Af1 Mid Pine Green C/0 off-white", 2960000, "41");
            var chuck70VintageCanvas = new Chuck70VintageCanvas("Chuck 70 Vintage Canvas", 1200000, "39");

            var Tokoku = new Toko("Toko Garuda - 71");
            Tokoku.TambahProduk(nikeAirMax);
            Tokoku.TambahProduk(nikeDunkPanda);
            Tokoku.TambahProduk(nikeDunkHighRetro);
            Tokoku.TambahProduk(jordanFightMVP);
            Tokoku.TambahProduk(chuck70VintageCanvas);

            Tokoku.TampilkanProduk();

            Console.Write("Pilih nomor produk yang ingin dibeli: ");
            int selectedIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("\n");

            if (selectedIndex >= 0 && selectedIndex < Tokoku.Products.Count)
            {
                var selectedProduct = Tokoku.Products[selectedIndex];
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Anda telah memilih produk berikut:");
                Console.WriteLine(new string('=', 60));
                selectedProduct.Informasi();
            }
            else
            {
                Console.WriteLine("Produk tidak valid.");
            }
        }
    }
}
