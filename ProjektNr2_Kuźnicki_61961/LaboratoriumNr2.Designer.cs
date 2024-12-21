namespace ProjektNr2_Kuźnicki_61961
{
    partial class LaboratoriumNr2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTrybPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatycznie = new System.Windows.Forms.RadioButton();
            this.btnPrzesuńDoNowegoXY = new System.Windows.Forms.Button();
            this.btnWłączPokazFigur = new System.Windows.Forms.Button();
            this.btnWyłączPokazFigur = new System.Windows.Forms.Button();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpbTrybPokazu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.Color.Khaki;
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRysownica.Location = new System.Drawing.Point(204, 78);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(713, 480);
            this.pbRysownica.TabIndex = 1;
            this.pbRysownica.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj liczbę figur \r\ngeometrycznych do prezentacji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(65, 62);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(65, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(878, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zaznacz figury\r\n geometryczne do prezentacji";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chlbFiguryGeometryczne
            // 
            this.chlbFiguryGeometryczne.FormattingEnabled = true;
            this.chlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Prostokąt",
            "Okrąg",
            "Kwadrat",
            "itd."});
            this.chlbFiguryGeometryczne.Location = new System.Drawing.Point(923, 78);
            this.chlbFiguryGeometryczne.Name = "chlbFiguryGeometryczne";
            this.chlbFiguryGeometryczne.Size = new System.Drawing.Size(137, 109);
            this.chlbFiguryGeometryczne.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpbTrybPokazu
            // 
            this.gpbTrybPokazu.Controls.Add(this.rdbManualny);
            this.gpbTrybPokazu.Controls.Add(this.rdbAutomatycznie);
            this.gpbTrybPokazu.Enabled = false;
            this.gpbTrybPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.errorProvider1.SetIconAlignment(this.gpbTrybPokazu, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.gpbTrybPokazu.Location = new System.Drawing.Point(204, 574);
            this.gpbTrybPokazu.Name = "gpbTrybPokazu";
            this.gpbTrybPokazu.Size = new System.Drawing.Size(356, 100);
            this.gpbTrybPokazu.TabIndex = 10;
            this.gpbTrybPokazu.TabStop = false;
            this.gpbTrybPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(7, 55);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(95, 23);
            this.rdbManualny.TabIndex = 1;
            this.rdbManualny.Text = "Manualny";
            this.rdbManualny.UseVisualStyleBackColor = true;
            this.rdbManualny.CheckedChanged += new System.EventHandler(this.rdbManualny_CheckedChanged);
            // 
            // rdbAutomatycznie
            // 
            this.rdbAutomatycznie.AutoSize = true;
            this.rdbAutomatycznie.Checked = true;
            this.rdbAutomatycznie.Location = new System.Drawing.Point(7, 26);
            this.rdbAutomatycznie.Name = "rdbAutomatycznie";
            this.rdbAutomatycznie.Size = new System.Drawing.Size(187, 23);
            this.rdbAutomatycznie.TabIndex = 0;
            this.rdbAutomatycznie.TabStop = true;
            this.rdbAutomatycznie.Text = "Automatyczny zegarowy";
            this.rdbAutomatycznie.UseVisualStyleBackColor = true;
            // 
            // btnPrzesuńDoNowegoXY
            // 
            this.btnPrzesuńDoNowegoXY.Enabled = false;
            this.btnPrzesuńDoNowegoXY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesuńDoNowegoXY.Location = new System.Drawing.Point(47, 152);
            this.btnPrzesuńDoNowegoXY.Name = "btnPrzesuńDoNowegoXY";
            this.btnPrzesuńDoNowegoXY.Size = new System.Drawing.Size(134, 130);
            this.btnPrzesuńDoNowegoXY.TabIndex = 7;
            this.btnPrzesuńDoNowegoXY.Text = "Przesuń wszystkie figury do \r\nnowego wylosowanego połozenia";
            this.btnPrzesuńDoNowegoXY.UseVisualStyleBackColor = true;
            this.btnPrzesuńDoNowegoXY.Click += new System.EventHandler(this.btnPrzesuńDoNowegoXY_Click_1);
            // 
            // btnWłączPokazFigur
            // 
            this.btnWłączPokazFigur.Enabled = false;
            this.btnWłączPokazFigur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnWłączPokazFigur.Location = new System.Drawing.Point(53, 569);
            this.btnWłączPokazFigur.Name = "btnWłączPokazFigur";
            this.btnWłączPokazFigur.Size = new System.Drawing.Size(128, 105);
            this.btnWłączPokazFigur.TabIndex = 8;
            this.btnWłączPokazFigur.Text = "Włącz pokaz figur geometrycznych";
            this.btnWłączPokazFigur.UseVisualStyleBackColor = true;
            this.btnWłączPokazFigur.Click += new System.EventHandler(this.btnWłączPokazFigur_Click);
            // 
            // btnWyłączPokazFigur
            // 
            this.btnWyłączPokazFigur.Enabled = false;
            this.btnWyłączPokazFigur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnWyłączPokazFigur.Location = new System.Drawing.Point(1005, 569);
            this.btnWyłączPokazFigur.Name = "btnWyłączPokazFigur";
            this.btnWyłączPokazFigur.Size = new System.Drawing.Size(128, 105);
            this.btnWyłączPokazFigur.TabIndex = 9;
            this.btnWyłączPokazFigur.Text = "Wyłącz pokaz figur geometrycznych";
            this.btnWyłączPokazFigur.UseVisualStyleBackColor = true;
            this.btnWyłączPokazFigur.Click += new System.EventHandler(this.btnWyłączPokazFigur_Click);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNastepna.Location = new System.Drawing.Point(882, 625);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(117, 50);
            this.btnNastepna.TabIndex = 11;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPoprzednia.Location = new System.Drawing.Point(566, 625);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(117, 49);
            this.btnPoprzednia.TabIndex = 12;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(667, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Indeks (Numer figury geometrycznej)";
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Enabled = false;
            this.txtNumerFigury.Location = new System.Drawing.Point(741, 603);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(100, 20);
            this.txtNumerFigury.TabIndex = 14;
            this.txtNumerFigury.TextChanged += new System.EventHandler(this.txtNumerFigury_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LaboratoriumNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 736);
            this.Controls.Add(this.txtNumerFigury);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoprzednia);
            this.Controls.Add(this.btnNastepna);
            this.Controls.Add(this.gpbTrybPokazu);
            this.Controls.Add(this.btnWyłączPokazFigur);
            this.Controls.Add(this.btnWłączPokazFigur);
            this.Controls.Add(this.btnPrzesuńDoNowegoXY);
            this.Controls.Add(this.chlbFiguryGeometryczne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Name = "LaboratoriumNr2";
            this.Text = "LaboratoriumNr2";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpbTrybPokazu.ResumeLayout(false);
            this.gpbTrybPokazu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chlbFiguryGeometryczne;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPrzesuńDoNowegoXY;
        private System.Windows.Forms.Button btnWyłączPokazFigur;
        private System.Windows.Forms.Button btnWłączPokazFigur;
        private System.Windows.Forms.GroupBox gpbTrybPokazu;
        private System.Windows.Forms.RadioButton rdbAutomatycznie;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Timer timer1;
    }
}