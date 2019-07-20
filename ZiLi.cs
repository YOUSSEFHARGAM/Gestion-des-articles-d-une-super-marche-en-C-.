using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Myregex.DSTableAdapters;


namespace Myregex
{
    public partial class ZiLi : Form
    {
        string text;

        AnaLyse analyse = new AnaLyse();
        QueriesTableAdapter Req = new QueriesTableAdapter();

        public ZiLi()
        {
            InitializeComponent();
        }
       
        private void Valider_Click(object sender, EventArgs e)
        {
            TResultat.Text = "";

            text = Tcomand.Text;

            if (analyse.FinAnalyse(text) == true)
            {
                if (analyse.La_Procedure(Tcomand, TResultat)==true)
                {
                    if (analyse.requete == "vendre")
                    {
                        LDH.Visible = true;

                        TResultat.Visible = true;
                        TResultat.Left = 260;
                        TResultat.Width = 130;
                        TResultat.ForeColor = Color.Red;

                        LResultat.Left = 160;
                        LResultat.Text = "Le Prix est";
                    }

                    else if (analyse.requete == "ajouter")
                    {
                        LDH.Visible = false;

                        LResultat.Left = 10;
                        LResultat.Text = "Résultat : ";

                        TResultat.Visible = true;
                        TResultat.Left = Tcomand.Left;
                        TResultat.Width = Tcomand.Width;
                        TResultat.Text = analyse.saisieArt + " ajouté avec succés ";
                        TResultat.ForeColor = Color.SteelBlue; 
                    }
                    else
                    {
                        LDH.Visible = false;
                    }
                }
            }
            }

        private void ZiLi_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Tcomand.Left = 90;

            TResultat.Visible = false;

            LDH.Visible = false;

            LResultat.Text = "";
        }

        private void Tcomand_TextChanged(object sender, EventArgs e)
        {
            Tcomand.ForeColor = Color.Black;
        }
           
    }
}