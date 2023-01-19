
public class ohjelma
{

    public static void Main()


    {
        
       decimal sypv, sykk, syvv;
        decimal a, y, m, d, tulos;
        int apu;


        Console.WriteLine("Anna syntymapäiväsi: ");
        sypv = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Anna syntymä kuukautesi: ");
        sykk = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Anna syntymävuotesi");
        syvv = Convert.ToDecimal(Console.ReadLine());


         a = ((14 - sykk) / 12);
        y = syvv - a;
        m = sykk + (12 * a) - 2;

        d = sypv + y + (y / 4) + (y / 100) + (y / 400) + ((31 * m) / 12);

        tulos = d % 7;
        apu = Convert.ToInt32(tulos);

        if (apu == 0)
        {
            Console.WriteLine("sunnuntai");
        }
        else if (apu == 1)
        {
            Console.WriteLine("Maanantai");
        }
        else if (apu ==2)
        {
            Console.WriteLine("Tiistai");
        }
        else if (apu == 3)
        {
            Console.WriteLine("Keskiviikko");
        }
        else if (apu == 4)
        {
            Console.WriteLine("Torstai");
        }
        else if (apu == 5)
        {
            Console.WriteLine("Perjantai");
        }
        else if (apu == 6)
        {
            Console.WriteLine("Lauantai");
        }








    }
}

