internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("siema elo");
        Console.WriteLine(Dodawanie());
        Console.WriteLine(Odejmowanie());
        Console.WriteLine(Mnozenie());

    }
    private static byte Dodawanie()
    {
        return 2 + 3;
    }

    private static int Odejmowanie()
    {
        return 2 - 3;
    }

    private static byte Mnozenie()
    {
        return 2 * 3;
    }
}