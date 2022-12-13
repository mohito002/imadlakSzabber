using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using hozott.Models;

namespace hozott
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp; // A Microsoft Excel alkalmaz�s
        Excel.Workbook xlWB;     // A l�trehozott munkaf�zet
        Excel.Worksheet xlSheet; // Munkalap a munkaf�zeten bel�l
        public Form1()
        {
            InitializeComponent();
        }

        //KIL�P�S ELLEN�RZ�SE
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("T�nyleg ki szeretne l�pni?", "Kil�p�s", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        //FORMOK MEGNYIT�SA
        private void buttonReceptek_Click(object sender, EventArgs e)
        {
            Form formReceptek = new FormReceptek();
            formReceptek.ShowDialog();
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            Form formDiagram = new FormUjRecept();
            formDiagram.ShowDialog();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        void CreateTable()
        {
            string[] fejl�cek = new string[] {
            "Nyersanyag",
            "Mennyis�gi egys�g",
            "Egys�g�r"};

            for (int i = 0; i < fejl�cek.Length; i++)
            {
                xlSheet.Cells[1, i+1] = fejl�cek[i];
            }

            ReceptContext receptContext = new ReceptContext();
            var mindenNyersayag = receptContext.Nyersanyagok.ToList();

            //Ezut�n hozz l�tre egy object t�pus� k�t dimenzi�s t�mb�t az adatok t�rol�s�ra.
            object[,] adatT�mb = new object[mindenNyersayag.Count(), fejl�cek.Count()];

            for (int i = 0; i < mindenNyersayag.Count(); i++)
            {
                adatT�mb[i, 0] = mindenNyersayag[i].NyersanyagNev;
                adatT�mb[i, 1] = mindenNyersayag[i].MennyisegiEgysegId;
                adatT�mb[i, 2] = mindenNyersayag[i].Egysegar;
            }

            //A bem�sol�s el�tt sz�ks�g�nk lesz a t�mb m�ret�re

            int sorokSz�ma = adatT�mb.GetLength(0);
            int oszlopokSz�ma = adatT�mb.GetLength(1);

            //Ezut�n l�tre kell hoznunk azt a Range-et, ahov� az adatokat �rni akarjuk. El�sz�r megadjuk a bal-fels� sark�t,
            //majd a .get_Resize seg�ts�g�vel �t�ll�tjuk a m�ret�t:
            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSz�ma, oszlopokSz�ma);
            adatRange.Value2 = adatT�mb;

            //adatok form�z�sa
            adatRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            //fejl�c form�z�sa
            Excel.Range fejll�cRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, fejl�cek.Length);
            fejll�cRange.Font.Bold = true;
            fejll�cRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejll�cRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejll�cRange.EntireColumn.AutoFit();
            fejll�cRange.RowHeight = 40;
            fejll�cRange.Interior.Color = Color.LightBlue;
            fejll�cRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

        private void CreateExcel()
        {
            try
            {
                // Excel elind�t�sa �s az applik�ci� objektum bet�lt�se
                xlApp = new Excel.Application();

                // �j munkaf�zet, �j munkalap, T�bla l�trehoz�sa
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();

                // Control �tad�sa a felhaszn�l�nak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezel�s a be�p�tett hiba�zenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba eset�n az Excel applik�ci� bez�r�sa automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
    }
}