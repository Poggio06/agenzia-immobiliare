using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenzia_immobiliare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Immobile i = new Immobile();
            Console.WriteLine("inserire il codice");
            i.codice=Console.ReadLine();
            Console.WriteLine("inserire l'indirizzo");    
            i.indirizzo=Console.ReadLine();
            Console.WriteLine("inserire il cap");
            i.cap=Console.ReadLine();   
            Console.WriteLine("inserire la città");
            i.città=Console.ReadLine();
            Console.WriteLine("inserire la superficie");
            i.superficie=int.Parse(Console.ReadLine());
            Console.WriteLine("sciegliere il tipo di immobile: 1=box; 2=appartamenti; 3=ville");
            
            int TipoImmobile = int.Parse(Console.ReadLine());
            if (TipoImmobile == 1)
            {
                Box b = new Box();
                b.PostiAuto = int.Parse(Console.ReadLine());
                Console.WriteLine("l'immobile selezionato con codice:{0}, indirizzo:{1}, cap:{2}, città:{3} e superficie:{4} metri quadrati è un box con {5} posti auto", i.codice, i.indirizzo, i.cap, i.città, i.superficie, b.PostiAuto);
            }
            else if (TipoImmobile == 2)
            {
                Appartamenti a = new Appartamenti();
                a.NumeroVani = int.Parse(Console.ReadLine());
                a.NumeroBagni = int.Parse(Console.ReadLine());
                Console.WriteLine("l'immobile selezionato con codice:{0}, indirizzo:{1}, cap:{2}, città:{3} e superficie:{4} metri quadrati è un appartamento con {5} vani e {6} bagni", i.codice, i.indirizzo, i.cap, i.città, i.superficie, a.NumeroVani, a.NumeroBagni);
            }
            else if (TipoImmobile == 3)
            {
                Ville v = new Ville();
                v.giardino = int.Parse(Console.ReadLine());
                v.NumeroVani = int.Parse(Console.ReadLine());
                v.NumeroBagni= int.Parse(Console.ReadLine());
                Console.WriteLine("l'immobile selezionato con codice:{0}, indirizzo:{1}, cap:{2}, città:{3} e superficie:{4} metri quadrati è un appartamento con {5} vani e {6} bagni e giardino di {7} metri quadrati", i.codice, i.indirizzo, i.cap, i.città, i.superficie, v.NumeroVani, v.NumeroBagni,v.giardino);
            }
            else 
            {
                Console.WriteLine("selezione errata");
            }
            Console.ReadLine();


        }
    }
}
