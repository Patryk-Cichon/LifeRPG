namespace LifeRPG
{
    public class Zadanie
    {
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public int Liczba_XP { get; set; }
        public bool StatusWyk { get; set; } = false; // Domyślnie niewykonane

        public Zadanie(string nazwa, string kategoria, int liczba_XP)
        {
            Nazwa = nazwa;
            Kategoria = kategoria;
            Liczba_XP = liczba_XP;
        }

        public void WyswietlZadanie()
        {
            string statusTekst = StatusWyk ? "[UKOŃCZONE]" : "[DO ZROBIENIA]";
            Console.WriteLine($"{statusTekst} {Nazwa} (Kat: {Kategoria}) -> +{Liczba_XP} XP");
        }
    }
}