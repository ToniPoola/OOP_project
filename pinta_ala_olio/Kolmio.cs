using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pinta_ala_olio
{
    
    class Kolmio: ILaskuri
    {
        private double lukuX, lukuY; 
        public double Laskuri() //metodi laskee annetut arvot
        {
            return lukuX * lukuY / 2; //palauttaa kolmion pinta-alan
        } 
        public Kolmio() //konstruktori
        {
            lukuX = 0;
            lukuY = 0;
           
        }
        public double Kanta
        {
            set
            {
               lukuX = value;
            }
            get
            {
                return lukuX;
            }
        }
        public double Korkeus
        {
            set
            {
                lukuY = value;
            }
            get
            {
                return lukuY;
            }
        }
    }
}
