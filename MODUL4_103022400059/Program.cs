using System;

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
        Kodepaket kodepaket = new Kodepaket();
        Console.WriteLine(kodepaket.GetKodePaket(Kodepaket.Paket.Student));
    }
}

