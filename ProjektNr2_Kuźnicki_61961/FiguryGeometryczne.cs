using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr2_Kuźnicki_61961
{
    internal class FiguryGeometryczne
    {
        //deklaracja głównej klasy bazowej 
        public class Punkt
        {
            //deklaracje pomocniczne
            const int PromieńPunktu = 5;
            //deklaracja typu wyliczeniowego znaczników figur geometrycznych
            public enum FiguryGeometryczne : byte
            { Punkt, Linia, Elipsa, Prostokąt, Okrąg, Kwadrat };
            //deklaracja atrybutów klasy Punkt
            public FiguryGeometryczne Figura
            {
                get;
                protected set;
            }
            //atrybut widoczności
            public bool Widoczny
            {
                get;
                protected set;
            }
            public int ŚredniaPunktu
            {
                get;
                protected set;
            }
            public int X
            {
                get;
                protected set;
            }
            public int Y
            {
                get;
                protected set;
            }
            public Color Kolor
            {
                get;
                protected set;
            }
            //deklaracje atrybutów ważnych dla klas potomnych
            public float GrubośćLinii
            {
                get;
                protected set;
            }
            public DashStyle StylLinii
            {
                get;
                protected set;
            }
            public Color KolorWypełnienia
            {
                get;
                protected set;
            }
            //deklaracje konstruktorów
            public Punkt(int X, int Y)
            {
                //ustawienie znacznika figury
                Figura = FiguryGeometryczne.Punkt;
                Widoczny = false;
                ŚredniaPunktu = 2 * PromieńPunktu;
                this.X = X;
                this.Y = Y;
                //ustawienie wartości domyślnych dla pozostałych atrybutów klasy Punkt
                Kolor = Color.Black;
                GrubośćLinii = 1.0F;
                StylLinii = DashStyle.Solid;
                KolorWypełnienia = Color.White;
            }
            public Punkt(int X, int Y, Color KolorPunktu) : this(X, Y)
            {
                Kolor = KolorPunktu;
            }
            public Punkt(int X, int Y, Color KolorPunktu, int ŚrednicaPunktu) : this(X, Y, KolorPunktu)
            {
                this.ŚredniaPunktu = ŚredniaPunktu;
            }
            //deklaracja metod
            //prywatne

            //publiczne

            //wirtualne
            public virtual void Wykreśl(Graphics Rysownica)
            {
                //wersja 2
                SolidBrush Pędzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pędzel, X - ŚredniaPunktu / 2, Y - ŚredniaPunktu / 2,
                    ŚredniaPunktu, ŚredniaPunktu);
                //ustawienie atrybutu widoczności
                Widoczny = true;
                //zwolnienie Pędzla
                Pędzel.Dispose();
                //wersja 2
                using (SolidBrush Pędzel2 = new SolidBrush(Kolor))
                {
                    Rysownica.FillEllipse(Pędzel2, X - ŚredniaPunktu / 2, Y - ŚredniaPunktu / 2,
                    ŚredniaPunktu, ŚredniaPunktu);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie atrybutu widoczności
                if (Widoczny)
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pędzel, X - ŚredniaPunktu / 2, Y - ŚredniaPunktu / 2,
                        ŚredniaPunktu, ŚredniaPunktu);
                        //zgaszenie atrybutu widoczności
                        Widoczny = false;
                    }
            }
            public virtual void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                //wpisanie do atrybutów nowych X i Y wartości współrzędnych nowego położenia Punktu
                X = Xn;
                Y = Yn;
                Wykreśl(Rysownica);
            }
        } //koniec klasy Punkt
        // deklaracja klasy Linia
        public class Linia : Punkt
        {
            //dodanie deklaracji niezbędnych dla wykreślenia Linii
            int Xk, Yk;
            //deklaracja konstruktorów
            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                //ustawienie znacznika FiguryGeometrycznej: Linia
                Figura = FiguryGeometryczne.Linia;
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika FiguryGeometrycznej: Linia
                Figura = FiguryGeometryczne.Linia;
                this.Xk = Xk;
                this.Yk = Yk;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    //ustawienie stylu linii
                    Pióro.DashStyle = StylLinii;
                    //wykreślenie linii
                    Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                        //zgaszenie atrybutu widoczności
                        Widoczny = false;
                    }
            }
            public override void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                /*deklaracje pomocniczne Dx - przyrost zmiany współrzędnej X
                                         Dy - przyrost zmiany współrzędnej Y
                 */
                int Dx, Dy;
                //wyznaczenie przyrostu zmiany współrzędnej X
                if (Xn > X)
                    Dx = Xn - X;
                else
                    Dx = X - Xn;
                //wyznaczenie przyrostu zmiany współrzędnej Y
                if (Yn > Y)
                    Dy = Yn - Y;
                else
                    Dy = Yn - Yn;
                //przechowanie nowych wartości współrzędnych początku końca linii
                X = Xn;
                Y = Yn;
                Xk = (Xk + Dx) % Kontrolka.Width;
                Yk = (Yk + Dy) % Kontrolka.Height;
                //wykreślenie linii w nowym położeniu 
                Wykreśl(Rysownica);
            }
        }// koniec linii
        //deklaracja klasy potomnej Elipsa
        public class Elipsa : Punkt
        {
            //deklaracje atrybutów niezbędnych do wykreślenia Elipsy
            protected int OśDuża, OśMała;
            //deklaracja konstruktora
            public Elipsa(int x, int y, int OśDuża, int OśMała, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.Elipsa;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.OśDuża = OśDuża;
                this.OśMała = OśMała;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    //ustawienie stylu linii
                    Pióro.DashStyle = StylLinii;
                    //wykreślenie linii
                    Rysownica.DrawEllipse(Pióro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);
                    //ustawienie atrybutu widoczności
                    Widoczny = false;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        //ustawienie stylu linii
                        Pióro.DashStyle = StylLinii;
                        //wymazanie linii
                        Rysownica.DrawEllipse(Pióro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class Okrąg : Elipsa
        {
            protected int Promień
            {
                get { return OśDuża; }
                set 
                {
                    OśDuża = value;
                    OśMała = value;
                }
            }
            //deklaracja konstruktora
            public Okrąg(int x, int y, int Promień, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii): base (x, y, 2 * Promień, 2*Promień, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = FiguryGeometryczne.Okrąg;
                Widoczny=false;
                this.Promień = Promień;
            }
        }
    }
}
