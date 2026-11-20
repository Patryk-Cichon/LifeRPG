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
        int suma = Sprawność + Inteligencja + Wiedza + Dyscyplina;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔═══════════════════════════════════════════════╗");
        Console.WriteLine("║              KARTA BOHATERA                   ║");
        Console.WriteLine("╠═══════════════════════════════════════════════╣");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"  Poziom: {Poziom}  {RysujPasek(suma % 100, 100)}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╠═══════════════════════════════════════════════╣");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"  [STR] Sprawność:    {Sprawność}   Godziny:{Sprawność/6} Minuty:{(Sprawność%6)*10}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"  [INT] Inteligencja: {Inteligencja}    Godziny:{Inteligencja/6} Minuty:{(Inteligencja%6)*10}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"  [WIE] Wiedza:       {Wiedza}  Godziny:{Wiedza/6} Minuty:{(Wiedza%6)*10}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"  [DYS] Dyscyplina:   {Dyscyplina}  Godziny:{Dyscyplina/6} Minuty:{(Dyscyplina%6)*10}");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╚═══════════════════════════════════════════════╝");
        Console.ResetColor();
        }
    
    private string RysujPasek(int aktualne, int cel)
    {
    int pelne = (aktualne * 10) / cel;
    if (pelne > 10) pelne = 10;
    if (pelne < 0) pelne = 0;

    int puste = 10 - pelne;
    return $"[{new string('█', pelne)}{new string('░', puste)}] {aktualne}/{cel}";
    }
    }

}