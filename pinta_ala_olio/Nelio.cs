using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pinta_ala_olio
{

   
    class Nelio: ILaskuri
    {
        
        private double lukuX, lukuY;
        public double Laskuri()
        {
            return lukuX * lukuY; //palauttaa neliön pinta-alan
        } 
        public Nelio() //konstruktori
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
