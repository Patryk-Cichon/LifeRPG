using System;
using System.IO;

namespace LifeRPG
{
    public class MenedzerZapisu
    {
        private static string ścieżkaPliku = "save.txt";
        public static void Zapisz(Statystyki staty)
        {
            try
            {
                string[] linie = 
                {
                    staty.Sprawność.ToString(),
                    staty.Inteligencja.ToString(),
                    staty.Wiedza.ToString(),
                    staty.Dyscyplina.ToString()
                };
            File.WriteAllLines(ścieżkaPliku, linie);
                Console.WriteLine("\n[System] Stan gry został pomyślnie zapisany!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Błąd zapisu]: {ex.Message}");
            }
        }
   public static Statystyki Wczytaj()
        {
            if (!File.Exists(ścieżkaPliku))
            {
                Console.WriteLine("\n[System] Nie znaleznio pliku zapisu. Tworzę nową postać.");
                return new Statystyki();
            }
            try
            {
                string[] linie = File.ReadAllLines(ścieżkaPliku);

                if (linie.Length >= 4)
                {
                    Statystyki staty = new Statystyki();
                    staty.Sprawność = Convert.ToInt32(linie[0]);
                    staty.Inteligencja = Convert.ToInt32(linie[1]);
                    staty.Wiedza = Convert.ToInt32(linie[2]);
                    staty.Dyscyplina = Convert.ToInt32(linie[3]);

                    Console.WriteLine("\n[System] Wczytano zapis gry pomyślnie!");
                    return staty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Błąd odczytu]: {ex.Message}");
            }

            return new Statystyki();
        }
    }
}