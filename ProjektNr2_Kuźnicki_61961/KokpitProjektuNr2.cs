using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr2_Kuźnicki_61961
{
    public partial class KokpitProjektuNr2 : Form
    {
        public KokpitProjektuNr2()
        {
            InitializeComponent();
        }

        private void btnLaboratorium_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                if (Formularz.Name == "LaboratoriumNr2")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            LaboratoriumNr2 FormLaboratoriumNr2 = new LaboratoriumNr2();
            this.Hide();
            FormLaboratoriumNr2.Show();
        }

        private void JKbtnProjektIndywidualny_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                if (Formularz.Name == "ProjektIndywidualnyNr2")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            ProjektIndywidualnyNr2 FormProjektIndywidualnyNr2 = new ProjektIndywidualnyNr2();
            this.Hide();
            FormProjektIndywidualnyNr2.Show();
        }

        private void KokpitProjektuNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*utworzenie okna dialogowego i jego wyswietlenie dla spytania uzytkownika, czy na pewno
            chce zamknac formularz i zakonczyc dzialanie programu*/
            DialogResult Oknomessage = MessageBox.Show("Czy na pewno chcesz zamknąć formularz główny i zakończyć działanie programu?", this.Text, MessageBoxButtons.YesNo);
            //sprawdzenie podjetej decyzji przez uzytkownika programu
            if (Oknomessage == DialogResult.Yes)
            {//zamkniecie wszystkich formularzy i zakonczenie dzialania programu
                Application.ExitThread();
            }
            else
            {//skasowanie zdarzenia FormClosing
                e.Cancel = true;
            }
        }
    }
}
