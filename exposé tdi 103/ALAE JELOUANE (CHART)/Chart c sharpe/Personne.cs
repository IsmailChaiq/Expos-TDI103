using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart_c_sharpe
{
    public class Personne
    {
        public string Nom;
        public char Sex;
        public int Age;


        public Personne() { }
        
        public Personne(string Nom,char Sex,int Age)
        {
            this.Nom = Nom;
            this.Sex = Sex;
            this.Age = Age;
        }
        public string nom { get => Nom; set => Nom = value; }
        public char sex { get => Sex; set => Sex = value; }
        public int age { get => Age; set => Age = value; }
    }
}
