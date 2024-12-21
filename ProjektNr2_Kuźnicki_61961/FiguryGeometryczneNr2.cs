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
    internal class FiguryGeometryczneNr2
    {
        //deklaracja głównej klasy bazowej 
        public class Punkt
        {
            //deklaracje pomocniczne
            const int PromieńPunktu = 5;
            //deklaracja typu wyliczeniowego znaczników figur geometrycznych
            public enum FiguryGeometryczne : byte
            { Punkt, Linia, Elipsa, Prostokąt, Okrąg,Kwadrat, Koło, FillRectangle, WielokątForemny, FillElipse, WielokątWypełniony, DrawPie, FillPie, DrawArc };
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
                KolorWypełnienia = Color.Red;
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
            protected int Szerokość, Wysokość;
            public Elipsa(int x, int y, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.Elipsa;
                //ustawienie atrybutu widoczności
                this.Szerokość=Szerokość;
                this.Wysokość = Wysokość;
                this.StylLinii= StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    Pióro.DashStyle = StylLinii;
                    Rysownica.DrawEllipse(Pióro,X, Y, Szerokość, Wysokość);
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Rysownica.DrawEllipse(Pióro, X, Y, Szerokość, Wysokość);
                        Widoczny = false;
                    }
                }
            }
        }
        public class Okrąg : Elipsa
        {
            //deklaracja konstruktora
            public Okrąg(int x, int y, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, Szerokość, Wysokość, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = FiguryGeometryczne.Okrąg;
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
            }
        }
        public class Prostokąt : Punkt
        {
            //deklaracje atrybutów niezbędnych do wykreślenia prostokątu
            protected int Szerokość, Wysokość;
            //deklaracja konstruktora
            public Prostokąt(int Xp, int Yp, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {

                Figura = FiguryGeometryczne.Prostokąt;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
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
                    Rysownica.DrawRectangle(Pióro, X, Y, Szerokość, Wysokość);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {

                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        //ustawienie stylu linii
                        Pióro.DashStyle = StylLinii;
                        //wymazanie linii
                        Rysownica.DrawRectangle(Pióro, X, Y, Szerokość, Wysokość);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class Kwadrat : Prostokąt
        {
            //deklaracja konstruktora
            public Kwadrat(int x, int y, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(x, y, Szerokość, Wysokość, KolorLinii, StylLinii, GrubośćLinii)
            {
                Figura = FiguryGeometryczne.Kwadrat;
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
            }
        }
        public class Koło : Punkt
        {
            protected int Szerokość, Wysokość;
            //deklaracja konstruktora
            public Koło(int Xp, int Yp, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.Koło;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kolor))
                {
                    //wykreślenie linii
                    Rysownica.FillEllipse(Pędzel, X, Y, Szerokość, Wysokość);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        //wymazanie linii
                        Rysownica.FillEllipse(Pędzel, X, Y, Szerokość, Wysokość);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class FillRectangle : Punkt
        {
            protected int Szerokość, Wysokość;
            //deklaracja konstruktora
            public FillRectangle(int Xp, int Yp, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.FillRectangle;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kolor))
                {
                    //wykreślenie linii
                    Rysownica.FillRectangle(Pędzel, X, Y, Szerokość, Wysokość);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        //wymazanie linii
                        Rysownica.FillRectangle(Pędzel, X, Y, Szerokość, Wysokość);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class WielokątForemny : Punkt
        {
            private ushort StopienWielokata;
            private int R;
            private double KatMiedzyWierzcholkami;
            private double KatPolozeniaPierwszegoWierzcholka;

            public WielokątForemny(int Xp, int Yp, ushort stopienWielokata, int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.WielokątForemny;
                // set the polygon properties
                this.StopienWielokata = stopienWielokata;
                this.R = R;
                KatMiedzyWierzcholkami = 360.0 / stopienWielokata;
                KatPolozeniaPierwszegoWierzcholka = 0.0;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GrubośćLinii))
                {
                    // create an array of vertices for the polygon
                    Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                    for (int i = 0; i < StopienWielokata; i++)
                    {
                        WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                    }

                    // draw the polygon
                    Rysownica.DrawPolygon(Pioro, WierzcholkiWielokata);

                    // set the visibility attribute
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        // create an array of vertices for the polygon
                        Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                        for (int i = 0; i < StopienWielokata; i++)
                        {
                            WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                            WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        }

                        // draw the polygon
                        Rysownica.DrawPolygon(Pioro, WierzcholkiWielokata);

                        // set the visibility attribute
                        Widoczny = false;
                    }
            }
        }
        public class FillElipse : Punkt
        {
            protected int Szerokość, Wysokość;
            //deklaracja konstruktora
            public FillElipse(int Xp, int Yp, int Szerokość, int Wysokość, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.FillElipse;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kolor))
                {
                    //wykreślenie linii
                    Rysownica.FillEllipse(Pędzel, X, Y, Szerokość, Wysokość);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        //wymazanie linii
                        Rysownica.FillEllipse(Pędzel, X, Y, Szerokość, Wysokość);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class WielokątWypełniony : Punkt
        {
            private ushort StopienWielokata;
            private int R;
            private double KatMiedzyWierzcholkami;
            private double KatPolozeniaPierwszegoWierzcholka;

            public WielokątWypełniony(int Xp, int Yp, ushort stopienWielokata, int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.WielokątWypełniony;
                // set the polygon properties
                this.StopienWielokata = stopienWielokata;
                this.R = R;
                KatMiedzyWierzcholkami = 360.0 / stopienWielokata;
                KatPolozeniaPierwszegoWierzcholka = 0.0;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kolor))
                {
                    // create an array of vertices for the polygon
                    Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                    for (int i = 0; i < StopienWielokata; i++)
                    {
                        WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                    }

                    // draw the polygon
                    Rysownica.FillPolygon(Pędzel, WierzcholkiWielokata);

                    // set the visibility attribute
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        // create an array of vertices for the polygon
                        Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                        for (int i = 0; i < StopienWielokata; i++)
                        {
                            WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                            WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        }

                        // draw the polygon
                        Rysownica.FillPolygon(Pędzel, WierzcholkiWielokata);

                        // set the visibility attribute
                        Widoczny = false;
                    }
            }
        }
        public class DrawPie : Punkt
        {
            protected int Szerokość, Wysokość, KątPoczątkowy, KątKońcowy;
            //deklaracja konstruktora
            public DrawPie(int Xp, int Yp, int Szerokość, int Wysokość, int KątPoczątkowy, int KątKońcowy, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.DrawPie;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.KątPoczątkowy = KątPoczątkowy;
                this.KątKońcowy = KątKońcowy;
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
                    Rysownica.DrawPie(Pióro, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
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
                        Rysownica.DrawPie(Pióro, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class FillPie : Punkt
        {
            protected int Szerokość, Wysokość, KątPoczątkowy, KątKońcowy;
            //deklaracja konstruktora
            public FillPie(int Xp, int Yp, int Szerokość, int Wysokość, int KątPoczątkowy, int KątKońcowy, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.FillPie;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.KątPoczątkowy = KątPoczątkowy;
                this.KątKońcowy = KątKońcowy;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kolor))
                {
                    //wykreślenie linii
                    Rysownica.FillPie(Pędzel, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        //wymazanie linii
                        Rysownica.FillPie(Pędzel, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        public class DrawArc : Punkt
        {
            protected int Szerokość, Wysokość, KątPoczątkowy, KątKońcowy;
            //deklaracja konstruktora
            public DrawArc(int Xp, int Yp, int Szerokość, int Wysokość, int KątPoczątkowy, int KątKońcowy, Color KolorLinii, DashStyle StylLinii, float GrubośćLinii) : base(Xp, Yp, KolorLinii)
            {
                //ustawienie znacznika Figury: Elipsa
                Figura = FiguryGeometryczne.DrawArc;
                //ustawienie atrybutu widoczności
                Widoczny = false;
                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.KątPoczątkowy = KątPoczątkowy;
                this.KątKońcowy = KątKońcowy;
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
                    Rysownica.DrawArc(Pióro, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                    //ustawienie atrybutu widoczności
                    Widoczny = true;
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
                        Rysownica.DrawArc(Pióro, X, Y, Szerokość, Wysokość, KątPoczątkowy, KątKońcowy);
                        //aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
    }
}
