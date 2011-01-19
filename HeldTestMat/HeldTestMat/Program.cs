using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using heldenStruktur;


namespace heldenGenerierung
{
    class heldenGenerierung
    {

        static void Main()
        {

            Held held1 = new Held();

            // So, und nun initialisieren wir auch alle Werte der Struktur:
            held1.initialsiereHelden();

            System.Console.WriteLine("----------ToStringSimple---------------");
            System.Console.WriteLine(held1.ToStringSimple());
            System.Console.WriteLine("----------------------------------------");
            
            System.Console.WriteLine("----------ToStringGeneric---------------");
            System.Console.WriteLine(held1.ToString());
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Hallo von Nicki");
            // Die Konsole so lange offen halten, bis man die
            // ENTER Taste drückt, sonst würde man die  
            // Ausgaben nicht sehen
            Console.ReadLine();
        }
    }
}




