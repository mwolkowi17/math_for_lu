using System;

namespace math_for_lu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć Łucja");

            var rand = new Random();

            string [] wyniki = { };
            
            for(int c=0; c<20; c++)
            {
                double a = rand.NextDouble();
                double b = rand.NextDouble();
                a = Math.Round(a, 2);
                b = Math.Round(b, 2);
                
                string d = Convert.ToString(a);
                string e = Convert.ToString(b);
                Console.WriteLine(d + "*" + e+"=");
                double f = (a * b);
                string g = Convert.ToString(f);

                Array.Resize(ref wyniki, wyniki.Length + 1);
                wyniki[wyniki.GetUpperBound(0)] = g;

            }
            string haslo = "lucja";
            Console.WriteLine("Chcesz poznać wyniki - podaj hasło:");
            string haslo_read = Console.ReadLine();
            bool h = true;
            while (h == true) { 
            if (haslo_read == haslo)
            {
                for( int n = 0; n <= wyniki.Length-1; n++)
                {
                    Console.WriteLine(wyniki[n]);
                    
                };
                    h = false;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("zle hasło, sorry! podaj jeszcze raz:");
                haslo_read=Console.ReadLine();
            }
            }
        }
    }
}
