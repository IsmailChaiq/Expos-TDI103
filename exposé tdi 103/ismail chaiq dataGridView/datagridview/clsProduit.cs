using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace datagridview
{
    class clsProduit
    {
        public static BindingList<clsProduit> ListeProduits = new BindingList<clsProduit>();

        private int id;
        private string nom;
        private string pictureFilename;
        private char etat;
        private bool fragile;
        public int qte;
        private DateTime date;

        public string Nom { get => nom; set => nom = value; }
        public string PictureFilename { get => pictureFilename; set => pictureFilename = value; }
        public char Etat { get => etat; set => etat = value; }
        public string str_Etat { get {
                if (Etat == 'L')
                {
                    return "Livré";
                }
                else if (Etat == 'E')
                {
                    return "En cours";
                }
                else if (Etat == 'R')
                {
                    return "Retard";
                }
                else return null;
            } }
        public bool Fragile { get => fragile; set => fragile = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Id { get => id; set => id = value; }

        public clsProduit(string nom, string pictureFilename,char etat, bool fragile, int Qte, DateTime dt)
        {
            Nom = nom;
            PictureFilename = pictureFilename;
            Etat = etat;
            Fragile = fragile;
            qte = Qte;
            Date = dt;
            Id = getMaxId();
        }
        public static int getMaxId()
        {
            int id = 0;
            for (int i = 0; i < ListeProduits.Count; i++)
            {
                if (ListeProduits[i].Id > id)
                {
                    id = ListeProduits[i].Id;
                }
            }
            return id + 1;
        }
        public static int recherche(int id)
        {
            for (int i = 0; i < ListeProduits.Count; i++)
            {
                if (ListeProduits[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void supprimerID(int id)
        {
            if(recherche(id) != -1)
            {
                ListeProduits.RemoveAt(recherche(id));
            }
        }
    }
}
