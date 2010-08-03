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

            held held1 = new held();

            // So, und nun initialisieren wir auch alle Werte der Struktur:
            held1.initialsiereHelden();

            System.Console.WriteLine("----------ToStringSimple---------------");
            System.Console.WriteLine(held1.ToStringSimple());
            System.Console.WriteLine("----------------------------------------");
            
            System.Console.WriteLine("----------ToStringGeneric---------------");
            System.Console.WriteLine(held1.ToStringGeneric());
            System.Console.WriteLine("----------------------------------------");

            // Die Konsole so lange offen halten, bis man die
            // ENTER Taste drückt, sonst würde man die  
            // Ausgaben nicht sehen
            Console.ReadLine();
        }
    }
}




