public class ohjelma
{

    public static void Main()
    {
        decimal luku1, luku2, luku3, tulos;

        Console.WriteLine("Anna ensimmäinen luku ");
        luku1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Anna toinen luku ");
        luku2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Anna vähennettävä luku ");
        luku3 = Convert.ToInt16(Console.ReadLine());

        tulos = luku1 + luku2 - luku3;
        Console.WriteLine(tulos);




        if (luku1 > luku2)
        {
            Console.WriteLine("Suurin annettu luku oli: " + luku1); 
        }
        else if (luku1 < luku2)
        Console.WriteLine("Suurin annettu luku oli: " + luku2);
    }





    }
