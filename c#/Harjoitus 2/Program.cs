//Tee esimerkit while ja do-while -raklenteista. Pohjana voi käyttää aikaisemmin tehtyjä harjoituksia.
//Tee esimerkki myös taulukkomuuttujan
//määrittelystä ja käytöstä
//Kun valmiit, kopioi ohjelmaosuus Word-dokumentti (kaikki samaan) ja lähetä.






using Microsoft.VisualBasic;

public class hyviätehtäviä

{

    public static void Main()
    {
        //Annetaan alkuarvo i:lle 0
        int i = 0;
       //aloitetaan while loop. 
       //toistetaan kunnes ollaan suoritettu 4 kierros ja poistutaan
        while (i < 4)
        {
            //Tulostetaan tekstiä
            Console.WriteLine("Oppiminen on kivaa, jee!");
            //Kasvatetaan in arvoa yhdellä ja aloitetaan kierros uudestaan
            i++;
        }


        //alustetaan x arvolla 0
        int x = 0;
        //silmukka
        do
        {
            //tulostetaan tekstiä niin on
            Console.WriteLine("Niin on");
            //kasvatetaan x arvoa yhdellä
            x++;
        }
        //katotaan mikä on x arvo, ja alotetaan alusta jos arvo ei ole neljä. Poistutaan kun ollaan tulostettu 4krt
        while (x < 4);




        //Taulukkomuuttuja


        System.Console.WriteLine("Anna 5 nimeä, välilöynneillä eroteltuna");
        string[] taulukko = new string[5];

        for (int j = 0; j < 5; j++)
        {
            taulukko[j] = System.Console.ReadLine(); //Lukee rivin ja tallentaa sen taulukkoon
        }

       
        //Käydään taulukko läpi, siihen asti montako nimeä annettiin.
        foreach (string item in taulukko)
        {
            System.Console.WriteLine(item);  // Tulostaa jokaisen laatikon
        }
     














    }
}
