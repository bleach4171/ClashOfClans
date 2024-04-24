using System;

public class Trupp
{
    // Felder für die Truppinformationen
    private string Name;
    private int Level;
    private double Entwicklungskosten;
    private int Baukosten;
    private int Elixier;
    private int Trefferpunkte;
    private double Schaden;
    private int Bewegungsgeschwindigkeit;
    private int Angriffsgeschwindigkeit;
    private double Reichweite;
    private int Wohnraum;
    private int Einzel;

    // Konstruktor für Name, Level, Entwicklungskosten und Baukosten
    public Trupp(string name, int level, double entwicklungskosten, int baukosten)
    {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = 0;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Reichweite = 0;
        Wohnraum = 0;
        Einzel = 0;
    }

    // Konstruktor für Name, Level, Entwicklungskosten, Baukosten, Elixier und Reichweite
    public Trupp(string name, int level, double entwicklungskosten, int baukosten, int elixier, double reichweite)
    {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = elixier;
        Reichweite = reichweite;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Wohnraum = 0;
        Einzel = 0;
    }

    // Konstruktor für alle Felder
    public Trupp(string name, int level, double entwicklungskosten, int baukosten, int elixier, int trefferpunkte, double schaden, int bewegungsgeschwindigkeit, int angriffsgeschwindigkeit, double reichweite, int wohnraum, int einzel)
    {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = elixier;
        Trefferpunkte = trefferpunkte;
        Schaden = schaden;
        Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
        Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        Reichweite = reichweite;
        Wohnraum = wohnraum;
        Einzel = einzel;
    }

    // Konstruktor, der alles leer initialisiert
    public Trupp()
    {
        Name = "";
        Level = 0;
        Entwicklungskosten = 0;
        Baukosten = 0;
        Elixier = 0;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Reichweite = 0;
        Wohnraum = 0;
        Einzel = 0;
    }

    // Get- und Set-Methoden für alle Felder
    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public int GetLevel()
    {
        return Level;
    }

    public void SetLevel(int level)
    {
        Level = level;
    }

    public double GetEntwicklungskosten()
    {
        return Entwicklungskosten;
    }

    public void SetEntwicklungskosten(double entwicklungskosten)
    {
        Entwicklungskosten = entwicklungskosten;
    }

    public int GetBaukosten()
    {
        return Baukosten;
    }

    public void SetBaukosten(int baukosten)
    {
        Baukosten = baukosten;
    }

    public int GetElixier()
    {
        return Elixier;
    }

    public void SetElixier(int elixier)
    {
        Elixier = elixier;
    }

    public int GetTrefferpunkte()
    {
        return Trefferpunkte;
    }

    public void SetTrefferpunkte(int trefferpunkte)
    {
        Trefferpunkte = trefferpunkte;
    }

    public double GetSchaden()
    {
        return Schaden;
    }

    public void SetSchaden(double schaden)
    {
        Schaden = schaden;
    }

    public int GetBewegungsgeschwindigkeit()
    {
        return Bewegungsgeschwindigkeit;
    }

    public void SetBewegungsgeschwindigkeit(int bewegungsgeschwindigkeit)
    {
        Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
    }

    public int GetAngriffsgeschwindigkeit()
    {
        return Angriffsgeschwindigkeit;
    }

    public void SetAngriffsgeschwindigkeit(int angriffsgeschwindigkeit)
    {
        Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
    }

    public double GetReichweite()
    {
        return Reichweite;
    }

    public void SetReichweite(double reichweite)
    {
        Reichweite = reichweite;
    }

    public int GetWohnraum()
    {
        return Wohnraum;
    }

    public void SetWohnraum(int wohnraum)
    {
        Wohnraum = wohnraum;
    }

    public int GetEinzel()
    {
        return Einzel;
    }

    public void SetEinzel(int einzel)
    {
        Einzel = einzel;
    }
}

class Program
{
    static void Main()
    {
        // Konstruktor benutzen
        Trupp truppe = new Trupp("Bogenschützen", 6, 2000000, 50, 1, 44, 22, 24, 1, 3.5, 1, 0);

        // Set-Methoden
        truppe.SetName("Bogenschützen");
        truppe.SetLevel(6);
        truppe.SetEntwicklungskosten(2000000);
        truppe.SetElixier(1); // (0 = dunkles Elixier und 1 = normales Elixier)
        truppe.SetTrefferpunkte(44);
        truppe.SetSchaden(22);
        truppe.SetBewegungsgeschwindigkeit(24);
        truppe.SetAngriffsgeschwindigkeit(1);
        truppe.SetReichweite(3.5);
        truppe.SetWohnraum(1);
        truppe.SetEinzel(1); // (Schadensart 0 = mehrere Ziele, 1 = einzelne Ziele)

        // Ausgabe
        Console.WriteLine("Name: " + truppe.GetName() + '\n');
        Console.WriteLine("Level: " + truppe.GetLevel() + '\n');
        Console.WriteLine("Entwicklungskosten: " + truppe.GetEntwicklungskosten() + '\n');
        Console.WriteLine("Elixier (0 = dunkles Elixier und 1 = normales Elixier): " + truppe.GetElixier() + '\n');
        Console.WriteLine("Trefferpunkte: " + truppe.GetTrefferpunkte() + '\n');
        Console.WriteLine("Schaden: " + truppe.GetSchaden() + '\n');
        Console.WriteLine("Bewegungsgeschwindigkeit: " + truppe.GetBewegungsgeschwindigkeit() + '\n');
        Console.WriteLine("Angriffsgeschwindigkeit: " + truppe.GetAngriffsgeschwindigkeit() + '\n');
        Console.WriteLine("Reichweite: " + truppe.GetReichweite() + '\n');
        Console.WriteLine("Wohnraum: " + truppe.GetWohnraum() + '\n');
        Console.WriteLine("Einzel (Schadensart 0 = mehrere Ziele, 1 = einzelne Ziele): " + truppe.GetEinzel() + '\n');

        // Pause machen damit das Programm nicht automatisch schließt
        Console.ReadKey();
    }
}
