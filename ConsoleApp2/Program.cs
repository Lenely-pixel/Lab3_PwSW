
//using System;

//// Klasa reprezentująca pojedynczy kolor RGB
//class RGB
//{
//    // Prywatne pola dla składowych koloru
//    private int R_value;
//    private int G_value;
//    private int B_value;

//    // Konstruktor inicjalizujący wartości koloru
//    public RGB(int r, int g, int b)
//    {
//        R_value = r;
//        G_value = g;
//        B_value = b;
//    }

//    // Gettery i settery dla każdej składowej koloru
//    public int GetR() => R_value;
//    public void SetR(int r) => R_value = r;

//    public int GetG() => G_value;
//    public void SetG(int g) => G_value = g;

//    public int GetB() => B_value;
//    public void SetB(int b) => B_value = b;
//}

//// Klasa kontrolująca operacje na obiektach RGB
//class RGBController
//{
//    // Metoda inicjująca wartości koloru dla obiektu RGB
//    public void InitializeColor(RGB color, int r, int g, int b)
//    {
//        color.SetR(r);
//        color.SetG(g);
//        color.SetB(b);
//    }

//    // Metoda wyświetlająca składowe koloru RGB w formacie [R, G, B]
//    public void DisplayColor(RGB color)
//    {
//        Console.WriteLine($"[{color.GetR()}, {color.GetG()}, {color.GetB()}]");
//    }

//    // Metoda mieszająca dwa kolory RGB (średnia arytmetyczna składowych)
//    public RGB MixColors(RGB color1, RGB color2)
//    {
//        int mixedR = (color1.GetR() + color2.GetR()) / 2;
//        int mixedG = (color1.GetG() + color2.GetG()) / 2;
//        int mixedB = (color1.GetB() + color2.GetB()) / 2;

//        return new RGB(mixedR, mixedG, mixedB); // Zwrócenie nowego zmieszanego koloru
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Utworzenie obiektów kolorów
//        RGB color1 = new RGB(0, 0, 0);
//        RGB color2 = new RGB(0, 0, 0);

//        // Utworzenie obiektu kontrolera RGB
//        RGBController controller = new RGBController();

//        // Inicjalizacja kolorów przez użytkownika
//        controller.InitializeColor(color1, 255, 100, 50);
//        controller.InitializeColor(color2, 50, 150, 200);

//        // Wyświetlenie zainicjalizowanych kolorów
//        Console.Write("Kolor 1: ");
//        controller.DisplayColor(color1);

//        Console.Write("Kolor 2: ");
//        controller.DisplayColor(color2);

//        // Mieszanie dwóch kolorów
//        RGB mixedColor = controller.MixColors(color1, color2);

//        // Wyświetlenie koloru wynikowego
//        Console.Write("Kolor zmieszany: ");
//        controller.DisplayColor(mixedColor);
//    }
//}



//using System;
//using System.Collections.Generic;

//// Klasa reprezentująca studenta
//class Student
//{
//    // Prywatne pola przechowujące dane studenta
//    private string nr_indeksu;
//    private string imie;
//    private string nazwisko;
//    private int rok_st;
//    private List<double> oceny; // Lista ocen przypisanych studentowi

//    // Konstruktor inicjalizujący dane studenta
//    public Student(string indeks, string imie, string nazwisko, int rok)
//    {
//        this.nr_indeksu = indeks;
//        this.imie = imie;
//        this.nazwisko = nazwisko;
//        this.rok_st = rok;
//        this.oceny = new List<double>(); // Inicjalizacja pustej listy ocen
//    }

//    // Gettery i settery do odczytu i zapisu danych
//    public string NrIndeksu { get => nr_indeksu; set => nr_indeksu = value; }
//    public string Imie { get => imie; set => imie = value; }
//    public string Nazwisko { get => nazwisko; set => nazwisko = value; }
//    public int Rok { get => rok_st; set => rok_st = value; }
//    public List<double> Oceny { get => oceny; set => oceny = value; }

//    // Wyświetlanie informacji o studencie
//    public void Wyswietl()
//    {
//        Console.WriteLine($"{nr_indeksu} - {imie} {nazwisko}, Rok: {rok_st}, Oceny: {string.Join(", ", oceny)}");
//    }
//}

//// Klasa zarządzająca studentami i operacjami na ocenach
//class Uni
//{
//    private List<double> ListaDopuszczalnychOcen = new List<double> { 2, 3, 3.5, 4, 4.5, 5 };
//    private List<Student> ListaStudentow = new List<Student>(); // Lista studentów w systemie

//    // Metoda do dodawania nowego studenta i przypisywania mu ocen
//    public void dodajStudenta()
//    {
//        Console.Write("Numer indeksu: ");
//        string indeks = Console.ReadLine();

//        Console.Write("Imię: ");
//        string imie = Console.ReadLine();

//        Console.Write("Nazwisko: ");
//        string nazwisko = Console.ReadLine();

//        Console.Write("Rok studiów: ");
//        int rok = int.Parse(Console.ReadLine());

//        Student s = new Student(indeks, imie, nazwisko, rok);

//        Console.WriteLine("Wprowadź oceny (oddzielone spacją): ");
//        string[] dane = Console.ReadLine().Split(' ');

//        foreach (string oc in dane)
//        {
//            try
//            {
//                double ocena = double.Parse(oc);
//                // Sprawdzenie, czy ocena znajduje się na liście dopuszczalnych
//                if (ListaDopuszczalnychOcen.Contains(ocena))
//                {
//                    s.Oceny.Add(ocena);
//                }
//                else
//                {
//                    Console.WriteLine($"Ocena {ocena} jest niedozwolona!");
//                }
//            }
//            catch (FormatException)
//            {
//                // Obsługa błędu w przypadku nieprawidłowego formatu
//                Console.WriteLine($"Nieprawidłowy format: {oc}");
//            }
//        }

//        ListaStudentow.Add(s); // Dodanie studenta do listy
//    }

//    // Metoda do usuwania studenta na podstawie numeru indeksu
//    public void usunStudenta()
//    {
//        Console.Write("Podaj numer indeksu do usunięcia: ");
//        string indeks = Console.ReadLine();
//        ListaStudentow.RemoveAll(s => s.NrIndeksu == indeks);
//    }

//    // Obliczanie średniej ocen dla konkretnego studenta
//    public void obliczSrednia()
//    {
//        Console.Write("Podaj numer indeksu: ");
//        string indeks = Console.ReadLine();

//        Student s = ListaStudentow.Find(st => st.NrIndeksu == indeks);
//        if (s != null && s.Oceny.Count > 0)
//        {
//            double suma = 0;
//            foreach (var ocena in s.Oceny)
//            {
//                suma += ocena;
//            }
//            Console.WriteLine($"Średnia ocen studenta {s.Imie} {s.Nazwisko}: {suma / s.Oceny.Count:F2}");
//        }
//        else
//        {
//            Console.WriteLine("Nie znaleziono studenta lub brak ocen.");
//        }
//    }

//    // Obliczanie średniej ocen dla wszystkich studentów
//    public void obliczSredniaAll()
//    {
//        double suma = 0;
//        int licznik = 0;
//        foreach (var student in ListaStudentow)
//        {
//            foreach (var ocena in student.Oceny)
//            {
//                suma += ocena;
//                licznik++;
//            }
//        }

//        if (licznik > 0)
//        {
//            Console.WriteLine($"Średnia wszystkich ocen: {suma / licznik:F2}");
//        }
//        else
//        {
//            Console.WriteLine("Brak ocen w systemie.");
//        }
//    }

//    // Wyświetlenie wszystkich studentów w systemie
//    public void WyswietlStudentow()
//    {
//        foreach (var s in ListaStudentow)
//        {
//            s.Wyswietl();
//        }
//    }
//}

//// Główna klasa uruchamiająca program
//class Program
//{
//    static void Main()
//    {
//        Uni uczelnia = new Uni();

//        // Pętla menu programu
//        while (true)
//        {
//            Console.WriteLine("\n1. Dodaj studenta");
//            Console.WriteLine("2. Usuń studenta");
//            Console.WriteLine("3. Oblicz średnią studenta");
//            Console.WriteLine("4. Oblicz średnią wszystkich");
//            Console.WriteLine("5. Wyświetl studentów");
//            Console.WriteLine("0. Wyjście");
//            Console.Write("Wybierz opcję: ");

//            string wybor = Console.ReadLine();

//            switch (wybor)
//            {
//                case "1":
//                    uczelnia.dodajStudenta();
//                    break;
//                case "2":
//                    uczelnia.usunStudenta();
//                    break;
//                case "3":
//                    uczelnia.obliczSrednia();
//                    break;
//                case "4":
//                    uczelnia.obliczSredniaAll();
//                    break;
//                case "5":
//                    uczelnia.WyswietlStudentow();
//                    break;
//                case "0":
//                    return;
//                default:
//                    Console.WriteLine("Nieprawidłowa opcja!");
//                    break;
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;

// Klasa bazowa reprezentująca ogólny samochód
class Car
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rok { get; set; }

    public Car(string marka, string model, int rok)
    {
        Marka = marka;
        Model = model;
        Rok = rok;
    }

    // Wirtualna metoda do uruchomienia silnika
    public virtual void StartEngine()
    {
        
    }

    // Metoda wyświetlająca informacje o aucie
    public void ShowInfo()
    {
        Console.WriteLine($"{Marka} {Model}, {Rok}");
    }
}

// Klasa dziedzicząca reprezentująca samochód elektryczny
class ElectricCar : Car
{
    public ElectricCar(string marka, string model, int rok) : base(marka, model, rok) { }

    // Nadpisana metoda uruchamiania silnika
    public override void StartEngine()
    {
        Console.WriteLine("Cichy start silnika elektrycznego...");
    }
}

// Klasa dziedzicząca reprezentująca samochód spalinowy
class GasolineCar : Car
{
    public GasolineCar(string marka, string model, int rok) : base(marka, model, rok) { }

    // Nadpisana metoda uruchamiania silnika
    public override void StartEngine()
    {
        Console.WriteLine("Warkot silnika spalinowego...");
    }
}

class Program
{
    static void Main()
    {
        // Lista samochodów (typ bazowy, ale przechowuje różne obiekty)
        List<Car> cars = new List<Car>
        {
            new ElectricCar("Tesla", "Model 3", 2022),
            new GasolineCar("Toyota", "Corolla", 2018),
            new ElectricCar("Nissan", "Leaf", 2020),
            new GasolineCar("BMW", "M3", 2019)
        };

        // Przechodzimy przez listę i uruchamiamy silnik (polimorfizm!)
        foreach (var car in cars)
        {
            car.ShowInfo();
            car.StartEngine(); // Wywołuje odpowiednią metodę zależnie od typu obiektu
            Console.WriteLine();
        }
    }
}
