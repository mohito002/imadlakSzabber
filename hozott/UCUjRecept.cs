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
    public partial class UCUjRecept : UserControl
    {
        ReceptContext receptContext = new ReceptContext();
        public UCUjRecept()
        {
            InitializeComponent();

            labelUjFogas.Text = (from x in receptContext.Fogasok
                                 orderby x.FogasId
                                 select x.FogasNev).LastOrDefault();
            NyersanyagListazas();
            
        }

        private void textBoxNyersanyag_TextChanged(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }


        //HOZZÁVALÓ TÖRLÉSE MEGERŐSÍTÉSSEL
        private void buttonTorles_Click_1(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Tényleg ki szeretné törölni?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit == DialogResult.Yes)
            {
                var receptID = ((Hozzavalo)hozzavaloBindingSource.Current).ReceptID;

                var törlendő = (from x in receptContext.Receptek
                                where x.ReceptId == receptID
                                select x).FirstOrDefault();

                receptContext.Receptek.Remove(törlendő);
                receptContext.SaveChanges();
                HozzavaloListazas();
            }


        }



        //Új hozzávaló felvétele
        private void listBoxNyersanyag_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var kiválasztottNyersanyag = (Nyersanyagok)listBoxNyersanyag.SelectedItem;
            var megyseg = (from x in receptContext.MennyisegiEgysegek
                           where x.MennyisegiEgysegId == kiválasztottNyersanyag.MennyisegiEgysegId
                           select x).FirstOrDefault();
            labelMennyEgys.Text = megyseg.EgysegNev;
        }
        private void buttonHozzaadas_Click_1(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)listBoxNyersanyag.SelectedItem).NyersanyagId;
            r.FogasId = (from x in receptContext.Fogasok
                         orderby x.FogasId
                         select x.FogasId).LastOrDefault();
            double m;
            if (!double.TryParse(textBoxMennyiség.Text, out m)) return;
            r.Mennyiseg4fo = m;
            receptContext.Receptek.Add(r);
            receptContext.SaveChanges();
            HozzavaloListazas();
        }

        //NYERSANYAG SZŰRÉS
        private void NyersanyagListazas()
        {
            var hv = from x in receptContext.Nyersanyagok
                     where x.NyersanyagNev.Contains(textBoxNyersanyag.Text)
                     select x;

            listBoxNyersanyag.DataSource = hv.ToList();
            listBoxNyersanyag.DisplayMember = "NyersanyagNev";
        }

        //Kiválasztott fogáshoz tartozó hozzávalók megjelenítése
        private void HozzavaloListazas()
        {
            var id = (from x in receptContext.Fogasok
                      orderby x.FogasId
                      select x.FogasId).LastOrDefault();

            var hozzávalók = from x in receptContext.Receptek
                             where x.FogasId == id
                             select new Hozzavalo
                             {
                                 ReceptID = x.ReceptId,
                                 FogasID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            hozzavaloBindingSource.DataSource = hozzávalók.ToList();
        }
    }
}
