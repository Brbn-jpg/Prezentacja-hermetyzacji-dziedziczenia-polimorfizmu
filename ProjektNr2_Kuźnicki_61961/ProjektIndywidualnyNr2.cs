using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static ProjektNr2_Kuźnicki_61961.FiguryGeometryczneNr2;
using System.Drawing.Printing;

namespace ProjektNr2_Kuźnicki_61961
{
    public partial class ProjektIndywidualnyNr2 : Form
    {
        Graphics Rysownica;
        Pen JKPioro;
        SolidBrush JKPedzel;
        List<Punkt> LFG = new List<Punkt>();
        int IndexLFG = 0;
        Color Kolor;
        Color KolorWypełnienia;
        Point Punkt = Point.Empty;
        DashStyle StylLinii = DashStyle.Solid;
        float GrubośćLinii = 3;
        int Margines = 10;
        public ProjektIndywidualnyNr2()
        {
            InitializeComponent();
            // "podpięcie" BitMapy do kontrolki PictureBox
            JKpbRysownica.Image = new Bitmap(JKpbRysownica.Width, JKpbRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej
            Rysownica = Graphics.FromImage(JKpbRysownica.Image);
            // utworzenie egzemplarza Pióra i jego sformatowanie
            JKPioro = new Pen(Color.Red, 1.7f);
            JKPioro.DashStyle = DashStyle.Dash;
            JKPioro.StartCap = LineCap.Round;
            JKPioro.EndCap = LineCap.Round;

            // utworzenie egzemplarza Pedzla
            JKPedzel = new SolidBrush(Color.RoyalBlue);
        }

        private void JKpbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            JKlblX.Text = e.Location.X.ToString();
            JKlblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
                Punkt = e.Location;
        }

        private void JKpbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            JKlblX.Text = e.Location.X.ToString();
            JKlblY.Text = e.Location.Y.ToString();
        }

        private void JKpbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            JKlblX.Text = e.Location.X.ToString();
            JKlblY.Text = e.Location.Y.ToString();
            int JKLewyGornyNaroznikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int JKLewyGornyNaroznikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int JKSzerokość = Math.Abs(Punkt.X - e.Location.X);
            int JKWysokość = Math.Abs(Punkt.Y - e.Location.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (JKrdbPunkt.Checked)
                {
                    LFG.Add(new Punkt(Punkt.X - 2, Punkt.Y - 2, Kolor));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbLinia.Checked)
                {
                    LFG.Add(new Linia(Punkt.X,Punkt.Y, e.Location.X, e.Location.Y, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbElipsa.Checked)
                {
                    LFG.Add(new Elipsa(Punkt.X, Punkt.Y, JKSzerokość, JKWysokość, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbOkrąg.Checked)
                {
                    LFG.Add(new Okrąg(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKSzerokość, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbKoło.Checked)
                {
                    KolorWypełnienia = JKbtnKolorWyp.BackColor;
                    LFG.Add(new Koło(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKSzerokość, KolorWypełnienia, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbProstokąt.Checked)
                {
                    LFG.Add(new Prostokąt(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbKwadrat.Checked)
                {
                    LFG.Add(new Prostokąt(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKSzerokość, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbFillRectangle.Checked)
                {
                    KolorWypełnienia = JKbtnKolorWyp.BackColor;
                    LFG.Add(new FillRectangle(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, KolorWypełnienia, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbWielokątFor.Checked)
                {
                    ushort StopieńWielokąta = (ushort)JKnumLiczbaKątów.Value;
                    LFG.Add(new WielokątForemny(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, StopieńWielokąta, JKSzerokość, Kolor, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbFillEllipse.Checked)
                {
                    KolorWypełnienia = JKbtnKolorWyp.BackColor;
                    LFG.Add(new FillElipse(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, KolorWypełnienia, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbWielokątWyp.Checked)
                {
                    KolorWypełnienia = JKbtnKolorWyp.BackColor;
                    ushort StopieńWielokąta = (ushort)JKnumLiczbaKątów.Value;
                    LFG.Add(new WielokątWypełniony(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, StopieńWielokąta, JKSzerokość, KolorWypełnienia, StylLinii, GrubośćLinii));
                    LFG[IndexLFG].Wykreśl(Rysownica);
                    IndexLFG++;
                }
                if (JKrdbDrawPie.Checked)
                {
                    int JKKątPoczątkowy = (int)JKnumKątPoczątkowy.Value;
                    int JKKątKońcowy = (int)JKnumKątKońcowy.Value;
                    try
                    {
                        LFG.Add(new DrawPie(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, JKKątPoczątkowy, JKKątKońcowy, Kolor, StylLinii, GrubośćLinii));
                        LFG[IndexLFG].Wykreśl(Rysownica);
                        IndexLFG++;
                    }
                    catch (ArgumentException) { }
                }
                if (JKrdbFillPie.Checked)
                {
                    KolorWypełnienia = JKbtnKolorWyp.BackColor;
                    int JKKątPoczątkowy = (int)JKnumKątPoczątkowy.Value;
                    int JKKątKońcowy = (int)JKnumKątKońcowy.Value;
                    try
                    {
                        LFG.Add(new FillPie(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, JKKątPoczątkowy, JKKątKońcowy, KolorWypełnienia, StylLinii, GrubośćLinii));
                        LFG[IndexLFG].Wykreśl(Rysownica);
                        IndexLFG++;
                    }
                    catch (ArgumentException) { }
                }
                if (JKrdbDrawArc.Checked)
                {
                    int JKKątPoczątkowy = (int)JKnumKątPoczątkowy.Value;
                    int JKKątKońcowy = (int)JKnumKątKońcowy.Value;
                    try
                    {
                        LFG.Add(new DrawArc(JKLewyGornyNaroznikX, JKLewyGornyNaroznikY, JKSzerokość, JKWysokość, JKKątPoczątkowy, JKKątKońcowy, Kolor, StylLinii, GrubośćLinii));
                        LFG[IndexLFG].Wykreśl(Rysownica);
                        IndexLFG++;
                    }
                    catch (ArgumentException) { }
                }

            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnCofnij_Click(object sender, EventArgs e)
        {
            if (LFG.Count>0)
            {
                LFG[LFG.Count - 1].Wymaż(JKpbRysownica, Rysownica);
                LFG.RemoveAt(LFG.Count - 1);
                IndexLFG--;
            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnKolorLinii_Click(object sender, EventArgs e)
        {
            //okno dialogowe z paleta kolorow
            ColorDialog PaletaKolorow = new ColorDialog();
            PaletaKolorow.Color = JKbtnKolorLinii.BackColor;
            //zaznaczenie w PalecieKolorow bierzacego koloru formularza
            PaletaKolorow.Color = Kolor;
            //wyswietlenie palety kolorow i "odczytanie" wybranego koloru przez urzytkownika
            if (PaletaKolorow.ShowDialog() == DialogResult.OK)
            {
                //dokonujemy zmiany koloru tla formularza
                Kolor = PaletaKolorow.Color;
                JKbtnKolorLinii.BackColor = PaletaKolorow.Color;
                //zwolnienie egzemplarza PaletyKolorow
            }
            PaletaKolorow.Dispose();
        }

        private void JKbtnZapisBitMapy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby zapisać rysownice, należy wybrać miejsce docelowe zapisu", "Zapisywanie BitMapy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SaveFileDialog PlikDoZapisu = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (PlikDoZapisu.ShowDialog() == DialogResult.OK)
                {
                    JKpbRysownica.Image.Save(PlikDoZapisu.FileName);
                }
            }
        }

        private void JKbtnOdczytBitMapy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby odczytać plik z rysownicą, należy wybrać wcześniej zapisany plik", "Odczytywanie BitMapy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog PlikDoOdczytu = new OpenFileDialog();
            PlikDoOdczytu.ShowDialog();
            string sciezka = PlikDoOdczytu.FileName;
            try
            {
                JKpbRysownica.Image = Image.FromFile(sciezka);
            }
            catch (ArgumentException) { }

            Rysownica = Graphics.FromImage(JKpbRysownica.Image);
        }


        private void JKbtnKolorWyp_Click(object sender, EventArgs e)
        {
            ColorDialog PaletaKolorow = new ColorDialog();
            PaletaKolorow.Color = JKbtnKolorWyp.BackColor;
            // wyświetlenie Palety kolorów
            if (PaletaKolorow.ShowDialog() == DialogResult.OK)
                JKbtnKolorWyp.BackColor = PaletaKolorow.Color;
            // zwolnienie zasobu graficznego, czyli Palety kolorów
            PaletaKolorow.Dispose();
        }

        private void JKtrackbar_Scroll(object sender, EventArgs e)
        {
            if (JKtrackbar.Value==0)
            {
                GrubośćLinii = 1;
            }
            if (JKtrackbar.Value == 1)
            {
                GrubośćLinii = 2;
            }
            if (JKtrackbar.Value == 2)
            {
                GrubośćLinii = 3;
            }
            if (JKtrackbar.Value == 3)
            {
                GrubośćLinii = 4;
            }
            if (JKtrackbar.Value == 4)
            {
                GrubośćLinii = 5;
            }
        }

        private void JKbtnWłączPokazFigur_Click(object sender, EventArgs e)
        {
            //wyczyszczenie powierzchni graficznej
            Rysownica.Clear(JKpbRysownica.BackColor);
            JKpbRysownica.Refresh();
            //ustawienie stanu braku aktywności dla obsługiwanego przycisku
            //btnWłączPokazFigur.Enabled = false;
            //uaktywnienie przycisku zakończenia pokazu figur geometrycznych 
            //btnWyłączPokazFigur.Enabled = true;
            //rozpoznanie wybranego trybu pokazu
            if (JKrdbAutomatycznie.Checked)
            {
                //ustawienie numeru figury w zagarku
                timer1.Tag = 0;
                timer1.Enabled = true;
            }
            else
            {
                int N;
                N = int.Parse(JKtxtNumerFigury.Text);
                //wyznaczenie rozmiaru powierzchni graficznej
                int Xmax = JKpbRysownica.Width;
                int Ymax = JKpbRysownica.Height;
                //przesunięcie i wykreślenie figury o numerze N
                LFG[N].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                JKpbRysownica.Refresh();
                //uaktywnienie przycisków: Następna i Poprzedna
                //btnNastępna.Enabled = true;
                //btnPoprzednia.Enabled = true;
            }
            JKbtnNastepny.Enabled = true;
            JKbtnPoprzedni.Enabled = true;
        }

        private void JKcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)JKcbox.SelectedItem == "Ciągła (Solid)")
            {
                StylLinii = DashStyle.Solid;
            }
            if ((string)JKcbox.SelectedItem == "Linia kreskowa")
            {
                StylLinii = DashStyle.Dash;
            }
            if ((string)JKcbox.SelectedItem == "Linia kreskowo-kropkowa")
            {
                StylLinii = DashStyle.DashDot;
            }
            if ((string)JKcbox.SelectedItem == "Linia kreskowo-kropkowa-kropkowa")
            {
                StylLinii = DashStyle.DashDotDot;
            }
            if ((string)JKcbox.SelectedItem == "Linia kropkowa")
            {
                StylLinii = DashStyle.Dot;
            }
        }

        private void btnPrzesuńDoNowegoXY_Click(object sender, EventArgs e)
        {
            //pomocnicze deklaracje
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax; //rozmiar powierzchni graficznej
            //wyczyszczenie całej powierzchni
            Rysownica.Clear(JKpbRysownica.BackColor);
            //odczytanie rozmiaru powierzchni graficznej
            Xmax = JKpbRysownica.Width;
            Ymax = JKpbRysownica.Height;
            //przesuwanie z wykreśleniem wszystkich figur geometrycznych z TFG
            for (int i = 0; i < LFG.Count; i++)
            {
                //wylosowanie nowego położenia 
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                //przesunięcie i-tej figury geometrycznej
                LFG[i].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xn, Yn);
            }
            //odświeżenie powierzchni graficznej
            JKpbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymazanie figury aktualnie wykreślonej
            LFG[(int)timer1.Tag].Wymaż(JKpbRysownica, Rysownica);
            //wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = JKpbRysownica.Width;
            int Ymax = JKpbRysownica.Height;
            //wyznaczenie indexu figury do pokazu
            timer1.Tag = ((int)timer1.Tag + 1) % (LFG.Count - 1);
            //przesunięcie i wykreślenie figury geometrycznej o numerze
            LFG[(int)timer1.Tag].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            JKpbRysownica.Refresh();
        }

        private void JKbtnWyłączPokazFigur_Click(object sender, EventArgs e)
        {
            //wyczyszczenie powierzchni graficznej
            Rysownica.Clear(JKpbRysownica.BackColor);
            timer1.Enabled = false;
            //btnNastępna.Enabled = false;
            JKtxtNumerFigury.Enabled = false;
            //wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = JKpbRysownica.Width;
            int Ymax = JKpbRysownica.Height;
            int Xn, Yn;
            Random rnd = new Random();
            //wykreślenie wszystkich figur geometrycznych z TFG
            for (int i = 0; i < LFG.Count; i++)
            {
                //losowanie nowego położenia
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                LFG[i].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xn, Yn);
            }
            //odświeżenie powierzchni graficznej
            JKpbRysownica.Refresh();
        }

        private void JKbtnNastepny_Click(object sender, EventArgs e)
        {
            int N = int.Parse(JKtxtNumerFigury.Text);
            //wymazanie figury geometrycznej o numerze N
            LFG[N].Wymaż(JKpbRysownica, Rysownica);
            //wyznaczenie numeru następnej figury do wykreślenia
            if (N < (LFG.Count - 1))
                N++;
            else
                N = 0;
            //wpisanie nowego numeru do kontrolki textBox
            JKtxtNumerFigury.Text = N.ToString();
            int Xmax = JKpbRysownica.Width;
            int Ymax = JKpbRysownica.Height;
            //wykreślenie nowej figury geometrycznej 
            LFG[N].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            JKpbRysownica.Refresh();
        }

        private void JKbtnPoprzedni_Click(object sender, EventArgs e)
        {
            int N = int.Parse(JKtxtNumerFigury.Text);
            //wymazanie figury geometrycznej o numerze N
            LFG[N].Wymaż(JKpbRysownica, Rysownica);
            //wyznaczenie numeru następnej figury do wykreślenia
            if (N == 0)
                N = LFG.Count - 1;
            else
                N--;
            //wpisanie nowego numeru do kontrolki textBox
            JKtxtNumerFigury.Text = N.ToString();
            int Xmax = JKpbRysownica.Width;
            int Ymax = JKpbRysownica.Height;
            //wykreślenie nowej figury geometrycznej 
            LFG[N].PrzesuńDoNowegoXY(JKpbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            JKpbRysownica.Refresh();
        }

        private void JKrdbManualny_CheckedChanged_1(object sender, EventArgs e)
        {
            //uaktywnienie kontrolki txtNumerFigury
            JKtxtNumerFigury.Enabled = true;
            //wpisanie domyślnego numeru figury w TFG
            JKtxtNumerFigury.Text = 0.ToString();
        }

        private void ProjektIndywidualnyNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Oknomessage = MessageBox.Show("Czy na pewno chcesz zamknąć ten formularz wrócić do kokpitu?", this.Text, MessageBoxButtons.YesNo);
            //sprawdzenie podjetej decyzji przez uzytkownika programu
            if (Oknomessage == DialogResult.Yes)
            {//odszukanie formularza glownego Kokpit w OpenForms
                foreach (Form Formularz in Application.OpenForms)
                {//ukrycie biezacego formularza
                    this.Hide();
                    //odslniecie znalezionego formularza glownego
                    Formularz.Show();
                    //bezwarunkowe wyjscie z metody obslugi zdarzenia
                    return;
                }
                //gdy jestesmy tutaj, to jest to sytuacja awaryjna
                //wyswietlenie komunikatu o awarii
                MessageBox.Show("UWAGA: wystąpiła awaria w działaniu programu i program musi zostać zamknięty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.ExitThread();
            }
            else
            {//skasowanie zdarzenia FormClosing
                e.Cancel = true;
            }
        }
    }
}
