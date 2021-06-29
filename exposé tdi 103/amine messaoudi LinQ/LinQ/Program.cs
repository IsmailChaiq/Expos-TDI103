using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ

{
    class etudiant
    {
        public string nom;        
        public string ville;
        public int niveau;

    }

    
    
    class Program
    {
        static void Main(string[] args)
        {

            etudiant[] listetudiant =
            {
                new etudiant(){ nom ="messaoudi ",ville="casablanca",niveau=1},
                new etudiant(){ nom="allam",ville="fes",niveau=3},
                new etudiant(){ nom="jelouane ",ville="meknes",niveau=2},
                new etudiant(){ nom="filahi",ville="casablanca",niveau=4},
                new etudiant(){ nom="elasri",ville="rabat",niveau=4 },
                new etudiant(){ nom="alaoui",ville="fes",niveau=4 },

            };





            



            List<string> liste = new List<string>()
            {
                "clé","maison","route","balon","programme","developpeur",
                "pc","key","portable","telephone","book"
            };

            //List<string> liste1 = new List<string>()
            //{
            //    "aa","bb","cc","dd"
            //};

            //-------------avec la methode for -----------------


            //List<string> resultat = new List<string>();
            //for (int i = 0; i < liste.Count; i++)
            //{
            //    if (liste[i].Length > 5)
            //    {
            //        resultat.Add(liste[i]);
            //    }
            //}
            //foreach (var a in resultat)
            //{
            //    Console.WriteLine(a);
            //}



            //---------------------------------
            // ----LA METHODE LINQ----------


            // ----query syntax--

            //var resultat = from x in liste
            //               where x.Length > 5
            //               select x;

            //foreach (var a in resultat)
            //{
            //    Console.WriteLine(a);
            //}


            // ---non query syntaxe --/ LAMBDA

            //var resultat = liste.Where(x => x.Length > 5);

            //foreach (var a in resultat)
            //{
            //    Console.WriteLine(a);
            //}
            // 


            //var resultat = liste.FindAll(x => x.Length > 5);   // aavec FINDALL()
            //foreach (var a in resultat)
            //{
            //    Console.WriteLine(a);
            //}










            //------------ LINQ TO OBJECTT--------------

            // ----TRIER UNE LISTE---
            //query syntax

            //var resultat = from x in listetudiant
            //               orderby x.niveau descending
            //               select x;
            //foreach (var x in resultat)
            //{
            //    Console.WriteLine("niveau={0} , nom={1} , ville={2}", x.niveau, x.nom, x.ville);
            //}




            // non queryy syntax / LAMNBDA

            //var resultat = listetudiant.OrderByDescending(x => x.niveau);

            //foreach (var x in resultat)
            //{
            //    Console.WriteLine("niveau={0} , nom={1} , ville={2}", x.niveau, x.nom, x.ville);
            //}




            //----TRIER AVEC DEUX CONDITION ----

            // ---query syntax----

            //var resultat = from x in listetudiant
            //               orderby x.niveau , x.nom ascending
            //               select x;

            //foreach (var x in resultat)
            //{
            //    Console.WriteLine("niveau={0} , nom={1} , ville={2}", x.niveau, x.nom, x.ville);

            //}

            // Non query syntax / LAMBDA

            //var resultat = listetudiant.OrderBy(x => x.niveau).ThenByDescending(x => x.nom);

            //foreach (var x in resultat)
            //{
            //    Console.WriteLine("niveau={0} , nom={1} , ville={2}", x.niveau, x.nom, x.ville);

            //}



            // REGROUPEMENT-----GROUP BY

            // query syntax--
            //var resultat = from x in listetudiant
            //               group x by x.ville;
            //foreach (var x in resultat)
            //{
            //    Console.WriteLine("\n\nville=" + x.Key);
            //    Console.WriteLine("*******************");
            //    foreach (var y in x)
            //    {
            //        Console.WriteLine("niveau={0} , nom={1} , ville={2}", y.niveau, y.nom, y.ville);

            //    }
            //}


            //LAMBDA---- -
           //var resultat = listetudiant.GroupBy(x => x.ville);

           // foreach (var x in resultat)
           // {
           //     Console.WriteLine("\n\nville=" + x.Key);
           //     Console.WriteLine("*******************");
           //     foreach (var y in x)
           //     {
           //         Console.WriteLine("niveau={0} , nom={1} , ville={2}", y.niveau, y.nom, y.ville);

           //     }
           // }


            ////----JOINDRE DEUX CLASS-- ( JOIN )--
            //var resultat = liste.Zip(liste1, (first, second) => first + " " + second);
            //foreach (var x in resultat)
            //{
            //    Console.WriteLine(x);

            //}



            Console.ReadLine();





            // dans windows form ----
            //private void btnAfficher_Click(object sender, EventArgs e)
            //{
            //    var resultat = from etd in listetudiant
            //                   join flr in listefiliere
            //                   on etd.IDF1 equals flr.IdFiliere1
            //                   select new { nom = etd.Nom, prenom = etd.Prenom, filiere = flr.NomFiliere1 };
            //    //Select etd;

            //    dataGridView1.DataSource = resultat.ToList();
            //}

        }   
        

    }
}
