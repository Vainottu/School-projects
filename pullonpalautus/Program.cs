
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Pullonpalautus
{



     static void Main()


    {
        
        int tölkit;
        Console.Write("Montako tölkkiä palautat? ");
        tölkit = Convert.ToInt32(Console.ReadLine());

        int pienetpullot;

        Console.Write("Montako pientä pulloa palautat? ");
        pienetpullot = Convert.ToInt32(Console.ReadLine());

        int isotpullot;
        Console.WriteLine("Montako isoa pulloa palautat? ");
        isotpullot = Convert.ToInt32(Console.ReadLine());

        double hinta = Convert.ToDouble((tölkit * 0.15) + (pienetpullot * 0.20) + (isotpullot * 0.40));

        Console.WriteLine("Palautuksesi summa on: " + hinta);

    }


    

}


