using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Sebastian_Wood
{
    class Pokemon : SuperHero
    {

        public Pokemon()  //publika värden som kan användas i main. 
        {
            namn = ""; //gjorde den här string arvet från pokemon som en ConsoleWriteline bara för att testa. 

            liv = 10; //arvs från klassen pokemon och som kan användas inom main. 

            damage = 5;

            

        }

        public void PrintInfo()
        {

            
            Console.WriteLine(GetUrsprung()); //hämtar ursprung
        }

    }
}
