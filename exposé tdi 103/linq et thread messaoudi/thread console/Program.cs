using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;



namespace thread2
{
    public class Program
    {
        static SemaphoreSlim attente = new SemaphoreSlim( 3); //objet pour limiter le nombre de threads qui fonctionne en meme temps
        static int cpt;

        static object verrou = new object();  // objet qui sert a effectuer la tache (verrouillage) 

        public static void Main(string[] args)
        {
            Stopwatch stp = new Stopwatch(); // calculer la duree

            //Thread t1 = new Thread (     delegate() { essai(5);} )  ; // si le paremettrfe est (int ou string...) sinon type objet dans paramettre de la fonction 

            //Thread t1 = new Thread( fonction3 ); pour comparer entre un thred et le main 
            //t1.IsBackground = true ;pour comparer entre un thred et le main

            //Thread t1 = new Thread(incrementer);
            //Thread t2 = new Thread(incrementer );
            //Thread t3 = new Thread(incrementer);

            //t1.Name = "T1";
            //t2.Name = "T2";
            //t3.Name = "T3";


            //t2.Priority = ThreadPriority.Highest; .lowest / .normal
            //t1.Priority = ThreadPriority.Highest;

            //stp.Start();  // debut calcul duree
            //stp.Stop(); //  fin calcule duree

            //t1.join();   limiter un thread ( debut avec start() et fin avec stop()  
            //t2.join();

            //t1.Start();
            //t2.Start();
            //t3.Start();


            //a comparer avec la foncion3 pour comprendre la notion.isbackround sur un thread :

            //Console.WriteLine("main commence ");
            ////Console.ReadLine();
            ////Console.WriteLine("main encours ");
            ////Console.ReadLine();
            //Console.WriteLine("main termine ");
            //Console.ReadLine();



            //Console.WriteLine("La duree de l'execution est :   " + stp.ElapsedMilliseconds ); afficher la duree 




            //Thread[] tabthread = new Thread[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    tabthread[i] = new Thread(afficher);
            //    tabthread[i].Name = "T" + i;
            //    tabthread[i].Start();
            //}












            //Console.ReadLine();



        }





        static void fonction1()
        {
            for (int i = 0; i < 7; i++)
            {
                
                Console.WriteLine("UN (1)  et  i  = " + i.ToString());
                

            }
            Console.WriteLine("*******************");


        }



        static void fonction2()
        {
            for (int i = 0; i < 7; i++)
            {
                
                Console.WriteLine(" DEUX (2) et  i  = " + i.ToString());

            }
            Console.ReadLine();

        }


       

        static void fonction3()
        {
            Console.WriteLine("fonction commence ");
            Console.ReadLine();
            Console.WriteLine("fonction encours ");
            Console.ReadLine();
            Console.WriteLine("fonction encours ");
            Console.ReadLine();
            Console.WriteLine("fonction termine ");
            Console.ReadLine();

        }



        static void essai(int a)    // on doit utiliser delegate(){  ....  } pour pouvoir mettre un entier dans le paramettre
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("*");
            } 
        }


        static void essai(object a)      // sinon utiliser un paramettre de type objet et apres convertir en entier (int) 
        {
            for (int i = 0; i < (int) a; i++)
            {
                Console.WriteLine("*");
            }
        }



        static void affiche(object a)  // on la utiliser pour les priorité / et join()
        {
            for (int i = 0; i < 10000 ; i++)
            {
                Console.Write(a);
            }

        }


        static void delai()  //pour  calculer la duree  
        {
            for (int i = 0; i < 8 ; i++)
            {
                Console.Write(i.ToString());
                Thread.Sleep(1000);
            } 

        }



        static void incrementer()
        {
            for (int i = 0; i < 100000 ; i++)
            {

                //cpt++;  sans verrouillage

                lock (verrou)  // avec verrouillage ,, seul un seul thread qui peut y accéder
                {
                    cpt++;
                }

            }

            Console.WriteLine(Thread.CurrentThread.Name + " = " + cpt.ToString());// valeur final du cpt
        }

        //a utiliser pour l'objet semaphoreslim :
        static void afficher()
        {
            attente.Wait();  // debut semaphoreslim  ,, declarer le nombre de thread dans la declaration de semaphoreslim;; ds notre exemple c'est 3

            for (int i = 0; i < 10; i++)
            {
                Console.Write(Thread.CurrentThread.Name + "__");
                Thread.Sleep(1000);
            }
            Console.WriteLine("fin du thread " + Thread.CurrentThread.Name);


            attente.Release();// fin semaphoreslim
        }




















    }
}












//static void incrementer()
//{

//    for (int i = 0; i < 1000000; i++)
//    {
//        lock (verou)
//        {
//            cpt++;
//        }

//    }
//    Console.WriteLine(Thread.CurrentThread.Name + " = " + cpt.ToString());
//}


//static void afficher()
//{
//    attente.Wait();
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write(Thread.CurrentThread.Name + "-");
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine("fin du thread " + Thread.CurrentThread.Name);
//    attente.Release();
//}