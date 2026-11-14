Console.Write("Podaj imie swe: ");
string name = Console.ReadLine();
Console.WriteLine("Nice to meet you, " + name + "!");

int liczba_hp = 100;
int poziom = 1;

Console.WriteLine("Your starting HP is: " + liczba_hp);
Console.WriteLine("Your starting level is: " + poziom);

Console.WriteLine("Otrzymałeś 25 obrażeń");
liczba_hp = liczba_hp - 150;

Console.WriteLine("Nowa liczba hp" + liczba_hp);
poziom = poziom + 1;
Console.WriteLine("Nowy poziom" + poziom);

if ( liczba_hp <= 0)
{
    Console.WriteLine("nie zyjesz koniec gry");
}
else
{
    Console.WriteLine("Masz sie dobrze " + liczba_hp + " HP.");
}