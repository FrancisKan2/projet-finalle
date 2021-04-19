using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
   public class Cours
    {

        public string titre;
        public int numeroCours, code;
        public string Titre { get; set; }
        public int Code { get; set; }
        public int NumeroCours { get; set; }
        public Cours(int numeroCours, int code, string titre)
        {
            this.NumeroCours = numeroCours;
            this.Code = code;
            this.Titre = titre;
        }
        public string ToString()
        {
            return "  *Numero de cours: " + this.NumeroCours 
                + "  *Code: " + this.Code + 
                "  *Titre: " + this.Titre + "\n";
        }
    }
}
