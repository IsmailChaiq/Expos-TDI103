using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace maskedtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "Entrée rejetée - Trop de données";
                toolTip1.Show("Vous ne pouvez plus entrer de données dans le champ de date. Supprimez quelques caractères pour insérer plus de données.", maskedTextBox1, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Entrée rejetée - fin de champ";
                toolTip1.Show("Vous ne pouvez pas ajouter de caractères supplémentaires à la fin de ce champ de date.", maskedTextBox1, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Entrée rejetée";
                toolTip1.Show("Vous ne pouvez ajouter que des caractères numériques (0-9) dans ce champ de date. ", maskedTextBox1, 0, -20, 5000);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = maskedTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            |
            maskedTextBox1.Mask = "00/00/0000";

            //Élément de masquage	  ////////////////         description
            //            0     Chiffre, obligatoire. Cet élément acceptera tout chiffre unique compris entre 0 et 9.
            //            9     Chiffre ou espace, facultatif.
            //            #     Chiffre ou espace, facultatif. Si cette position est vide dans le masque, elle sera rendue sous la forme d’un espace dans la propriété Text. Les signes plus (+) et moins (-) sont autorisés.
            //            L     Lettre obligatoire. Limite l’entrée aux lettres ASCII a-z et A-Z. Cet élément mask est équivalent à [a-zA-Z] dans les expressions régulières.
            //            ?     Lettre, facultatif. Limite l’entrée aux lettres ASCII a-z et A-Z. Cet élément de masque est équivalent à [a-zA-Z] ? dans les expressions régulières.
            //            &     Caractère, obligatoire. Si la propriété AsciiOnly a la valeur true, cet élément se comporte comme l’élément « L ».
            //            C     Caractère, facultatif. Tout caractère qui ne fait pas l’état de contrôle. Si la propriété AsciiOnly a la valeur , cet élément se comporte comme l’élément « ? ».true
   
            //            .     Espace réservé décimal. Le caractère d’affichage réel utilisé sera le symbole décimal approprié au fournisseur de format, tel que déterminé par la propriété FormatProvider du contrôle.
            //            ,     Espace réservé de milliers. Le caractère d’affichage réel utilisé sera l’espace réservé de milliers approprié au fournisseur de format, tel que déterminé par la propriété FormatProvider du contrôle.
            //            :     Séparateur d’heure. Le caractère d’affichage réel utilisé sera le symbole d’heure approprié au fournisseur de format, tel que déterminé par la propriété FormatProvider du contrôle.
            //            /     Séparateur de date. Le caractère d’affichage réel utilisé sera le symbole de date approprié au fournisseur de format, tel que déterminé par la propriété FormatProvider du contrôle.
            //            $     Symbole monétaire. Le caractère réel affiché sera le symbole monétaire approprié au fournisseur de format, tel que déterminé par la propriété FormatProvider du contrôle.
            //            <     Décaler vers le bas. Convertit tous les caractères qui suivent en minuscules.
            //            >     Déplacez-vous vers le haut. Convertit tous les caractères qui suivent en majuscules.
            //            |     Désactivez un décalage précédent vers le haut ou vers le bas.
            //            \	    échapper. Échappe un caractère de masque, le transformant en littéral. « \\ » est la séquence d’échappement pour une barre oblique inverse.
        }
        

    }

}
    



