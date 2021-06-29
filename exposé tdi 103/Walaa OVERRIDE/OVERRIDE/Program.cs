using System;

namespace OVERRIDE
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------
            Directeur dr1 = new  Directeur("alaoui mohamed", new DateTime(2005, 05, 20), 1000);
            Employee emp = new Directeur("alaoui mohamed", new DateTime(2005, 05, 20), 1000);
            //dr1.calculersalaireannuel();
            //emp.calculersalaireannuel();
            Directeur dir = (Directeur)emp;
            ////methode calcule anneul employee
            //Console.WriteLine("Salaire annuel employee est:" + emp.calculersalaireannuel());

            ////surcharge de methode salaire annuel directeur+taux prime
            //Console.WriteLine("Salaire annuel dircteur est:" + dr1.calculersalaireannuel());


            //---------------
            Console.WriteLine(dr1.ToString());
        }
    }
}
