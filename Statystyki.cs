namespace LifeRPG
{
    public class Statystyki
    {
        public int Sprawność { get; set; } = 1;
        public int Inteligencja { get; set; } = 1;
        public int Wiedza { get; set; } = 1;
        public int Dyscyplina { get; set; } = 1;

        public int Poziom {get; set;} = 1;


        public void WyswietlStatystyki()
        {
        Console.WriteLine($"Sprawność: {Sprawność}");
        Console.WriteLine($"Inteligencja: {Inteligencja}");
        Console.WriteLine($"Wiedza: {Wiedza}");
        Console.WriteLine($"Dyscyplina: {Dyscyplina}");
        Console.WriteLine($"Poziom: {Poziom}");
        }
    }

}