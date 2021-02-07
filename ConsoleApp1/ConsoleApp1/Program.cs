using System;
using System.IO;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
    
        public static void zad1()
        {
            //zad 1
            //Stwórz prostą bazę numerów PESEL.Napisz funkcję, która pozwóli użytkownikowi sprawdzać czy dany PESEL znajduje się w spisie. Nr PESEL powinny być unikalne.
            //Jeśli podczas wyszukiwania trafi się więcej niż jedno trafienie, rzuć wyjątek aby administrator wiedział że musi sprawdzić zbiór.Jeśli nie ma żadnego dopasowania, zwróć null.
        }
        public static void zad2()
        {
            //zad2
            //Stwórz interfejs IZasilanie.Dodaj do niego metody Uruchom i ZwrocMoc. Stwórz klasy implementujące interfejs -Laptop i Mikrofalowka. 
            //W klasie Laptop, metoda Uruchom powinna wypisywać na ekran losowo słowa Netflix lub Steam lub Chrome a metoda
            //ZwrocMoc powinna zwracać liczbę 120.W Mikrofalówce, metoda Uruchom powinna wypisywać dzwięk PING!a metoda ZwrocMoc powinna zwracać 1500.
            //Stwórz dowolną kolekcję IZasilanie i dodaj do niej 2 Laptopy i 1 Mikrofalowke. 30 razy przeiteruj całą kolekcję. Dla
            //każdego elementu wywołaj metodę Uruchom i zsumuj zużytą energię. Przyjmij że jedna iteracja trwa 1 minutę(czyli laptop, który zużywa 120W, w minutę zużył 2W).
            //Wypisz ile energii zostało zużyte w ciągu tych 30 minut.
        }
        public static void zad3()
        {
            File.WriteAllText("tekst34.txt", File.ReadAllText("tekst23.txt"));
            File.WriteAllText("tekst34.bak", File.ReadAllText("tekst23.txt"));
            //zad3
            //Stwórz ręcznie plik tekstowy w folderze projektu.Napisz funkcję która wczyta ten plik i przepisze go do nowego pliku tekstowego z kopią zapasową z rozszerzeniem.bak.
        }
        static void Main(string[] args)
        {
            zad3();
        

            

            
        }
    }
}
