namespace ProjektNr2_Kuźnicki_61961
{
    partial class ProjektIndywidualnyNr2
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
            this.JKpbRysownica = new System.Windows.Forms.PictureBox();
            this.JKlblY = new System.Windows.Forms.Label();
            this.JKlblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrzesuńDoNowegoXY = new System.Windows.Forms.Button();
            this.JKgbWybórFigury = new System.Windows.Forms.GroupBox();
            this.JKtxtKątKońcowy = new System.Windows.Forms.Label();
            this.JKnumKątKońcowy = new System.Windows.Forms.NumericUpDown();
            this.JKtxtKątPoczątkowy = new System.Windows.Forms.Label();
            this.JKnumKątPoczątkowy = new System.Windows.Forms.NumericUpDown();
            this.JKtxtLiczbaKątów = new System.Windows.Forms.Label();
            this.JKnumLiczbaKątów = new System.Windows.Forms.NumericUpDown();
            this.JKrdbFillPie = new System.Windows.Forms.RadioButton();
            this.JKrdbFillClosedCurve = new System.Windows.Forms.RadioButton();
            this.JKrdbDrawArc = new System.Windows.Forms.RadioButton();
            this.JKrdbDrawPie = new System.Windows.Forms.RadioButton();
            this.JKrdbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.JKrdbDrawClosedCurve = new System.Windows.Forms.RadioButton();
            this.JKrdbFillEllipse = new System.Windows.Forms.RadioButton();
            this.JKrdbFillRectangle = new System.Windows.Forms.RadioButton();
            this.JKrdbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.JKrdbLiniaCiągłaKrMysz = new System.Windows.Forms.RadioButton();
            this.JKrdbWielokątFor = new System.Windows.Forms.RadioButton();
            this.JKrdbProstokąt = new System.Windows.Forms.RadioButton();
            this.JKrdbKoło = new System.Windows.Forms.RadioButton();
            this.JKbtnCofnij = new System.Windows.Forms.Button();
            this.JKrdbLinia = new System.Windows.Forms.RadioButton();
            this.JKrdbElipsa = new System.Windows.Forms.RadioButton();
            this.JKrdbOkrąg = new System.Windows.Forms.RadioButton();
            this.JKrdbKwadrat = new System.Windows.Forms.RadioButton();
            this.JKrdbWielokątWyp = new System.Windows.Forms.RadioButton();
            this.JKrdbPunkt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JKcbox = new System.Windows.Forms.ComboBox();
            this.lblGrubosclinii = new System.Windows.Forms.Label();
            this.JKtrackbar = new System.Windows.Forms.TrackBar();
            this.JKbtnKolorWyp = new System.Windows.Forms.Button();
            this.JKbtnKolorLinii = new System.Windows.Forms.Button();
            this.gpbTrybPokazu = new System.Windows.Forms.GroupBox();
            this.JKrdbManualny = new System.Windows.Forms.RadioButton();
            this.JKrdbAutomatycznie = new System.Windows.Forms.RadioButton();
            this.JKbtnWłączPokazFigur = new System.Windows.Forms.Button();
            this.JKbtnWyłączPokazFigur = new System.Windows.Forms.Button();
            this.JKtxtNumerFigury = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JKbtnPoprzedni = new System.Windows.Forms.Button();
            this.JKbtnNastepny = new System.Windows.Forms.Button();
            this.JKbtnZapisBitMapy = new System.Windows.Forms.Button();
            this.JKbtnOdczytBitMapy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.JKpbRysownica)).BeginInit();
            this.JKgbWybórFigury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumKątKońcowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumKątPoczątkowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumLiczbaKątów)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JKtrackbar)).BeginInit();
            this.gpbTrybPokazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // JKpbRysownica
            // 
            this.JKpbRysownica.BackColor = System.Drawing.Color.AntiqueWhite;
            this.JKpbRysownica.Location = new System.Drawing.Point(55, 57);
            this.JKpbRysownica.Name = "JKpbRysownica";
            this.JKpbRysownica.Size = new System.Drawing.Size(887, 580);
            this.JKpbRysownica.TabIndex = 0;
            this.JKpbRysownica.TabStop = false;
            this.JKpbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JKpbRysownica_MouseDown);
            this.JKpbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JKpbRysownica_MouseMove);
            this.JKpbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JKpbRysownica_MouseUp);
            // 
            // JKlblY
            // 
            this.JKlblY.AutoSize = true;
            this.JKlblY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKlblY.Location = new System.Drawing.Point(431, 20);
            this.JKlblY.Name = "JKlblY";
            this.JKlblY.Size = new System.Drawing.Size(20, 19);
            this.JKlblY.TabIndex = 7;
            this.JKlblY.Text = "Y";
            // 
            // JKlblX
            // 
            this.JKlblX.AutoSize = true;
            this.JKlblX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKlblX.Location = new System.Drawing.Point(388, 20);
            this.JKlblX.Name = "JKlblX";
            this.JKlblX.Size = new System.Drawing.Size(20, 19);
            this.JKlblX.TabIndex = 6;
            this.JKlblX.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Współrzędne (X i Y) aktualnego położenia myszy:";
            // 
            // btnPrzesuńDoNowegoXY
            // 
            this.btnPrzesuńDoNowegoXY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesuńDoNowegoXY.Location = new System.Drawing.Point(948, 12);
            this.btnPrzesuńDoNowegoXY.Name = "btnPrzesuńDoNowegoXY";
            this.btnPrzesuńDoNowegoXY.Size = new System.Drawing.Size(296, 48);
            this.btnPrzesuńDoNowegoXY.TabIndex = 8;
            this.btnPrzesuńDoNowegoXY.Text = "Przesuń wszystkie figury do \r\nnowego wylosowanego połozenia";
            this.btnPrzesuńDoNowegoXY.UseVisualStyleBackColor = true;
            this.btnPrzesuńDoNowegoXY.Click += new System.EventHandler(this.btnPrzesuńDoNowegoXY_Click);
            // 
            // JKgbWybórFigury
            // 
            this.JKgbWybórFigury.Controls.Add(this.JKtxtKątKońcowy);
            this.JKgbWybórFigury.Controls.Add(this.JKnumKątKońcowy);
            this.JKgbWybórFigury.Controls.Add(this.JKtxtKątPoczątkowy);
            this.JKgbWybórFigury.Controls.Add(this.JKnumKątPoczątkowy);
            this.JKgbWybórFigury.Controls.Add(this.JKtxtLiczbaKątów);
            this.JKgbWybórFigury.Controls.Add(this.JKnumLiczbaKątów);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbFillPie);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbFillClosedCurve);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbDrawArc);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbDrawPie);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbKrzywaKardynalna);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbDrawClosedCurve);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbFillEllipse);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbFillRectangle);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbKrzywaBeziera);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbLiniaCiągłaKrMysz);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbWielokątFor);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbProstokąt);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbKoło);
            this.JKgbWybórFigury.Controls.Add(this.JKbtnCofnij);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbLinia);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbElipsa);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbOkrąg);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbKwadrat);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbWielokątWyp);
            this.JKgbWybórFigury.Controls.Add(this.JKrdbPunkt);
            this.JKgbWybórFigury.Location = new System.Drawing.Point(948, 76);
            this.JKgbWybórFigury.Name = "JKgbWybórFigury";
            this.JKgbWybórFigury.Size = new System.Drawing.Size(296, 377);
            this.JKgbWybórFigury.TabIndex = 9;
            this.JKgbWybórFigury.TabStop = false;
            this.JKgbWybórFigury.Text = "Wybierz figurę lub linię krzywą";
            // 
            // JKtxtKątKońcowy
            // 
            this.JKtxtKątKońcowy.AutoSize = true;
            this.JKtxtKątKońcowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKtxtKątKońcowy.Location = new System.Drawing.Point(215, 254);
            this.JKtxtKątKońcowy.Name = "JKtxtKątKońcowy";
            this.JKtxtKątKońcowy.Size = new System.Drawing.Size(67, 38);
            this.JKtxtKątKońcowy.TabIndex = 36;
            this.JKtxtKątKońcowy.Text = "Kąt \r\nkońcowy";
            this.JKtxtKątKońcowy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // JKnumKątKońcowy
            // 
            this.JKnumKątKońcowy.Location = new System.Drawing.Point(221, 295);
            this.JKnumKątKońcowy.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.JKnumKątKońcowy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JKnumKątKońcowy.Name = "JKnumKątKońcowy";
            this.JKnumKątKońcowy.Size = new System.Drawing.Size(59, 20);
            this.JKnumKątKońcowy.TabIndex = 35;
            this.JKnumKątKońcowy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JKtxtKątPoczątkowy
            // 
            this.JKtxtKątPoczątkowy.AutoSize = true;
            this.JKtxtKątPoczątkowy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKtxtKątPoczątkowy.Location = new System.Drawing.Point(123, 254);
            this.JKtxtKątPoczątkowy.Name = "JKtxtKątPoczątkowy";
            this.JKtxtKątPoczątkowy.Size = new System.Drawing.Size(86, 38);
            this.JKtxtKątPoczątkowy.TabIndex = 34;
            this.JKtxtKątPoczątkowy.Text = "Kąt \r\npoczątkowy";
            this.JKtxtKątPoczątkowy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // JKnumKątPoczątkowy
            // 
            this.JKnumKątPoczątkowy.Location = new System.Drawing.Point(141, 295);
            this.JKnumKątPoczątkowy.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.JKnumKątPoczątkowy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JKnumKątPoczątkowy.Name = "JKnumKątPoczątkowy";
            this.JKnumKątPoczątkowy.Size = new System.Drawing.Size(59, 20);
            this.JKnumKątPoczątkowy.TabIndex = 33;
            this.JKnumKątPoczątkowy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JKtxtLiczbaKątów
            // 
            this.JKtxtLiczbaKątów.AutoSize = true;
            this.JKtxtLiczbaKątów.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKtxtLiczbaKątów.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.JKtxtLiczbaKątów.Location = new System.Drawing.Point(61, 254);
            this.JKtxtLiczbaKątów.Name = "JKtxtLiczbaKątów";
            this.JKtxtLiczbaKątów.Size = new System.Drawing.Size(56, 38);
            this.JKtxtLiczbaKątów.TabIndex = 32;
            this.JKtxtLiczbaKątów.Text = "Liczba \r\nkątów";
            this.JKtxtLiczbaKątów.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JKnumLiczbaKątów
            // 
            this.JKnumLiczbaKątów.Location = new System.Drawing.Point(58, 295);
            this.JKnumLiczbaKątów.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JKnumLiczbaKątów.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.JKnumLiczbaKątów.Name = "JKnumLiczbaKątów";
            this.JKnumLiczbaKątów.Size = new System.Drawing.Size(59, 20);
            this.JKnumLiczbaKątów.TabIndex = 31;
            this.JKnumLiczbaKątów.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // JKrdbFillPie
            // 
            this.JKrdbFillPie.AutoSize = true;
            this.JKrdbFillPie.Location = new System.Drawing.Point(132, 227);
            this.JKrdbFillPie.Name = "JKrdbFillPie";
            this.JKrdbFillPie.Size = new System.Drawing.Size(52, 17);
            this.JKrdbFillPie.TabIndex = 23;
            this.JKrdbFillPie.TabStop = true;
            this.JKrdbFillPie.Text = "FillPie";
            this.JKrdbFillPie.UseVisualStyleBackColor = true;
            // 
            // JKrdbFillClosedCurve
            // 
            this.JKrdbFillClosedCurve.AutoSize = true;
            this.JKrdbFillClosedCurve.Location = new System.Drawing.Point(7, 227);
            this.JKrdbFillClosedCurve.Name = "JKrdbFillClosedCurve";
            this.JKrdbFillClosedCurve.Size = new System.Drawing.Size(97, 17);
            this.JKrdbFillClosedCurve.TabIndex = 22;
            this.JKrdbFillClosedCurve.TabStop = true;
            this.JKrdbFillClosedCurve.Text = "FillClosedCurve";
            this.JKrdbFillClosedCurve.UseVisualStyleBackColor = true;
            // 
            // JKrdbDrawArc
            // 
            this.JKrdbDrawArc.AutoSize = true;
            this.JKrdbDrawArc.Location = new System.Drawing.Point(133, 204);
            this.JKrdbDrawArc.Name = "JKrdbDrawArc";
            this.JKrdbDrawArc.Size = new System.Drawing.Size(66, 17);
            this.JKrdbDrawArc.TabIndex = 21;
            this.JKrdbDrawArc.TabStop = true;
            this.JKrdbDrawArc.Text = "DrawArc";
            this.JKrdbDrawArc.UseVisualStyleBackColor = true;
            // 
            // JKrdbDrawPie
            // 
            this.JKrdbDrawPie.AutoSize = true;
            this.JKrdbDrawPie.Location = new System.Drawing.Point(7, 204);
            this.JKrdbDrawPie.Name = "JKrdbDrawPie";
            this.JKrdbDrawPie.Size = new System.Drawing.Size(65, 17);
            this.JKrdbDrawPie.TabIndex = 20;
            this.JKrdbDrawPie.TabStop = true;
            this.JKrdbDrawPie.Text = "DrawPie";
            this.JKrdbDrawPie.UseVisualStyleBackColor = true;
            // 
            // JKrdbKrzywaKardynalna
            // 
            this.JKrdbKrzywaKardynalna.AutoSize = true;
            this.JKrdbKrzywaKardynalna.Location = new System.Drawing.Point(132, 181);
            this.JKrdbKrzywaKardynalna.Name = "JKrdbKrzywaKardynalna";
            this.JKrdbKrzywaKardynalna.Size = new System.Drawing.Size(114, 17);
            this.JKrdbKrzywaKardynalna.TabIndex = 19;
            this.JKrdbKrzywaKardynalna.TabStop = true;
            this.JKrdbKrzywaKardynalna.Text = "Krzywa kardynalna";
            this.JKrdbKrzywaKardynalna.UseVisualStyleBackColor = true;
            // 
            // JKrdbDrawClosedCurve
            // 
            this.JKrdbDrawClosedCurve.AutoSize = true;
            this.JKrdbDrawClosedCurve.Location = new System.Drawing.Point(7, 181);
            this.JKrdbDrawClosedCurve.Name = "JKrdbDrawClosedCurve";
            this.JKrdbDrawClosedCurve.Size = new System.Drawing.Size(110, 17);
            this.JKrdbDrawClosedCurve.TabIndex = 18;
            this.JKrdbDrawClosedCurve.TabStop = true;
            this.JKrdbDrawClosedCurve.Text = "DrawClosedCurve";
            this.JKrdbDrawClosedCurve.UseVisualStyleBackColor = true;
            // 
            // JKrdbFillEllipse
            // 
            this.JKrdbFillEllipse.AutoSize = true;
            this.JKrdbFillEllipse.Location = new System.Drawing.Point(133, 158);
            this.JKrdbFillEllipse.Name = "JKrdbFillEllipse";
            this.JKrdbFillEllipse.Size = new System.Drawing.Size(67, 17);
            this.JKrdbFillEllipse.TabIndex = 17;
            this.JKrdbFillEllipse.TabStop = true;
            this.JKrdbFillEllipse.Text = "FillEllipse";
            this.JKrdbFillEllipse.UseVisualStyleBackColor = true;
            // 
            // JKrdbFillRectangle
            // 
            this.JKrdbFillRectangle.AutoSize = true;
            this.JKrdbFillRectangle.Location = new System.Drawing.Point(7, 158);
            this.JKrdbFillRectangle.Name = "JKrdbFillRectangle";
            this.JKrdbFillRectangle.Size = new System.Drawing.Size(86, 17);
            this.JKrdbFillRectangle.TabIndex = 16;
            this.JKrdbFillRectangle.TabStop = true;
            this.JKrdbFillRectangle.Text = "FillRectangle";
            this.JKrdbFillRectangle.UseVisualStyleBackColor = true;
            // 
            // JKrdbKrzywaBeziera
            // 
            this.JKrdbKrzywaBeziera.AutoSize = true;
            this.JKrdbKrzywaBeziera.Location = new System.Drawing.Point(7, 135);
            this.JKrdbKrzywaBeziera.Name = "JKrdbKrzywaBeziera";
            this.JKrdbKrzywaBeziera.Size = new System.Drawing.Size(97, 17);
            this.JKrdbKrzywaBeziera.TabIndex = 15;
            this.JKrdbKrzywaBeziera.TabStop = true;
            this.JKrdbKrzywaBeziera.Text = "Krzywa Beziera";
            this.JKrdbKrzywaBeziera.UseVisualStyleBackColor = true;
            // 
            // JKrdbLiniaCiągłaKrMysz
            // 
            this.JKrdbLiniaCiągłaKrMysz.AutoSize = true;
            this.JKrdbLiniaCiągłaKrMysz.Location = new System.Drawing.Point(133, 112);
            this.JKrdbLiniaCiągłaKrMysz.Name = "JKrdbLiniaCiągłaKrMysz";
            this.JKrdbLiniaCiągłaKrMysz.Size = new System.Drawing.Size(155, 17);
            this.JKrdbLiniaCiągłaKrMysz.TabIndex = 14;
            this.JKrdbLiniaCiągłaKrMysz.TabStop = true;
            this.JKrdbLiniaCiągłaKrMysz.Text = "Linia ciągła kreślona myszą";
            this.JKrdbLiniaCiągłaKrMysz.UseVisualStyleBackColor = true;
            // 
            // JKrdbWielokątFor
            // 
            this.JKrdbWielokątFor.AutoSize = true;
            this.JKrdbWielokątFor.Location = new System.Drawing.Point(133, 89);
            this.JKrdbWielokątFor.Name = "JKrdbWielokątFor";
            this.JKrdbWielokątFor.Size = new System.Drawing.Size(107, 17);
            this.JKrdbWielokątFor.TabIndex = 13;
            this.JKrdbWielokątFor.TabStop = true;
            this.JKrdbWielokątFor.Text = "Wielokąt foremny";
            this.JKrdbWielokątFor.UseVisualStyleBackColor = true;
            // 
            // JKrdbProstokąt
            // 
            this.JKrdbProstokąt.AutoSize = true;
            this.JKrdbProstokąt.Location = new System.Drawing.Point(133, 66);
            this.JKrdbProstokąt.Name = "JKrdbProstokąt";
            this.JKrdbProstokąt.Size = new System.Drawing.Size(70, 17);
            this.JKrdbProstokąt.TabIndex = 12;
            this.JKrdbProstokąt.TabStop = true;
            this.JKrdbProstokąt.Text = "Prostokąt";
            this.JKrdbProstokąt.UseVisualStyleBackColor = true;
            // 
            // JKrdbKoło
            // 
            this.JKrdbKoło.AutoSize = true;
            this.JKrdbKoło.Location = new System.Drawing.Point(7, 66);
            this.JKrdbKoło.Name = "JKrdbKoło";
            this.JKrdbKoło.Size = new System.Drawing.Size(48, 17);
            this.JKrdbKoło.TabIndex = 11;
            this.JKrdbKoło.TabStop = true;
            this.JKrdbKoło.Text = "Koło";
            this.JKrdbKoło.UseVisualStyleBackColor = true;
            // 
            // JKbtnCofnij
            // 
            this.JKbtnCofnij.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnCofnij.Location = new System.Drawing.Point(88, 341);
            this.JKbtnCofnij.Name = "JKbtnCofnij";
            this.JKbtnCofnij.Size = new System.Drawing.Size(125, 30);
            this.JKbtnCofnij.TabIndex = 10;
            this.JKbtnCofnij.Text = "Cofnij";
            this.JKbtnCofnij.UseVisualStyleBackColor = true;
            this.JKbtnCofnij.Click += new System.EventHandler(this.JKbtnCofnij_Click);
            // 
            // JKrdbLinia
            // 
            this.JKrdbLinia.AutoSize = true;
            this.JKrdbLinia.Location = new System.Drawing.Point(133, 20);
            this.JKrdbLinia.Name = "JKrdbLinia";
            this.JKrdbLinia.Size = new System.Drawing.Size(47, 17);
            this.JKrdbLinia.TabIndex = 5;
            this.JKrdbLinia.TabStop = true;
            this.JKrdbLinia.Text = "Linia";
            this.JKrdbLinia.UseVisualStyleBackColor = true;
            // 
            // JKrdbElipsa
            // 
            this.JKrdbElipsa.AutoSize = true;
            this.JKrdbElipsa.Location = new System.Drawing.Point(7, 43);
            this.JKrdbElipsa.Name = "JKrdbElipsa";
            this.JKrdbElipsa.Size = new System.Drawing.Size(53, 17);
            this.JKrdbElipsa.TabIndex = 4;
            this.JKrdbElipsa.TabStop = true;
            this.JKrdbElipsa.Text = "Elipsa";
            this.JKrdbElipsa.UseVisualStyleBackColor = true;
            // 
            // JKrdbOkrąg
            // 
            this.JKrdbOkrąg.AutoSize = true;
            this.JKrdbOkrąg.Location = new System.Drawing.Point(133, 43);
            this.JKrdbOkrąg.Name = "JKrdbOkrąg";
            this.JKrdbOkrąg.Size = new System.Drawing.Size(54, 17);
            this.JKrdbOkrąg.TabIndex = 3;
            this.JKrdbOkrąg.TabStop = true;
            this.JKrdbOkrąg.Text = "Okrąg";
            this.JKrdbOkrąg.UseVisualStyleBackColor = true;
            // 
            // JKrdbKwadrat
            // 
            this.JKrdbKwadrat.AutoSize = true;
            this.JKrdbKwadrat.Location = new System.Drawing.Point(7, 89);
            this.JKrdbKwadrat.Name = "JKrdbKwadrat";
            this.JKrdbKwadrat.Size = new System.Drawing.Size(64, 17);
            this.JKrdbKwadrat.TabIndex = 2;
            this.JKrdbKwadrat.TabStop = true;
            this.JKrdbKwadrat.Text = "Kwadrat";
            this.JKrdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // JKrdbWielokątWyp
            // 
            this.JKrdbWielokątWyp.AutoSize = true;
            this.JKrdbWielokątWyp.Location = new System.Drawing.Point(7, 112);
            this.JKrdbWielokątWyp.Name = "JKrdbWielokątWyp";
            this.JKrdbWielokątWyp.Size = new System.Drawing.Size(124, 17);
            this.JKrdbWielokątWyp.TabIndex = 1;
            this.JKrdbWielokątWyp.TabStop = true;
            this.JKrdbWielokątWyp.Text = "Wielokąt wypełniony";
            this.JKrdbWielokątWyp.UseVisualStyleBackColor = true;
            // 
            // JKrdbPunkt
            // 
            this.JKrdbPunkt.AutoSize = true;
            this.JKrdbPunkt.Location = new System.Drawing.Point(7, 20);
            this.JKrdbPunkt.Name = "JKrdbPunkt";
            this.JKrdbPunkt.Size = new System.Drawing.Size(53, 17);
            this.JKrdbPunkt.TabIndex = 0;
            this.JKrdbPunkt.TabStop = true;
            this.JKrdbPunkt.Text = "Punkt";
            this.JKrdbPunkt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JKcbox);
            this.groupBox1.Controls.Add(this.lblGrubosclinii);
            this.groupBox1.Controls.Add(this.JKtrackbar);
            this.groupBox1.Controls.Add(this.JKbtnKolorWyp);
            this.groupBox1.Controls.Add(this.JKbtnKolorLinii);
            this.groupBox1.Location = new System.Drawing.Point(948, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atrybuty graficzne";
            // 
            // JKcbox
            // 
            this.JKcbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKcbox.FormattingEnabled = true;
            this.JKcbox.Items.AddRange(new object[] {
            "Ciągła (Solid)",
            "Linia kreskowa",
            "Linia kreskowo-kropkowa",
            "Linia kreskowo-kropkowa-kropkowa",
            "Linia kropkowa"});
            this.JKcbox.Location = new System.Drawing.Point(132, 24);
            this.JKcbox.Name = "JKcbox";
            this.JKcbox.Size = new System.Drawing.Size(156, 27);
            this.JKcbox.TabIndex = 18;
            this.JKcbox.Text = "Wybierz styl linii";
            this.JKcbox.SelectedIndexChanged += new System.EventHandler(this.JKcbox_SelectedIndexChanged);
            // 
            // lblGrubosclinii
            // 
            this.lblGrubosclinii.AutoSize = true;
            this.lblGrubosclinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrubosclinii.Location = new System.Drawing.Point(138, 89);
            this.lblGrubosclinii.Name = "lblGrubosclinii";
            this.lblGrubosclinii.Size = new System.Drawing.Size(134, 19);
            this.lblGrubosclinii.TabIndex = 17;
            this.lblGrubosclinii.Text = "Ustaw grubość linii";
            // 
            // JKtrackbar
            // 
            this.JKtrackbar.Location = new System.Drawing.Point(123, 111);
            this.JKtrackbar.Maximum = 4;
            this.JKtrackbar.Name = "JKtrackbar";
            this.JKtrackbar.Size = new System.Drawing.Size(165, 45);
            this.JKtrackbar.TabIndex = 16;
            this.JKtrackbar.Value = 2;
            this.JKtrackbar.Scroll += new System.EventHandler(this.JKtrackbar_Scroll);
            // 
            // JKbtnKolorWyp
            // 
            this.JKbtnKolorWyp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKbtnKolorWyp.Location = new System.Drawing.Point(7, 89);
            this.JKbtnKolorWyp.Name = "JKbtnKolorWyp";
            this.JKbtnKolorWyp.Size = new System.Drawing.Size(110, 39);
            this.JKbtnKolorWyp.TabIndex = 1;
            this.JKbtnKolorWyp.Text = "Kolor wypełnienia";
            this.JKbtnKolorWyp.UseVisualStyleBackColor = true;
            this.JKbtnKolorWyp.Click += new System.EventHandler(this.JKbtnKolorWyp_Click);
            // 
            // JKbtnKolorLinii
            // 
            this.JKbtnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKbtnKolorLinii.Location = new System.Drawing.Point(7, 19);
            this.JKbtnKolorLinii.Name = "JKbtnKolorLinii";
            this.JKbtnKolorLinii.Size = new System.Drawing.Size(110, 32);
            this.JKbtnKolorLinii.TabIndex = 0;
            this.JKbtnKolorLinii.Text = "Kolor linii";
            this.JKbtnKolorLinii.UseVisualStyleBackColor = true;
            this.JKbtnKolorLinii.Click += new System.EventHandler(this.JKbtnKolorLinii_Click);
            // 
            // gpbTrybPokazu
            // 
            this.gpbTrybPokazu.Controls.Add(this.JKrdbManualny);
            this.gpbTrybPokazu.Controls.Add(this.JKrdbAutomatycznie);
            this.gpbTrybPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.gpbTrybPokazu.Location = new System.Drawing.Point(206, 667);
            this.gpbTrybPokazu.Name = "gpbTrybPokazu";
            this.gpbTrybPokazu.Size = new System.Drawing.Size(356, 100);
            this.gpbTrybPokazu.TabIndex = 11;
            this.gpbTrybPokazu.TabStop = false;
            this.gpbTrybPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // JKrdbManualny
            // 
            this.JKrdbManualny.AutoSize = true;
            this.JKrdbManualny.Location = new System.Drawing.Point(10, 55);
            this.JKrdbManualny.Name = "JKrdbManualny";
            this.JKrdbManualny.Size = new System.Drawing.Size(95, 23);
            this.JKrdbManualny.TabIndex = 3;
            this.JKrdbManualny.Text = "Manualny";
            this.JKrdbManualny.UseVisualStyleBackColor = true;
            this.JKrdbManualny.CheckedChanged += new System.EventHandler(this.JKrdbManualny_CheckedChanged_1);
            // 
            // JKrdbAutomatycznie
            // 
            this.JKrdbAutomatycznie.AutoSize = true;
            this.JKrdbAutomatycznie.Checked = true;
            this.JKrdbAutomatycznie.Location = new System.Drawing.Point(10, 26);
            this.JKrdbAutomatycznie.Name = "JKrdbAutomatycznie";
            this.JKrdbAutomatycznie.Size = new System.Drawing.Size(197, 23);
            this.JKrdbAutomatycznie.TabIndex = 2;
            this.JKrdbAutomatycznie.TabStop = true;
            this.JKrdbAutomatycznie.Text = "Automatyczny (zegarowy)";
            this.JKrdbAutomatycznie.UseVisualStyleBackColor = true;
            // 
            // JKbtnWłączPokazFigur
            // 
            this.JKbtnWłączPokazFigur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnWłączPokazFigur.Location = new System.Drawing.Point(55, 667);
            this.JKbtnWłączPokazFigur.Name = "JKbtnWłączPokazFigur";
            this.JKbtnWłączPokazFigur.Size = new System.Drawing.Size(145, 100);
            this.JKbtnWłączPokazFigur.TabIndex = 12;
            this.JKbtnWłączPokazFigur.Text = "Włącz pokaz figur geometrycznych";
            this.JKbtnWłączPokazFigur.UseVisualStyleBackColor = true;
            this.JKbtnWłączPokazFigur.Click += new System.EventHandler(this.JKbtnWłączPokazFigur_Click);
            // 
            // JKbtnWyłączPokazFigur
            // 
            this.JKbtnWyłączPokazFigur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnWyłączPokazFigur.Location = new System.Drawing.Point(568, 667);
            this.JKbtnWyłączPokazFigur.Name = "JKbtnWyłączPokazFigur";
            this.JKbtnWyłączPokazFigur.Size = new System.Drawing.Size(128, 100);
            this.JKbtnWyłączPokazFigur.TabIndex = 13;
            this.JKbtnWyłączPokazFigur.Text = "Wyłącz pokaz figur geometrycznych";
            this.JKbtnWyłączPokazFigur.UseVisualStyleBackColor = true;
            this.JKbtnWyłączPokazFigur.Click += new System.EventHandler(this.JKbtnWyłączPokazFigur_Click);
            // 
            // JKtxtNumerFigury
            // 
            this.JKtxtNumerFigury.Enabled = false;
            this.JKtxtNumerFigury.Location = new System.Drawing.Point(700, 709);
            this.JKtxtNumerFigury.Name = "JKtxtNumerFigury";
            this.JKtxtNumerFigury.Size = new System.Drawing.Size(100, 20);
            this.JKtxtNumerFigury.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(702, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numer figury\r\n(indeks)\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JKbtnPoprzedni
            // 
            this.JKbtnPoprzedni.Enabled = false;
            this.JKbtnPoprzedni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnPoprzedni.Location = new System.Drawing.Point(810, 722);
            this.JKbtnPoprzedni.Name = "JKbtnPoprzedni";
            this.JKbtnPoprzedni.Size = new System.Drawing.Size(117, 35);
            this.JKbtnPoprzedni.TabIndex = 18;
            this.JKbtnPoprzedni.Text = "Poprzedni";
            this.JKbtnPoprzedni.UseVisualStyleBackColor = true;
            this.JKbtnPoprzedni.Click += new System.EventHandler(this.JKbtnPoprzedni_Click);
            // 
            // JKbtnNastepny
            // 
            this.JKbtnNastepny.Enabled = false;
            this.JKbtnNastepny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnNastepny.Location = new System.Drawing.Point(810, 669);
            this.JKbtnNastepny.Name = "JKbtnNastepny";
            this.JKbtnNastepny.Size = new System.Drawing.Size(117, 36);
            this.JKbtnNastepny.TabIndex = 17;
            this.JKbtnNastepny.Text = "Następny";
            this.JKbtnNastepny.UseVisualStyleBackColor = true;
            this.JKbtnNastepny.Click += new System.EventHandler(this.JKbtnNastepny_Click);
            // 
            // JKbtnZapisBitMapy
            // 
            this.JKbtnZapisBitMapy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnZapisBitMapy.Location = new System.Drawing.Point(955, 667);
            this.JKbtnZapisBitMapy.Name = "JKbtnZapisBitMapy";
            this.JKbtnZapisBitMapy.Size = new System.Drawing.Size(296, 36);
            this.JKbtnZapisBitMapy.TabIndex = 19;
            this.JKbtnZapisBitMapy.Text = "Zapisz bitmape w pliku";
            this.JKbtnZapisBitMapy.UseVisualStyleBackColor = true;
            this.JKbtnZapisBitMapy.Click += new System.EventHandler(this.JKbtnZapisBitMapy_Click);
            // 
            // JKbtnOdczytBitMapy
            // 
            this.JKbtnOdczytBitMapy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.JKbtnOdczytBitMapy.Location = new System.Drawing.Point(955, 720);
            this.JKbtnOdczytBitMapy.Name = "JKbtnOdczytBitMapy";
            this.JKbtnOdczytBitMapy.Size = new System.Drawing.Size(296, 36);
            this.JKbtnOdczytBitMapy.TabIndex = 20;
            this.JKbtnOdczytBitMapy.Text = "Wczytaj bitmape z pliku";
            this.JKbtnOdczytBitMapy.UseVisualStyleBackColor = true;
            this.JKbtnOdczytBitMapy.Click += new System.EventHandler(this.JKbtnOdczytBitMapy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProjektIndywidualnyNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 779);
            this.Controls.Add(this.JKbtnOdczytBitMapy);
            this.Controls.Add(this.JKbtnZapisBitMapy);
            this.Controls.Add(this.JKbtnPoprzedni);
            this.Controls.Add(this.JKbtnNastepny);
            this.Controls.Add(this.JKtxtNumerFigury);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JKbtnWyłączPokazFigur);
            this.Controls.Add(this.JKbtnWłączPokazFigur);
            this.Controls.Add(this.gpbTrybPokazu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.JKgbWybórFigury);
            this.Controls.Add(this.btnPrzesuńDoNowegoXY);
            this.Controls.Add(this.JKlblY);
            this.Controls.Add(this.JKlblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JKpbRysownica);
            this.Name = "ProjektIndywidualnyNr2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjektIndywidualnyNr2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.JKpbRysownica)).EndInit();
            this.JKgbWybórFigury.ResumeLayout(false);
            this.JKgbWybórFigury.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumKątKońcowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumKątPoczątkowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JKnumLiczbaKątów)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JKtrackbar)).EndInit();
            this.gpbTrybPokazu.ResumeLayout(false);
            this.gpbTrybPokazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JKpbRysownica;
        private System.Windows.Forms.Label JKlblY;
        private System.Windows.Forms.Label JKlblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrzesuńDoNowegoXY;
        private System.Windows.Forms.GroupBox JKgbWybórFigury;
        private System.Windows.Forms.RadioButton JKrdbElipsa;
        private System.Windows.Forms.RadioButton JKrdbOkrąg;
        private System.Windows.Forms.RadioButton JKrdbKwadrat;
        private System.Windows.Forms.RadioButton JKrdbWielokątWyp;
        private System.Windows.Forms.RadioButton JKrdbPunkt;
        private System.Windows.Forms.RadioButton JKrdbLinia;
        private System.Windows.Forms.Button JKbtnCofnij;
        private System.Windows.Forms.RadioButton JKrdbKoło;
        private System.Windows.Forms.RadioButton JKrdbFillPie;
        private System.Windows.Forms.RadioButton JKrdbFillClosedCurve;
        private System.Windows.Forms.RadioButton JKrdbDrawArc;
        private System.Windows.Forms.RadioButton JKrdbDrawPie;
        private System.Windows.Forms.RadioButton JKrdbKrzywaKardynalna;
        private System.Windows.Forms.RadioButton JKrdbDrawClosedCurve;
        private System.Windows.Forms.RadioButton JKrdbFillEllipse;
        private System.Windows.Forms.RadioButton JKrdbFillRectangle;
        private System.Windows.Forms.RadioButton JKrdbKrzywaBeziera;
        private System.Windows.Forms.RadioButton JKrdbLiniaCiągłaKrMysz;
        private System.Windows.Forms.RadioButton JKrdbWielokątFor;
        private System.Windows.Forms.RadioButton JKrdbProstokąt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button JKbtnKolorWyp;
        private System.Windows.Forms.Button JKbtnKolorLinii;
        private System.Windows.Forms.GroupBox gpbTrybPokazu;
        private System.Windows.Forms.Button JKbtnWłączPokazFigur;
        private System.Windows.Forms.Button JKbtnWyłączPokazFigur;
        private System.Windows.Forms.TextBox JKtxtNumerFigury;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrubosclinii;
        private System.Windows.Forms.TrackBar JKtrackbar;
        private System.Windows.Forms.Button JKbtnPoprzedni;
        private System.Windows.Forms.Button JKbtnNastepny;
        private System.Windows.Forms.Button JKbtnZapisBitMapy;
        private System.Windows.Forms.Button JKbtnOdczytBitMapy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox JKcbox;
        private System.Windows.Forms.Label JKtxtKątKońcowy;
        private System.Windows.Forms.NumericUpDown JKnumKątKońcowy;
        private System.Windows.Forms.Label JKtxtKątPoczątkowy;
        private System.Windows.Forms.NumericUpDown JKnumKątPoczątkowy;
        private System.Windows.Forms.Label JKtxtLiczbaKątów;
        private System.Windows.Forms.NumericUpDown JKnumLiczbaKątów;
        private System.Windows.Forms.RadioButton JKrdbManualny;
        private System.Windows.Forms.RadioButton JKrdbAutomatycznie;
    }
}