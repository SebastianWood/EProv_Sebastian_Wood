using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Sebastian_Wood
{
    class Program
    {
        static void Main(string[] args)
        {


            /*

            Console.WriteLine("Välj om du vill ha en pokemon eller en Jojo Stand från SuperHero Academy. 1 för pokemon och 2 för stand.");
            
            string val = Console.ReadLine();


            if (val = 1)
            {
            

            } Hann inte fixa klart om hur man väljer */

            Console.WriteLine("Välkommen till Superhero academy. Skriv gärna in ett namn på din hjälte. "); //uppmanar spelaren om vad man ska göra.

            Pokemon pokemon1 = new Pokemon(); //skapar från klass pokemon men som samtidigt arver från SuperHero klassen
            
            Console.WriteLine("Skriv in namn på din karaktär!"); //tilltalar att man ska skriva in namn på sin pokemon
            {
                pokemon1.namn = Console.ReadLine(); //här får man skriva in namn på sin pokemon som lagras under klassen som skapdes pokemon1
            };

            Console.WriteLine("" + pokemon1.namn + "."); //skriver ut namnet på pokemon.
            
            Console.WriteLine("Pokemonens ursprung: " + pokemon1.GetUrsprung() + "!"); //skriver ut pokemon ursprung

            Console.ReadLine();

        }
    }
}
