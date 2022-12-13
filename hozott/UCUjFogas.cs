using hozott.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hozott
{
    public partial class UCUjFogas : UserControl
    {
        ReceptContext receptContext = new ReceptContext();
        public UCUjFogas()
        {
            InitializeComponent();
        }

        private void buttonHozzaadas_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                Fogasok f = new Fogasok();

                f.FogasNev = textBoxFogasNev.Text;
                f.Leiras = textBoxLeiras.Text;

                receptContext.Fogasok.Add(f);
                receptContext.SaveChanges();


                DialogResult exit = MessageBox.Show("Szeretnéd most megadni a fogáshoz tartozó receptet?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exit == DialogResult.Yes)
                {
                    Controls.Clear();
                    UserControl uCUjRecept = new UCUjRecept();
                    Controls.Add(uCUjRecept);
                    uCUjRecept.Dock = DockStyle.Fill;
                }

            }



        }


        //Ellenörzéshez kötött adatfelvétel
        bool checkUres(string s)
        {
            return !string.IsNullOrEmpty(s);
        }
        private void textBoxFogasNev_Validating(object sender, CancelEventArgs e)
        {
            if (!checkUres(textBoxFogasNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFogasNev, "Ez a mező nem lehet üres!");
            }
        }

        private void textBoxFogasNev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFogasNev, "");
        }
    }
}
