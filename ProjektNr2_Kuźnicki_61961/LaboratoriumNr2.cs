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
using static ProjektNr2_Kuźnicki_61961.FiguryGeometryczne;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

namespace ProjektNr2_Kuźnicki_61961
{
    public partial class LaboratoriumNr2 : Form
    {
        //deklaracje pomocnicze
        const int Margines = 10;
        //deklaracja powierzchni graficznej
        Graphics Rysownica;
        //deklaracja tablicy TFG (Tablica Figur Geometrycznych)
        Punkt[] TFG;
        int IndexTFG;
        public LaboratoriumNr2()
        {
            InitializeComponent();
            //ustalnie rozmiarów formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + Margines,
                                      Screen.PrimaryScreen.Bounds.Y + Margines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.80F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75F);
            this.StartPosition = FormStartPosition.Manual;
            //ustalenie lokalizacji kontrolki PictureBox
            pbRysownica.Location = new Point(this.Left + 25 * Margines, this.Top + 5 * Margines);
            pbRysownica.Size = new Size((int)(this.Width * 0.6F), (int)(this.Height * 0.6F));
            //utworzenie BitMapy i jej podpięcie do kontrolki PictureBox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utworzenie egzemplarza powierzchni graficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            //sprawdzenie w kontrolce txtN czy jest wpisana poprawnie liczba figur
            if (!ushort.TryParse(txtN.Text, out N))
            {
                //zapalenie kontrolki errorProvider
                errorProvider1.SetError(txtN, "ERROR: w zapisie podanej liczby figur geometrycznych wystpi niedozwolony znak");
                return;
            }
            //sprawdzenie czy zostay wybrane figury geometryczne do prezentacji
            if (chlbFiguryGeometryczne.CheckedItems.Count > 0)
            {
                //ustawienie stanu braku aktywności dla kontrolki txtN
                txtN.Enabled = false;
                //uaktywienie przycisku poleceń START
                btnStart.Enabled = true;
            }
            else
            {
                //sygnalizacja braku danych wejściowych
                errorProvider1.SetError(chlbFiguryGeometryczne, "UWAGA: musisz wybrać co najmniej jedną figurę w kontrolce CheckedListBox");
            }

        }

        private void chlbFiguryGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            //sprawdzenie czy  zostałą podana liczba figur do prezentacji
            if (!txtN.Enabled)
                //uaktywienie przycisku poleceń START
                btnStart.Enabled = true;
        }

        private void LaboratoriumNr2_Load(object sender, EventArgs e)
        {
            //lokalizacja kontrolki CheckedListBox
            chlbFiguryGeometryczne.Location = new Point(pbRysownica.Location.X + pbRysownica.Width + Margines, pbRysownica.Location.Y);
        }

        private void btnPrzesuńDoNowegoXY_Click_1(object sender, EventArgs e)
        {
            //pomocnicze deklaracje
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax; //rozmiar powierzchni graficznej
            //wyczyszczenie całej powierzchni
            Rysownica.Clear(pbRysownica.BackColor);
            //odczytanie rozmiaru powierzchni graficznej
            Xmax = pbRysownica.Width;
            Ymax = pbRysownica.Height;
            //przesuwanie z wykreśleniem wszystkich figur geometrycznych z TFG
            for (int i = 0; i < TFG.Length; i++)
            {
                //wylosowanie nowego położenia 
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                //przesunięcie i-tej figury geometrycznej
                TFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            ushort LiczbaWybranychFG;
            int Xmax, Ymax;
            int Xp, Yp;
            Color Kolor;
            DashStyle StylLinii;
            float GrubośćLinii;
            Random rnd = new Random();
            //pobranie liczby figur z kontrolki txtN
            LiczbaWybranychFG = ushort.Parse(txtN.Text);
            //utworzenie egzemplarza tablicy TFG
            TFG = new Punkt[LiczbaWybranychFG];
            IndexTFG = 0;
            CheckedListBox.CheckedItemCollection WybraneFG = chlbFiguryGeometryczne.CheckedItems;
            //odczytanie rozmiarów powierzchni graficznej
            Xmax = pbRysownica.Width;
            Ymax = pbRysownica.Height;
            //tworzenie egzemplarzy figur geometrycznych i wpisanie ich refencji do TFG a następnie ich wykreślenie
            for (ushort i = 0; i < LiczbaWybranychFG; i++)
            {
                //losowanie współrędnych położenia figur geometrycznych
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                Kolor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                switch (rnd.Next(0, 5))
                {
                    case 0: StylLinii = DashStyle.Solid; break;
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.Dot; break;
                    case 3: StylLinii = DashStyle.DashDot; break;
                    case 4: StylLinii = DashStyle.DashDotDot; break;
                    default:
                        {
                            MessageBox.Show("Przepraszamy, ale takiego stylu linii jeszcze nie mamy");
                            StylLinii = DashStyle.Solid;
                            break;
                        }
                }//od switcha
                //wylosowanie grubości linii
                GrubośćLinii = (float)(rnd.NextDouble() * ((double)Margines - 0.5) + 0.5);
                //losowanie figury jednej z wybranej
                switch (WybraneFG[rnd.Next(WybraneFG.Count)].ToString())
                {
                    case "Punkt":
                        {
                            //utworzenie egzemplarza Punktu i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Punkt(Xp, Yp, Kolor);
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            //przejście z IndexTFG do następnej wolnej pozycji TFG
                            IndexTFG++;
                            break;
                        }
                    case "Linia":
                        {
                            //wylosowanie współrzędnycj końca linii
                            int Xk = rnd.Next(Margines, Xmax - Margines);
                            int Yk = rnd.Next(Margines, Ymax - Margines);
                            //utworzenie egzemplarza Linii i wpisanie jej referencji 
                            TFG[IndexTFG] = new Linia(Xp, Yp, Xk, Yk, Kolor, StylLinii, GrubośćLinii);
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            //przejście z IndexTFG do następnej wolnej pozycji TFG
                            IndexTFG++;
                            break;
                        }
                    case "Elipsa":
                        {
                            //deklaracje pomocnicze
                            int OśDuża, OśMała;
                            //wylosowanie osi dużej i małej                     
                            OśDuża = rnd.Next(Margines, Xmax / 4);
                            OśMała = rnd.Next(Margines, Ymax / 6);
                            //utworzenie egzemplarza elipsy i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Elipsa(Xp, Yp, OśDuża, OśMała, Kolor, StylLinii, GrubośćLinii);
                            //wykreślenie Elipsy
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            //przeniesienie IndexTFG do wolnej pozycji w TFG
                            IndexTFG++;
                            break;
                        }
                    case "Okrąg":
                        {
                            int Promień = rnd.Next(Margines, Xmax / 4);
                            TFG[IndexTFG] = new Okrąg(Xp, Yp, Promień, Kolor, StylLinii, GrubośćLinii);
                            //wykreslenie okregu
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            IndexTFG++;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("UWAGA: tej figury jeszcze nie kreślimy! Przepraszamy");
                            break;
                        }
                }
            }//odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //ustawienie stanu braku aktywności dla przycisku poleceń Start
            btnStart.Enabled = false;
            //uaktywienie kolejnych przycisków funkcjonalnych i kontrolek  
            btnPrzesuńDoNowegoXY.Enabled = true;
            gpbTrybPokazu.Enabled = true;
            btnWłączPokazFigur.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymazanie figury aktualnie wykreslonej
            TFG[(int)timer1.Tag].Wymaż(pbRysownica, Rysownica);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //wyznaczenie indexu figury do pokazu
            timer1.Tag = ((int)timer1.Tag + 1) % (TFG.Length - 1);
            //przeusniecie i wykrelsenie figury geometrycznej o numerze timer1.Tag
            TFG[(int)timer1.Tag].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            //odswiezenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void txtNumerFigury_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            //zgaszenie kontrolki errorprovider
            errorProvider1.Dispose();
            //sprawdzenie na poprawnosc zapisu N
            if (!ushort.TryParse(txtNumerFigury.Text, out N))
            {//jest blad
                errorProvider1.SetError(txtNumerFigury, "ERROR: w podanym zapisie numeru figury geometrycznej wystąpił niedozwolony znak");
                return;
            }
            //sprawdzenie na wartosc N
            if (N > (TFG.Length - 1))
            {//jest blad
                errorProvider1.SetError(txtNumerFigury, "ERROR: podany numer (indeks) figury geometrycznej wykracza poza zakres indeksu TFG");
                return;
            }
        }

        private void rdbManualny_CheckedChanged(object sender, EventArgs e)
        {
            //uaktywnienie kontrolki txtNumerFigury
            txtNumerFigury.Enabled = true;
            //wpisanie domyslnego numeru (indeksu) figury w TFG
            txtNumerFigury.Text = 0.ToString();
        }

        private void btnWłączPokazFigur_Click(object sender, EventArgs e)
        {
            //wyczyszczenie powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();
            //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku
            btnWłączPokazFigur.Enabled = false;
            //uaktywnienie przycisku zakonczenia pokazu figur geometrycznych
            btnWyłączPokazFigur.Enabled = true;
            //rozpoznanie wybranego trybu pokazu
            if (rdbAutomatycznie.Checked)
            {
                //ustawienie numeru (indeksu) figury w zegarze
                timer1.Tag = 0;
                //wlaczenie zegara
                timer1.Enabled = true;
            }
            else
            {
                int N;
                N = int.Parse(txtNumerFigury.Text);
                //wyznaczenie rozmiaru powierzchni graficznej
                int Xmax = pbRysownica.Width;
                int Ymax = pbRysownica.Height;
                TFG[N].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                pbRysownica.Refresh();
                //uaktywnienie przycisków
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
            }
        }

        private void btnWyłączPokazFigur_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            timer1.Enabled=false;
            btnWyłączPokazFigur.Enabled = false;
            btnWłączPokazFigur.Enabled = true;
            btnPoprzednia.Enabled=false;
            btnNastepna.Enabled = false;
            txtNumerFigury.Enabled = false;
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int Xn, Yn;
            Random rnd = new Random();
            //wykreslenie wszystkich figur geometrycznych z TFG
            for (int i = 0; i < TFG.Length; i++)
            {
                //losowanie nowego polozenia
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                //przesuniecie z wykresleniem i-tej figury geometrycznej
                TFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            //odswiezenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNumerFigury.Text);
            // wymazanie figury geometrycznej o numerze (indeksie) N
            TFG[N].Wymaż(pbRysownica, Rysownica);
            //wyznaczenie numeru nastepnej figury do wykreslenia
            if (N < TFG.Length - 1)
                N++;
            else
                N = 0;
            //wpisanie nowego numeru do kontrolki textbox
            txtNumerFigury.Text = N.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //wykreslenie nowej figury geometrycznej
            TFG[N].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNumerFigury.Text);
            // wymazanie figury geometrycznej o numerze (indeksie) N
            TFG[N].Wymaż(pbRysownica, Rysownica);
            if (N == 0)
                N = TFG.Length - 1;
            else
                N--;
            // wpisanie nowego numeru do kontrolki textbox
            txtNumerFigury.Text = N.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //wykreslenie nowej figury geometrycznej
            TFG[N].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }
    }
}
