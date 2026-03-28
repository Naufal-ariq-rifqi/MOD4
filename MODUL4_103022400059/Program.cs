using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Kodepaket
{
    public enum Paket
    {
        Basic,Standard,Premium,Unlimited,Gaming,Streaming,Family,Business,Student,Traveler
    }
    public string GetKodePaket(Paket jenispaket)
    {
        string[] kodepaket = { "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210", };
        return kodepaket[(int)jenispaket];
    }
}

class program
{
    static void Main()
    {
        //Kodepaket kodepaket = new Kodepaket();
        //Console.WriteLine(kodepaket.GetKodePaket(Kodepaket.Paket.Student));
        MesinKopi kopi = new MesinKopi();
        kopi.Off();
        kopi.Brewing();
        kopi.Stanby();
        kopi.Maintenance();
        kopi.Standby2();
        kopi.Off2();
    }
}

public class MesinKopi
{
    private string state;

    public MesinKopi()
    {
        state = "OFF";
        Console.WriteLine("MESIN OFF");
    }

    public void Off()
    {
        if (state == "OFF")
        {
            state = "STANDBY";
            Console.WriteLine("Mesin Off berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void Brewing()
    {
        if (state == "STANDBY")
        {
            state = "BREWING";
            Console.WriteLine("Mesin Standby berubah menjadi Brewing");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void Stanby()
    {
        if (state == "BREWING")
        {
            state = "STANDBY";
            Console.WriteLine("Mesin Brewing berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void Maintenance()
    {
        if (state == "STANDBY")
        {
            state = "MAINTENANCE";
            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void Standby2()
    {
        if (state == "MAINTENANCE")
        {
            state = "STANDBY";
            Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }

    public void Off2()
    {
        if (state == "STANDBY")
        {
            state = "OFF";
            Console.WriteLine("Mesin Standby berubah menjadi OFF");
        }
        else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }
}