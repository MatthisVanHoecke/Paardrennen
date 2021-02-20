using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Tmrpaard2_Tick(object sender, EventArgs e)
        {
            moveHorse(pctrbxpaard2, tmrpaard2); //roep de functie op om de paarden te laten bewegen
        }

        private void Tmrpaard3_Tick(object sender, EventArgs e)
        {
            moveHorse(pctrbxpaard3, tmrpaard3); //roep de functie op om de paarden te laten bewegen
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
            }
        }
    }
}
