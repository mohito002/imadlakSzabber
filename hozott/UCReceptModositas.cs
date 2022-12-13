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
    public partial class UCReceptModositas : UserControl
    {
        ReceptContext receptContext = new ReceptContext();
        public UCReceptModositas()
        {
            InitializeComponent();
            NyersanyagListazas();
            FogasListazas();
        }


        private void textBoxNyersanyag_TextChanged(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }

        private void textBoxFogas_TextChanged(object sender, EventArgs e)
        {
            FogasListazas();
        }
        
        private void listBoxFogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzavaloListazas();
        }

        //HOZZÁVALÓ TÖRLÉSE
        private void buttonTorles_Click(object sender, EventArgs e)
        {
            var receptID = ((Hozzavalo)hozzavaloBindingSource.Current).ReceptID;

            var törlendő = (from x in receptContext.Receptek
                            where x.ReceptId == receptID
                            select x).FirstOrDefault();

            receptContext.Receptek.Remove(törlendő);
            receptContext.SaveChanges();
            HozzavaloListazas();
        }

        //Új hozzávaló felvétele
        private void listBoxNyersanyag_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiválasztottNyersanyag = (Nyersanyagok)listBoxNyersanyag.SelectedItem;
            var megyseg = (from x in receptContext.MennyisegiEgysegek
                           where x.MennyisegiEgysegId == kiválasztottNyersanyag.MennyisegiEgysegId
                           select x).FirstOrDefault();
            labelMennyEgys.Text = megyseg.EgysegNev;

        }

        private void buttonHozzaadas_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)listBoxNyersanyag.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)listBoxFogas.SelectedItem).FogasId;
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

        //FOGAS SZŰRÉS
        private void FogasListazas()
        {
            var hv = from x in receptContext.Fogasok
                     where x.FogasNev.Contains(textBoxFogas.Text)
                     select x;

            listBoxFogas.DataSource = hv.ToList();
            listBoxFogas.DisplayMember = "FogasNev";
        }

        //Kiválasztott fogáshoz tartozó hozzávalók megjelenítése
        private void HozzavaloListazas()
        {
            var id = ((Fogasok)listBoxFogas.SelectedItem).FogasId;

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
