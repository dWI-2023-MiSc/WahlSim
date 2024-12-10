namespace WinWahlLFH
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstWahlen = new ListBox();
            grpWahl = new GroupBox();
            btBearbeiten = new Button();
            btnAbbrechen = new Button();
            btnSpeichern = new Button();
            numMaxStimmen = new NumericUpDown();
            lblTermin = new Label();
            dtpTermin = new DateTimePicker();
            lblMaxStimmen = new Label();
            lblTitel = new Label();
            txtTitel = new TextBox();
            btnNeu = new Button();
            btnLoeschen = new Button();
            btnFormularAnzeigen = new Button();
            grpWahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxStimmen).BeginInit();
            SuspendLayout();
            // 
            // lstWahlen
            // 
            lstWahlen.FormattingEnabled = true;
            lstWahlen.Location = new Point(23, 35);
            lstWahlen.Name = "lstWahlen";
            lstWahlen.Size = new Size(372, 344);
            lstWahlen.TabIndex = 0;
            lstWahlen.SelectedIndexChanged += lstWahlen_SelectedIndexChanged;
            // 
            // grpWahl
            // 
            grpWahl.Controls.Add(btBearbeiten);
            grpWahl.Controls.Add(btnAbbrechen);
            grpWahl.Controls.Add(btnSpeichern);
            grpWahl.Controls.Add(numMaxStimmen);
            grpWahl.Controls.Add(lblTermin);
            grpWahl.Controls.Add(dtpTermin);
            grpWahl.Controls.Add(lblMaxStimmen);
            grpWahl.Controls.Add(lblTitel);
            grpWahl.Controls.Add(txtTitel);
            grpWahl.Location = new Point(401, 24);
            grpWahl.Name = "grpWahl";
            grpWahl.Size = new Size(323, 355);
            grpWahl.TabIndex = 2;
            grpWahl.TabStop = false;
            grpWahl.Text = "Details";
            grpWahl.Visible = false;
            // 
            // btBearbeiten
            // 
            btBearbeiten.Location = new Point(38, 313);
            btBearbeiten.Name = "btBearbeiten";
            btBearbeiten.Size = new Size(147, 29);
            btBearbeiten.TabIndex = 7;
            btBearbeiten.Text = "Wahl bearbeiten";
            btBearbeiten.UseVisualStyleBackColor = true;
            btBearbeiten.Click += btBearbeiten_Click;
            // 
            // btnAbbrechen
            // 
            btnAbbrechen.Location = new Point(144, 237);
            btnAbbrechen.Name = "btnAbbrechen";
            btnAbbrechen.Size = new Size(94, 29);
            btnAbbrechen.TabIndex = 6;
            btnAbbrechen.Text = "Abbrechen";
            btnAbbrechen.UseVisualStyleBackColor = true;
            btnAbbrechen.Click += btnAbbrechen_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(38, 236);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(94, 29);
            btnSpeichern.TabIndex = 5;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // numMaxStimmen
            // 
            numMaxStimmen.Location = new Point(40, 117);
            numMaxStimmen.Name = "numMaxStimmen";
            numMaxStimmen.Size = new Size(133, 27);
            numMaxStimmen.TabIndex = 3;
            // 
            // lblTermin
            // 
            lblTermin.AutoSize = true;
            lblTermin.Location = new Point(40, 164);
            lblTermin.Name = "lblTermin";
            lblTermin.Size = new Size(54, 20);
            lblTermin.TabIndex = 5;
            lblTermin.Text = "Termin";
            // 
            // dtpTermin
            // 
            dtpTermin.Location = new Point(38, 193);
            dtpTermin.Name = "dtpTermin";
            dtpTermin.Size = new Size(250, 27);
            dtpTermin.TabIndex = 4;
            // 
            // lblMaxStimmen
            // 
            lblMaxStimmen.AutoSize = true;
            lblMaxStimmen.Location = new Point(38, 95);
            lblMaxStimmen.Name = "lblMaxStimmen";
            lblMaxStimmen.Size = new Size(103, 20);
            lblMaxStimmen.TabIndex = 3;
            lblMaxStimmen.Text = "Max. Stimmen";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(35, 33);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(38, 20);
            lblTitel.TabIndex = 2;
            lblTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(38, 56);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(250, 27);
            txtTitel.TabIndex = 2;
            // 
            // btnNeu
            // 
            btnNeu.Location = new Point(26, 392);
            btnNeu.Name = "btnNeu";
            btnNeu.Size = new Size(94, 29);
            btnNeu.TabIndex = 1;
            btnNeu.Text = "Neue Wahl";
            btnNeu.UseVisualStyleBackColor = true;
            btnNeu.Click += btnNeu_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(126, 392);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(94, 29);
            btnLoeschen.TabIndex = 40;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // btnFormularAnzeigen
            // 
            btnFormularAnzeigen.Location = new Point(561, 392);
            btnFormularAnzeigen.Name = "btnFormularAnzeigen";
            btnFormularAnzeigen.Size = new Size(163, 29);
            btnFormularAnzeigen.TabIndex = 41;
            btnFormularAnzeigen.Text = "Formular anzeigen";
            btnFormularAnzeigen.UseVisualStyleBackColor = true;
            btnFormularAnzeigen.Visible = false;
            btnFormularAnzeigen.Click += btnFormularAnzeigen_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 468);
            Controls.Add(btnFormularAnzeigen);
            Controls.Add(btnLoeschen);
            Controls.Add(btnNeu);
            Controls.Add(grpWahl);
            Controls.Add(lstWahlen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinWahl LFH";
            Load += frmMain_Load;
            grpWahl.ResumeLayout(false);
            grpWahl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxStimmen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstWahlen;
        private GroupBox grpWahl;
        private Label lblTitel;
        private TextBox txtTitel;
        private Label lblMaxStimmen;
        private Label lblTermin;
        private DateTimePicker dtpTermin;
        private NumericUpDown numMaxStimmen;
        private Button btnNeu;
        private Button btnLoeschen;
        private Button btnSpeichern;
        private Button btnAbbrechen;
        private Button btBearbeiten;
        private Button btnFormularAnzeigen;
    }
}
