using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_control
{
    class membre
    {
        private string name;
        private string numero;
        private string adresse ;
        private string telephone;





        public membre(string name , string numero ,string telephone , string adresse)
        {
            this.Name = name;
            this.Numero = numero ;
            this.Adresse = adresse;
            this.Telephone = telephone;
        }

        public string Name { get => name; set => name = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Adresse{ get =>   adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }




        public void ajouter(membre mbr)
        {
            liste.lstmembre.Add(mbr);
        }
    }
}
