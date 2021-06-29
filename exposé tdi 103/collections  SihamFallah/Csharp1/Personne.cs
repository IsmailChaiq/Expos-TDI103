using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    class Personne
    {
        private string fname;
        private string lname;
        private int age;

       

        public Personne(string prenom, string nom, int age)
        {
            this.Fname = prenom;
            this.Lname = nom;
            this.Age = age;
        }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public int Age { get => age; set => age = value; }

    }
}
