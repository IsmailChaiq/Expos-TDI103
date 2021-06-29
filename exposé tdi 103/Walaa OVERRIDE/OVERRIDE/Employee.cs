using System;
using System.Collections.Generic;
using System.Text;

namespace OVERRIDE
{
    class Employee
    {
        public string nomcomplet;
        public DateTime daterecrutement;
        public float salaire;

        public Employee(string nomcomplet, DateTime daterecrutement, float salaire)
        {
            this.nomcomplet = nomcomplet;
            this.daterecrutement = daterecrutement;
            this.salaire = salaire;
        }
        //public virtual float calculersalaireannuel()
        //{
        //    return this.salaire * 12;
        //}





        public override string ToString()
        {
            return "Nom complet : " + this.nomcomplet;
        }


    }
}
