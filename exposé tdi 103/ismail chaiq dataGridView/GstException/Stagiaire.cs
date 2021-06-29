using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GstException
{
    class Stagiaire
    {
        private int num;
        private string nom;
        public Stagiaire(string num, string nom)
        {
            
            if (nom.Any(char.IsDigit))
            {
                throw new NumberOnNameException();
                //throw new NumberOnNameException(string.Format("Nom contient des chiffres ({0}) ", nom));
            }
            else if (nom.All(char.IsLetter) == false)
            {
                throw new SpecCharOnNameException();
            }
            else
            {
                this.nom = nom;
                this.num = int.Parse(num);
                    
            }
                
            
        }

        
    }
    class NomException : ApplicationException
    {
        public NomException(string Message): base("Erreur Nom  : "+ Message) { }

    }
    class NumberOnNameException : NomException
    {
        public NumberOnNameException() : base("Le nom contient des chiffres ") { }

    }
    class SpecCharOnNameException : NomException
    {
        public SpecCharOnNameException() : base("Le nom contient des charactères spéciaux") { }

    }
}
