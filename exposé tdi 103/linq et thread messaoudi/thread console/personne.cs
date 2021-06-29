using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread2
{
    public class ExAge : Exception
    {
        public ExAge() : base(" --<( l'AGE ne doit pas être négatif !! )>--") { }
    }
    class personne
    {
        public string nom;
        public int age;

        public personne() { }

        public personne(string nom , int age)
        {
            this.nom = nom;
            if (age > 0)
            {
                this.age = age;
            }
            else
                throw new ExAge();

        }
    }
}
