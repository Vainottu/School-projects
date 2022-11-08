//  'Tee ohjelma, joka kysyy käyttäjältä 2 lukua. Ohjelma kertoo käyttäjällekumpi luvuista oli
//suurempi tai jos ne olivat yhtä suuria,
//kerrotaan myös siitä.



public class neljäs

{

    public static void Main()

    {
        int eka;
        int toka;

        Console.WriteLine("Anna ensimmäinen luku ");
        eka = System.Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Anna toinen luku ");
        toka = System.Convert.ToInt16(Console.ReadLine());


        if (eka > toka) 
        {
            Console.WriteLine("Ensimmäinen luku oli suurempi");
        }

        else if (eka < toka) 
        {
            Console.WriteLine("Toinen luku oli suurempi");
        }
        else
        {
            Console.WriteLine("Luvut olivat yhtäsuuret");
        }

    }
}




