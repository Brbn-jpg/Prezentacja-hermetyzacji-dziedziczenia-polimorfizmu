namespace ProjektNr2_Kuźnicki_61961
{
    partial class KokpitProjektuNr2
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
            this.btnLaboratorium = new System.Windows.Forms.Button();
            this.JKbtnProjektIndywidualny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLaboratorium
            // 
            this.btnLaboratorium.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLaboratorium.Location = new System.Drawing.Point(144, 157);
            this.btnLaboratorium.Name = "btnLaboratorium";
            this.btnLaboratorium.Size = new System.Drawing.Size(145, 87);
            this.btnLaboratorium.TabIndex = 1;
            this.btnLaboratorium.Text = "Laboratorium";
            this.btnLaboratorium.UseVisualStyleBackColor = true;
            this.btnLaboratorium.Click += new System.EventHandler(this.btnLaboratorium_Click);
            // 
            // JKbtnProjektIndywidualny
            // 
            this.JKbtnProjektIndywidualny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JKbtnProjektIndywidualny.Location = new System.Drawing.Point(486, 157);
            this.JKbtnProjektIndywidualny.Name = "JKbtnProjektIndywidualny";
            this.JKbtnProjektIndywidualny.Size = new System.Drawing.Size(145, 87);
            this.JKbtnProjektIndywidualny.TabIndex = 2;
            this.JKbtnProjektIndywidualny.Text = "Projekt Indywidualny";
            this.JKbtnProjektIndywidualny.UseVisualStyleBackColor = true;
            this.JKbtnProjektIndywidualny.Click += new System.EventHandler(this.JKbtnProjektIndywidualny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prezentacja praktyczna hermetyzacji dziedziczenia poliformizmu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(294, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jakub Kuźnicki 61961";
            // 
            // KokpitProjektuNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JKbtnProjektIndywidualny);
            this.Controls.Add(this.btnLaboratorium);
            this.Name = "KokpitProjektuNr2";
            this.Text = "Prezentacja praktyczna hermetyzacji dziedziczenia poliformizmu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitProjektuNr2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaboratorium;
        private System.Windows.Forms.Button JKbtnProjektIndywidualny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}