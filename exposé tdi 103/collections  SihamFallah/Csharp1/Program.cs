using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {


            ////-------------------declaration d'un tableau en C sharp -------------------
            int[] T = new int[3];
            T[0] = 1;
            T[1] = 222;
            T[2] = 5;

            //for (int i = 0; i < T.Length; i++)
            //{
            //    Console.WriteLine(T[i]);
            //}

            //foreach (int x in T)
            //{
            //    Console.WriteLine(x);

            //}
            //Console.WriteLine("********************************");
            //string[] t = new string[] { "aaaa", "bbbbbb", "ddddd" };
            //t[2] = "alaoui";
            //foreach (string x in t)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("********************************");

            //int[] TV = new int[3];    // taille 3 element sans declaration de  valeurs 

            //Console.WriteLine(TV[0]);// affiche 0  
            //Console.WriteLine(TV[1]); // affiche 0
            //Console.WriteLine(TV[2]); // affiche 0

            //string[,] t = new string[2, 3]; // declaration tableau de deux dimension 
            //t[0, 0] = "wwwww";
            //t[0, 1] = "vvvvv";
            //t[0, 2] = "xxxxx";
            //Console.WriteLine(t[0, 0] + " " + t[0, 1] + " " + t[0,2] );



            //-------------------declaration d'une liste en C sharp -------------------


            //List<int> L = new List<int> { };
            //L.Add(2);
            //L.Add(19);
            //L.Add(3);


            //for (int i = 0; i < L.Count; i++)
            //{
            //    Console.WriteLine(L[i]);
            //}

            //Console.WriteLine("********************************");

            //foreach (int x in L)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(L.IndexOf(19));     //on peut utiliser l'indexof pour affiche la position d'un élement



            ////-------------------declaration de dictionary en C sharp -------------------
            //Dictionary<string, string> D = new Dictionary<string, string>();
            //D.Add("cs", "Csharp");
            //D.Add("jv", "java");

            //Console.WriteLine(D["cs"]);

            ////-------------------declaration d'une  arraylist en C sharp -------------------
            //ArrayList ar = new ArrayList();          
            //ar.Add(1);
            //ar.Add(2);
            //ar.Add(3);
            //ar.Add(4);
            ////ar.Add(5);

            //ar.Insert(4,20);
            //ar.TrimToSize();//  pour reduire la capacité de nombre d'elements

            //Console.WriteLine(ar.Capacity);
            //foreach (var x in ar)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(ar.IndexOf(20));   // return la possition d'un element

            //ar.Remove(ar[0]);
            //foreach (var x in ar)
            //    {
            //        Console.WriteLine(x);
            //    }


            //ar.RemoveAt(0);
            //foreach (var x in ar)
            //       {
            //            Console.WriteLine(x);
            //        }


            //ar.Clear();
            //Console.WriteLine(ar.Count); 


            //ar[0] = "siham";
            //foreach (var x in ar)
            //           {
            //                Console.WriteLine(x);
            //            }

            //ArrayList a = new ArrayList(10);
            //int x = 0;

            //a.Add(++x);
            //a.Add(++x);
            //a.Add(++x);
            //a.Add(++x);

            //ArrayList b = new ArrayList(10);

            //Console.WriteLine(a.Equals(b));






            ////-------------------declaration de stack en C sharp -------------------
            //Stack s = new Stack();
            //    s.Push("Achouri samir");
            //    s.Push("alaoui mohamed");
            //    s.Push("tdi");
                //foreach (object x in s)
                //{
                //    Console.WriteLine(x);
                //}
                //Console.WriteLine("**********************");
                //Console.WriteLine(s.Peek()); // il affiche le dernier element ajouté
                //Console.WriteLine("**********************");
                //Console.WriteLine(  s.Pop());                    // supprimer le dernier element ajouté
                //Console.WriteLine(s.Peek());

                //IEnumerator i = s.GetEnumerator();     //afficher tout les element      
                //while (i.MoveNext())
                //{
                //    Console.WriteLine(i.Current);
                //}






                //exemple list d'objet pour afficher le prenom

                //List<Personne> lO = new List<Personne> { };
                //lO.Add(new Personne("aaaaa", "cccccc", 10));
                //Console.WriteLine(lO[0].Fname);


                ////exemple tableau d'objet pour afficher nom 
                
                //Personne[] TE = new Personne[1];

                //TE[0] = new Personne("aaaaa", "bbbbb", 1000);
                //Console.WriteLine(TE[0].Lname);



                


                Console.ReadLine();
        }
          
    }
}
