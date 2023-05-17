using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int valik;
        Console.WriteLine("Vali meetod (1-3):");
        valik = int.Parse(Console.ReadLine());

        if (valik == 1)
        {
            Meetod1();
        }
        else if (valik == 2)
        {
            Meetod2();
        }
        else if (valik == 3)
        {
            Meetod3();
        }
        else
        {
            Console.WriteLine("Vigane valik!");
        }
    }

    static void Meetod1()
    {
        // Esimene meetod - faili loomine desktopile
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "fail.txt");
        File.Create(filePath).Close();
        Console.WriteLine("Fail loodud desktopile.");
    }

    static void Meetod2()
    {
        // Teine meetod - faili loomine koos sisuga
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "fail.txt");
        string sisu = "See on faili sisu, mida olen kirjutanud.";
        File.WriteAllText(filePath, sisu);
        Console.WriteLine("Fail loodud desktopile sisuga.");
    }

    static void Meetod3()
    {
        // Kolmas meetod - faili loomine ja vale URL-i sisestamine
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "fail.txt");
        string valeURL = "fail1://urli/mida/ei/eksisteeri";
        File.WriteAllText(filePath, valeURL);
        Console.WriteLine("Fail loodud desktopile vale URL-iga.");
    }
}

