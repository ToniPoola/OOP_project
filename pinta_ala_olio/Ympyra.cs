using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace pinta_ala_olio
{
   
    class Ympyra: ILaskuri
    {
        private double lukuX, lukuY;
        public double Laskuri()
        {
            return Math.PI * Math.Pow(lukuY, 2); //palauttaa ympyrän pinta-alan
        } 
        public Ympyra() //konstruktori
        {
            lukuX = Math.PI;
            lukuY = 0;
        }
        public double Pii
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
        public double Sade
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
