using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    class ClsEmployé
    {
        //private string num;
        private string nom;
        public string Nom { get => nom; set => nom = value; }
        //// public string Num { get => num; set => num = value; }
        // public string Nom 
        // {
        //     get => nom; set
        //     {
        //         foreach(char n in value)
        //         {
        //             if(char.IsLetter(n) ==true)
        //             {
        //                 nom = value;
        //             }
        //             throw new Exception("le nom doit contenir seulement des caractéres");
        //         }
        //     }

        // }
        // public ClsEmployé(string num, string nom)
        // {
        //     this.num = num;
        //     this.nom = nom;

        // }
        // public ClsEmployé() { }
        // public int recherche(string num)
        // {
        //     for (int i = 0; i < ClsListe.listeemployé.Count(); i++)
        //     {
        //         if (ClsListe.listeemployé[i].Nom == num)
        //         {
        //             return i;
        //         }
        //     }
        //     return -1;
        // }
        // public void ajoute(ClsEmployé emp)
        // {
        //     if (recherche(emp.Num) == -1)
        //     {
        //         ClsListe.listeemployé.Add(emp);
        //     }
        // }
        // public bool supprimer(string num)
        // {

        //     if (recherche(num) != -1)
        //     {
        //         ClsListe.listeemployé.RemoveAt(recherche(num));

        //     }
        //     return false;

        // }
    }
}
