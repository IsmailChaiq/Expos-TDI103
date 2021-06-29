using System;
using System.Collections.Generic;
using System.Text;

namespace OVERRIDE
{
    class Directeur :Employee
    {
        private float  tauxprime;
        public Directeur(string nomcomplet, DateTime daterecrutement, float salaire)
            :base(nomcomplet, daterecrutement, salaire)
        {

            this.tauxprime = 0.1f;
        }
        //--------------------------------------------
        //redefinition , declaration override float
        //public override float calculersalaireannuel()
        //{
        //    return base.calculersalaireannuel() + base.salaire * (this.tauxprime * 12);
        //}
        ////------------------------------------------------------------



        public override string ToString()
        {
            return base.ToString() + " Taux prime est: " + this.tauxprime;
        }
    }
}
