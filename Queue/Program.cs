internal class Program
{
    private static void Main(string[] args)
    {
        //Tanımlama
        var karakterKuyrugu = new Queue<string>();

        //eleman ekleme FIFO yöntemi uygulanır. Yani İlk giren İlk çıkar
        karakterKuyrugu.Enqueue("Şükrü");
        karakterKuyrugu.Enqueue("Selma");
        karakterKuyrugu.Enqueue("Betül");
        karakterKuyrugu.Enqueue("Bilge");

        //dolaşma
        foreach (var k in karakterKuyrugu)
            Console.WriteLine(k);
        Console.WriteLine("Eleman sayısı : " + karakterKuyrugu.Count);
        Console.WriteLine();

        //Diziye kopyalanıyor
        var karakterDizisi = karakterKuyrugu.ToArray();
        Console.WriteLine("Diziye kopyalandı");
        Console.WriteLine();

        //Çıkarma
        var s = karakterKuyrugu.Dequeue();
        Console.WriteLine("-> " + s + " çıkarıldı");
        foreach (var k in karakterKuyrugu)
            Console.WriteLine(k);
        Console.WriteLine("Eleman sayısı : " + karakterKuyrugu.Count);

        Console.WriteLine();

        //Çıkarma
        s = karakterKuyrugu.Dequeue();
        Console.WriteLine("-> " + s + " çıkarıldı");
        foreach (var k in karakterKuyrugu)
            Console.WriteLine(k);
        Console.WriteLine("Eleman sayısı : " + karakterKuyrugu.Count);

        Console.WriteLine();

        //Kuyruğu tamamen temizleme
        karakterKuyrugu.Clear();
        Console.WriteLine("Eleman sayısı : " + karakterKuyrugu.Count);
        Console.WriteLine("Elemanlar temizlendi");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-------------------");
        Console.WriteLine();

        Console.WriteLine("Diziye kopyalanan elemanlar");
        foreach (var d in karakterDizisi)
        {
            Console.WriteLine(d);
        }
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("--------------");
        Console.WriteLine("UYGULAMA");
        Console.WriteLine();

        var sesliHarfler = new List<char>()
        {
            'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö'
        };
        var kuyruk = new Queue<char>();

        ConsoleKeyInfo secim;

        foreach (char k in sesliHarfler)
        {
            Console.Write($"{k,5} kuyruğa eklensin mi? [e/h] : ");
            secim = Console.ReadKey();

            if (secim.Key == ConsoleKey.E)
            {
                kuyruk.Enqueue(k);
                Console.WriteLine($"\n{k,5} kuyruğa eklendi. Kuyruktaki eleman sayısı {kuyruk.Count} oldu.");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Kuyruktaki elemanlar:");
        foreach (char k in kuyruk) Console.WriteLine(k);
        Console.WriteLine();


        Console.Write("Kuyruktaki elemanları kaldırmak için Esc tuşuna basın. [Esc] : ");
        secim = Console.ReadKey();

        if (secim.Key == ConsoleKey.Escape)
        {
            Console.WriteLine();

            while (kuyruk.Count > 0)
            {
                Console.Write($"{kuyruk.Peek(), 5} kuyruktan çıkartılıyor ");
                for (int i = 0; i < 7; i++)
                {
                    Thread.Sleep(250);
                    Console.Write(". ");
                }
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Dequeue(), 5} kuyruktan çıkartıldı. Kuyrukta kalan eleman sayısı : {kuyruk.Count}");
            }
            Console.WriteLine("Kuyruktan çıkarma işlemi bitti. ");
        }
        Console.WriteLine();
        Console.WriteLine("Kuyrukta kalan eleman sayısı : " + kuyruk.Count);

    }
}