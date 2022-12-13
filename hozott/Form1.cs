using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using hozott.Models;

namespace hozott
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB;     // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül
        public Form1()
        {
            InitializeComponent();
        }

        //KILÉPÉS ELLENÖRZÉSE
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Tényleg ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        //FORMOK MEGNYITÁSA
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
            string[] fejlécek = new string[] {
            "Nyersanyag",
            "Mennyiségi egység",
            "Egységár"};

            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i+1] = fejlécek[i];
            }

            ReceptContext receptContext = new ReceptContext();
            var mindenNyersayag = receptContext.Nyersanyagok.ToList();

            //Ezután hozz létre egy object típusú két dimenziós tömböt az adatok tárolására.
            object[,] adatTömb = new object[mindenNyersayag.Count(), fejlécek.Count()];

            for (int i = 0; i < mindenNyersayag.Count(); i++)
            {
                adatTömb[i, 0] = mindenNyersayag[i].NyersanyagNev;
                adatTömb[i, 1] = mindenNyersayag[i].MennyisegiEgysegId;
                adatTömb[i, 2] = mindenNyersayag[i].Egysegar;
            }

            //A bemásolás elõtt szükségünk lesz a tömb méretére

            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            //Ezután létre kell hoznunk azt a Range-et, ahová az adatokat írni akarjuk. Elõször megadjuk a bal-felsõ sarkát,
            //majd a .get_Resize segítségével átállítjuk a méretét:
            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;

            //adatok formázása
            adatRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            //fejléc formázása
            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, fejlécek.Length);
            fejllécRange.Font.Bold = true;
            fejllécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejllécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejllécRange.EntireColumn.AutoFit();
            fejllécRange.RowHeight = 40;
            fejllécRange.Interior.Color = Color.LightBlue;
            fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

        private void CreateExcel()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet, Új munkalap, Tábla létrehozása
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
    }
}