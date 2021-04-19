using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    public class Etudiant

    {

        public string nom, prenom;
        public int numeroEtudiant;
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumeroEtudiant { get; set; }
        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public string ToString()
        {
            return "  *Nom: " + this.Nom 
                + "   *Prenom: " + this.Prenom + 
                "  *NumeroEtudiant: " + this.NumeroEtudiant + "\n";
        }
    }
}
