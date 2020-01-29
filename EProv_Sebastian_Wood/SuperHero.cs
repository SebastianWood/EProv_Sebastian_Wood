using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Sebastian_Wood
{
    class SuperHero
    {
        /*
        private string names = ""; //private string som returnas i metoden nedan så den kan användas i main
        public string TaNamn() //metod inom klass
        {
            return names; //returnerar names så att den kan användas
        }
        försökte fixa med private kod men hann inte längre än så. */

        public SuperHero() //publika värden som kan användas i main. 
        {
            string skrivInNamn = "Skriv in namn på din karaktär";

        }
        

        public int liv { get; set; } //är proporties och gör att man kan bästa hur värdena ska typ användas genom att sätta eller ta något. 
        public int damage { get; set; }
        public string namn;

        private string ursprung = "Jorden!";


        public string GetUrsprung()
        {

       
            return ursprung;

        }


    }
}
