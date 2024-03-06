using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculacka
{
    public partial class Form1 : Form
    {
        // typ operace
        enum enOperace
        {
            Plus,
            Minus,
            Krat,
            Deleno,
            Clear,
            Rovno
        }
        // promenne
        float mflCislo1, mflCislo2, mflVysledek;

        enOperace menAktOperace;

        public Form1()
        {
            InitializeComponent();

            // smazani vseho na zacatku

            VseVymazat();
        }
        //
        // zapsani dalsiho cisla
        //
        private void btOperace_Click(object sender, EventArgs e)
        {
            //tlacitko ktere zavola funkci
            Button lobjTlacitko = (Button)sender;

            switch (lobjTlacitko.Text)
            {
                case "+":
                    mflCislo2 = Convert.ToSingle(txtDisplay.Text);
                    menAktOperace = enOperace.Plus;
                    txtDisplay.Text = "0";
                    break;

                case "-":
                    mflCislo2 = Convert.ToSingle(txtDisplay.Text);
                    menAktOperace = enOperace.Minus;
                    txtDisplay.Text = "0";
                    break;

                case "*":

                    mflCislo2 = Convert.ToSingle(txtDisplay.Text);
                    menAktOperace = enOperace.Krat;
                    txtDisplay.Text = "0";
                    break;

                case "/":
                    mflCislo2 = Convert.ToSingle(txtDisplay.Text);
                    menAktOperace = enOperace.Deleno;
                    txtDisplay.Text = "0";
                    break;
                case "=":
                    mflCislo1 = mflCislo2;
                    mflCislo2 = Convert.ToSingle(txtDisplay.Text);
                    if (menAktOperace == enOperace.Plus)
                    {
                        mflVysledek = mflCislo1 + mflCislo2;
                    }
                    else if (menAktOperace == enOperace.Minus)
                    {
                        mflVysledek = mflCislo1 - mflCislo2;
                    }
                    else if (menAktOperace == enOperace.Krat)
                    {
                        mflVysledek = mflCislo1 * mflCislo2;
                    }
                    else if (menAktOperace == enOperace.Deleno)
                    {
                        mflVysledek = mflCislo1 / mflCislo2;
                    }
                    txtDisplay.Text = mflVysledek.ToString();
                    break;
            }

        }
        //
        // zapsani operace
        //
        private void btCislo_Click(object sender, EventArgs e)
        {
            try
            {
                //smazani nuly
                if (txtDisplay.Text == "0") txtDisplay.Text = "";

                //pridat dalsi cislo

                txtDisplay.Text = txtDisplay.Text + ((Button)sender).Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("asi to nefunguje :(");
            }
        }
        private void VseVymazat()
        {
            //smazat uvodni nulu

            txtDisplay.Text = "0";

            // inicializace promenne

            mflCislo1 = mflCislo2 = mflVysledek = 0;
            menAktOperace = enOperace.Clear;

        }
    }
}
