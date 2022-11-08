
//Jatka edellistä ”Harjoituksia’”-kohtaa. Tee esimerkkejä kaikista. Käännä ensimmäisi harjoituksia toiselle kielelle.

//Tee ohjelma, joka kirjoittaa annetun merkkijonon käänteisessä järjestyksessä
//(esim. annettu ”sana” -> tuloksena ”anas”) Toteuta ohjelma ilman valmisfunktioita,
//poislukien Len-funktio. Tee käyttöliittymään kaksi tekstilaatikkoa, joissa merkkijonot näkyvät


using System.Runtime.InteropServices;

public class tehtava
{
    public static void Main()

    {
        //Määritellään talukkoa
        string[] taulukko = new string[5];

        //Kysytään jotain sanaa 
        Console.WriteLine("Anna viisi  sanaa");

        //taulukko käydään läpi ja luetaan rivit
        for (int i = 0; i < taulukko.Length; i++)
        {
            taulukko[i] = Console.ReadLine();
        }
    
        Array.Reverse(taulukko);

        foreach (string item in taulukko)
        {
            Console.WriteLine(item);
        }
    }
}






