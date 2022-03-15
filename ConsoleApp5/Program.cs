class Program
{
    private static int Hesapla()
    {
        Console.Write("Kisa kenari girin: ");
        int kk = Convert.ToInt32(Console.ReadLine());
        Console.Write("Uzun kenari girin: ");
        int uk=Convert.ToInt32(Console.ReadLine());
        int alan = uk * kk;
        return alan;
    }

    static void Main(string[] args)
    {
        int sonuc = Hesapla();
        Console.WriteLine("Alan= "+sonuc);
        Console.ReadKey();
    }
}