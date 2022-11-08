//'Tee ohjelma, joka kysyy käyttäjältä 3 lukua.
//Kaksi ensimmäistä lasketaan yhteen ja jos kolmas luku on pienempi kuin kahden ensimäisen luvun summa,
//summasta vähennetään kolmas luku. Lopputulos ilmoitetaan käyttäjälle

public class kolmas

{

    public static void Main()

    {
        int eka;
        int toka;
        int kolmas;
        int summa;

        Console.WriteLine("Anna eka luku");
        eka = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Anna toka luku");
        toka = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Anna kolmas luku");
        kolmas = Convert.ToInt16(Console.ReadLine());

        summa = eka + toka;

        if (kolmas < summa);
        { 
            summa= summa - kolmas;
        }
        Console.WriteLine(summa);







    }

}


