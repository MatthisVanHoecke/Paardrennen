using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Paardenrennen
{
    public partial class frmpaardrennen : Form
    {
        public frmpaardrennen()
        {
            InitializeComponent();
        }

        private int count = 0;
        private string[] plaatsen = new string[3];
        private Random random = new Random();
        private bool p1 = false, p2 = false, p3 = false;
        private int saldo, wedde;

        private void Tmrpaarden_Tick(object sender, EventArgs e)
        {

            moveHorse(pctrbxpaard1, tmrpaard1); //roep de functie op om de paarden te laten bewegen
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {


            //start de timers
            tmrpaard1.Enabled = true;
            tmrpaard2.Enabled = true;
            tmrpaard3.Enabled = true;
        }

        private void resetImages()
        {
            pctrbxpaard1.Left = 6;
            pctrbxpaard2.Left = 6;
            pctrbxpaard3.Left = 6;
            count = 0;
        }

        private void Tmrpaard2_Tick(object sender, EventArgs e)
        {
            moveHorse(pctrbxpaard2, tmrpaard2); //roep de functie op om de paarden te laten bewegen
        }

        private void Tmrpaard3_Tick(object sender, EventArgs e)
        {
            moveHorse(pctrbxpaard3, tmrpaard3); //roep de functie op om de paarden te laten bewegen
        }

        private void BtnP2_Click(object sender, EventArgs e)
        {
            p1 = false;
            p2 = true;
            p3 = false;

            wedde = numberError("hoeveel wed je?");
            saldo -= wedde;
        }

        private void BtnP3_Click(object sender, EventArgs e)
        {
            p1 = false;
            p2 = false;
            p3 = true;

            wedde = numberError("hoeveel wed je?");
            saldo -= wedde;
        }

        private int numberError(string error)
        {
            int getal;
            if (!int.TryParse(Interaction.InputBox(error), out getal))
            {
                MessageBox.Show("Vul alstublieft een getal in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return getal;
            }
            return getal;
        }

        private void Txtsaldo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnSetSaldo_Click(object sender, EventArgs e)
        {
            saldo = numberError("wat is je saldo?");
            txtsaldo.Text = saldo.ToString();
        }

        public void moveHorse(PictureBox paard, Timer tmr)
        {
            if (paard.Location.X < pctrbxfinish.Location.X - 80) //als het paard zijn x-positie kleiner is dan de finish (x-positie)-80, beweeg het paard
            {
                paard.Left += random.Next(0, 10);
            }

            if (paard.Location.X >= pctrbxfinish.Location.X - 80) //als het paard zijn x-positie groter is dan of gelijk aan de finish (x-positie)-80
            {
                if(paard == pctrbxpaard1)
                {
                    plaatsen[count] = "paard1"; //pctrbxpaard1 wordt gezien als 'paard1'
                }
                if (paard == pctrbxpaard2)
                {
                    plaatsen[count] = "paard2";
                }
                if (paard == pctrbxpaard3)
                {
                    plaatsen[count] = "paard3";
                }
                
                tmr.Enabled = false; //stop de timer
                count++;
            }

            if (count == 3)
            {
                MessageBox.Show(plaatsen[0] + " staat op de eerste plaats, gevolgd door " + plaatsen[1] + " en op de laatste plaats staat " + plaatsen[2], "Scorebord");
                if(p1 == true || p2 == true || p3 == true)
                {
                    if (plaatsen[0] == "paard1" && p1 == true)
                    {
                        MessageBox.Show("gewonnen");
                        saldo = saldo + (wedde * 3);
                        txtsaldo.Text = saldo.ToString();
                    }
                    else if (plaatsen[0] == "paard2" && p2 == true)
                    {
                        MessageBox.Show("gewonnen");
                        saldo = saldo + (wedde * 3);
                        txtsaldo.Text = saldo.ToString();
                    }
                    else if (plaatsen[0] == "paard3" && p3 == true)
                    {
                        MessageBox.Show("gewonnen");
                        saldo = saldo + (wedde * 3);
                        txtsaldo.Text = saldo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("verloren");
                        txtsaldo.Text = saldo.ToString();
                    }
                }
                resetImages();
            }
        }

        private void BtnP1_Click(object sender, EventArgs e)
        {
            p1 = true;
            p2 = false;
            p3 = false;

            wedde = numberError("hoeveel wed je?");
            saldo -= wedde;
        }
    }
}
