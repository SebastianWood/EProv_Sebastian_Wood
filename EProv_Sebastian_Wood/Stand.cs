using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Sebastian_Wood
{
    class Stand : SuperHero
    {


        public Stand()  //publika värden som kan användas i main. 
        {
            namn = "Za warudo"; //gjorde den här string arvet från pokemon som en ConsoleWriteline bara för att testa. 

            liv = 7; //arvs från klassen SuperHero och som kan användas inom main. 

            damage = 10;
        }



    }
}
