using System;
using System.Collections.Generic;

namespace LifeRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imie swojego bohatera: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWitaj w świecie LifeRPG, {name}!\n");

            Statystyki statyGracza = MenedzerZapisu.Wczytaj();


            bool dziala = true;

            while (dziala)
            {
                // Wyświetlamy aktualne statystyki przed każdym wyborem
                Console.WriteLine("\n==============================");
                statyGracza.WyswietlStatystyki();
                Console.WriteLine("==============================\n");

                Console.WriteLine("Wybierz zadanie do wykonania:");
                Console.WriteLine("1. Trening siłowy (Sprawność)");
                Console.WriteLine("2. Nauka języka (Inteligencja)");
                Console.WriteLine("3. Programowanie C# (Wiedza)");
                Console.WriteLine("4. Porządki / Dyscyplina (Dyscyplina)");
                Console.WriteLine("Sprawdzenie statystyk - Wciśnij 'S'");
                Console.WriteLine("Z - Zapisz grę");
                Console.WriteLine("Inny klawisz - Wyjście z gry");
                Console.Write("\nTwój wybór: ");

                char x = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Przejście do nowej linii po wciśnięciu klawisza

                // Jeśli gracz wcisnął coś spoza zakresu 1-4, kończymy pętlę
                if (x != '1' && x != '2' && x != '3' && x != '4' && x != 'S' && x != 's'&& x!='z'&& x!='Z')
                {
                    Console.WriteLine("\nKoniec sesji. Do zobaczenia!");
                    dziala = false;
                    break;
                }
                
                Console.WriteLine("Jak długo wykonywałeś zadanie? (w minutach):");
                string czasWykonania = Console.ReadLine();
                int czas = Convert.ToInt32(czasWykonania);

                if (x == '1')
                {
                    int przyrost = czas / 10;
                    statyGracza.Sprawność += przyrost;
                    Console.WriteLine($"[+] Sprawność wzrosła o {przyrost} punktów!");
                }
                else if (x == '2')
                {
                    int przyrost = czas / 10;
                    statyGracza.Inteligencja += przyrost;
                    Console.WriteLine($"[+] Inteligencja wzrosła o {przyrost} punktów!");
                }
                else if (x == '3')
                {
                    int przyrost = czas / 10;
                    statyGracza.Wiedza += przyrost;
                    Console.WriteLine($"[+] Wiedza wzrosła o {przyrost} punktów!");
                }
                else if (x == '4')
                {
                    int przyrost = czas / 10;
                    statyGracza.Dyscyplina += przyrost;
                    Console.WriteLine($"[+] Dyscyplina wzrosła o {przyrost} punktów!");
                }
                else if (x == 'S' || x == 's')
                {
                    statyGracza.WyswietlStatystyki();
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                    Console.ReadKey();
                }
                else if (x == 'Z' || x == 'z')
                {
                    MenedzerZapisu.Zapisz(statyGracza);
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                    Console.ReadKey();
                }


                Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
                Console.Clear(); // Czyszci ekran przed kolejną iteracją pętli
            }
        }
    }
    
}