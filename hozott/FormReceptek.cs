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
    public partial class FormReceptek : Form
    {
        public FormReceptek()
        {
            InitializeComponent();
        }

        // UC-K PANELBE TÖLTÉSE
        private void buttonReceptModositas_Click(object sender, EventArgs e)
        {
            // Kitöröljük az összes vezérlőt a panelről  
            panel1.Controls.Clear();

            // Létrehozzuk az 1. UserControlt  
            UserControl uCReceptModositas = new UCReceptModositas();

            // Hozzáadjuk a panelhez.  
            panel1.Controls.Add(uCReceptModositas);

            // Dock: Az objektum szülőobjektumához való illeszkedését határozza meg  
            // DockStíle.Fill: A vezérlő mind a négy oldala illeszkedjen (és méreteződjön) a szülőobjektumhoz.  
            uCReceptModositas.Dock = DockStyle.Fill;
        }



        private void buttonUjFogasFelvetele_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl uCUjFogas = new UCUjFogas();
            panel1.Controls.Add(uCUjFogas);
            uCUjFogas.Dock = DockStyle.Fill;
        }
    }
}
