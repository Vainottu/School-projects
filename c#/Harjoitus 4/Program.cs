//Käytä try-catch -rakennetta virheestä toipumiseen siten, että alkuperäinen ohjelmakohta tulee kuitenkin toteutettua.
//Ts. esimerkissä käyttäjältä odotetaan kokonaislukua.
//Virheen jälkeen ei voida vain edetä ohjelmassa, vaan haluttu luku on saatava käyttäjältä

using System;

public class Ohjelma
{
    public static void Main()

    {
        int joku;
        bool oikein;
        oikein = false;
        //do while kunnes arvo on true, voidaan jatkaa ohjelmaa
        do
        {
            //pyydetään kokonaislukua
            Console.Write(" Anna kokonaisluku: ");
            
            try
            {
                joku = Convert.ToInt16(Console.ReadLine());
                oikein = true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitus: " + e.Message);
            }
            // Ohjelma voi jatkua
            
        }
        while (oikein != true);

        



        }
    } 
