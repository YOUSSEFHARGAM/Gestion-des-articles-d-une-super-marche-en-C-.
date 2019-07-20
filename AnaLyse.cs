using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Myregex.DSTableAdapters;
using System.Data;
using System.Drawing;


namespace Myregex
{
    public class AnaLyse
    {
        public string saisieArt;
        public string requete;

        string[] sptr;
        string KeyWrod;
        string LaCMD;
        string Nom_Unite;

        int Long_Quant;
        int quant, reqP;

        double PU;

        QueriesTableAdapter Rq = new QueriesTableAdapter();
        ArticleTableAdapter art = new ArticleTableAdapter();

        public AnaLyse()
        {
        }

        //Decouper la saisie en tableau de caracteres apres chaque espace
        public string[] Splitter(string chaine)
        {
            Regex mySplitter = new Regex(@"\s+");
            return mySplitter.Split(chaine);
        }

        //validation des mots clé ( Les requetes ) 
        public string Id_RKeyWords(string PremCham)
        {
            sptr = Splitter(PremCham);
            KeyWrod = sptr[0] ;

            if (KeyWrod == "vendre")
            {
                return "vente";
            }
            else if (KeyWrod == "ajouter")
            {
                return "ajout";
            }
            else
            {
                return null;
            }
        }

        private bool verifVendreF()
        {
            int L, M;

            L = sptr.Length;
            M = L % 3;

            if (M == 1 ||M == 2 )
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // Verifier le mot clé
        public bool ValidField(string Champ)
        {
            string ReqKW;
            ReqKW = Id_RKeyWords(Champ);

            if (ReqKW == "vente")
            {
                Regex VRegex = new Regex(@"^(([a-z A-z]+)(\s)([\d]+)(\s)([a-z A-z]+)(\s)([a-z A-z 0-9]+))+$");
                Match m = VRegex.Match(Champ);
                if (verifVendreF() == true)
                {
                    return (m.Success);
                }
                else
                {
                    return false;
                }
            }
            else if (ReqKW == "ajout")
            {
                Regex ARegex = new Regex(@"^(([a-z A-z]+)(\s)([a-z A-z]+)(\s)([\d]+)(\s)([a-z A-z]+))+$");
                Match m = ARegex.Match(Champ);
                return (m.Success);
            }

            else
            {
                return false;
            }
        }

        //réagir en fonction du mot clé
        public int testQuantite(string Champ)
        {
            if (Id_RKeyWords(Champ) == "vente")
            {
                Long_Quant = sptr[1].Length;
                return Long_Quant;
            }

            else if (Id_RKeyWords(Champ) == "ajout")
            {
                Long_Quant = sptr[2].Length;
                return Long_Quant;
            }
            else return 0;
        }

        //limiter le quantité a 4 chiffre
        public bool calculus(string Champ)
        {
            if (testQuantite(Champ) < 5)
            {
                return true;
            }

            else
            {
                return false; 
            }

        }
                
       //validation finale de la syntaxe
        public bool FinAnalyse(string LeChamp)
        {
            
            if (ValidField(LeChamp) == true)
            {
                if (calculus(LeChamp) == true)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La commande est trop volumineuse");
                    return false ;
                }
            }
            else
            {
                MessageBox.Show("Noooon Validé");
                return false;
            }
        }

        private void coulText(TextBox txt)
        {
            txt.Text = sptr[0] + " " + sptr[1] + " " + sptr[2] + " " + sptr[3];
            txt.ForeColor = Color.Red;
        }

        public bool La_Procedure(TextBox Tcomand, TextBox TValeur)
        {
            LaCMD = Tcomand.Text;

            sptr = Splitter(LaCMD);

            requete = sptr[0];

            if (requete == "vendre")
            {
                quant = Convert.ToInt32(sptr[1]);
                saisieArt = Convert.ToString(sptr[3]);
                try
                {
                    reqP = Convert.ToInt32(Rq.Precio(saisieArt));
                    LaCMD = Convert.ToString(quant * reqP);
                    TValeur.Text = LaCMD;
                    coulText(Tcomand);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("un probleme avec la base de données est survenu");
                    return false;
                }
            }

            else if (requete == "ajouter")
            {
                saisieArt = Convert.ToString(sptr[1]);
                PU = Convert.ToInt16(sptr[2]);
                Nom_Unite = Convert.ToString(sptr[3]);
                try
                {
                    Rq.nuevoArt(saisieArt, (int?)PU, Nom_Unite);
                    coulText(Tcomand);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("un probleme avec la base de données est survenu au moment de l'ajout");
                    return false;
                }
            }

            else
            {
                MessageBox.Show("Une erreur c'est produite");
                return false;
            }

           
        }

    }
}
