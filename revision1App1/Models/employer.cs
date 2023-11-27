using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision1App1
{
    internal class employer
    {  
        public string nom { get; set; }
        public string prenom { get; set; }
        public string matricule { get; set; }
        public int Id { get; internal set; }

        public employer()
        {

        }
        public employer( string nom, string prenom,string matricule)
        {
          
            this.nom = nom;
            this.prenom = prenom;
            
            this.matricule = matricule;
        }
        public override string ToString()
        {
            return "- nom: " + nom + "\n- prenom: " + prenom + "\n- matricule: " + matricule;

        }

        public virtual void Saisie()
        {
           
            Console.Write(" - nom: ");
            nom = Console.ReadLine();
            Console.Write(" - prenom: ");
            prenom = Console.ReadLine();
           
            Console.Write(" - Matricule: ");
            matricule = (Console.ReadLine());

        }
    }
}
