namespace WinWahlLFH
{
    partial class FrmWahlkreise
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
            WahlkreiseListBox = new ListBox();
            GrpWahlkreiseBearbeiten = new GroupBox();
            GrpEditKandidaten = new GroupBox();
            LblId = new Label();
            BtnEditKandidaten = new Button();
            IdBox = new TextBox();
            WahlkreisWahlberechtigtLabel = new Label();
            WahlkreisWahlberechtigtBox = new TextBox();
            WahlkreisAbbrechenBtn = new Button();
            WahlkreisSpeichernBtn = new Button();
            OrtNameLabel = new Label();
            WahlkreisOrtBox = new TextBox();
            BtnWahlkreisAdd = new Button();
            btnLoeschenWahlkreis = new Button();
            btnStimmzettel = new Button();
            GrpWahlkreiseBearbeiten.SuspendLayout();
            GrpEditKandidaten.SuspendLayout();
            SuspendLayout();
            // 
            // WahlkreiseListBox
            // 
            WahlkreiseListBox.FormattingEnabled = true;
            WahlkreiseListBox.Location = new Point(31, 44);
            WahlkreiseListBox.Name = "WahlkreiseListBox";
            WahlkreiseListBox.Size = new Size(419, 304);
            WahlkreiseListBox.TabIndex = 0;
            WahlkreiseListBox.SelectedIndexChanged += WahlkreiseListBox_SelectedIndexChanged;
            // 
            // GrpWahlkreiseBearbeiten
            // 
            GrpWahlkreiseBearbeiten.Controls.Add(GrpEditKandidaten);
            GrpWahlkreiseBearbeiten.Controls.Add(WahlkreisWahlberechtigtLabel);
            GrpWahlkreiseBearbeiten.Controls.Add(WahlkreisWahlberechtigtBox);
            GrpWahlkreiseBearbeiten.Controls.Add(WahlkreisAbbrechenBtn);
            GrpWahlkreiseBearbeiten.Controls.Add(WahlkreisSpeichernBtn);
            GrpWahlkreiseBearbeiten.Controls.Add(OrtNameLabel);
            GrpWahlkreiseBearbeiten.Controls.Add(WahlkreisOrtBox);
            GrpWahlkreiseBearbeiten.Location = new Point(503, 44);
            GrpWahlkreiseBearbeiten.Name = "GrpWahlkreiseBearbeiten";
            GrpWahlkreiseBearbeiten.Size = new Size(322, 348);
            GrpWahlkreiseBearbeiten.TabIndex = 1;
            GrpWahlkreiseBearbeiten.TabStop = false;
            GrpWahlkreiseBearbeiten.Visible = false;
            GrpWahlkreiseBearbeiten.Enter += WahlkreiseBearbeitenGroup_Enter;
            // 
            // GrpEditKandidaten
            // 
            GrpEditKandidaten.Controls.Add(LblId);
            GrpEditKandidaten.Controls.Add(BtnEditKandidaten);
            GrpEditKandidaten.Controls.Add(IdBox);
            GrpEditKandidaten.Location = new Point(50, 162);
            GrpEditKandidaten.Name = "GrpEditKandidaten";
            GrpEditKandidaten.Size = new Size(233, 124);
            GrpEditKandidaten.TabIndex = 13;
            GrpEditKandidaten.TabStop = false;
            GrpEditKandidaten.Visible = false;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(0, 16);
            LblId.Name = "LblId";
            LblId.Size = new Size(24, 20);
            LblId.TabIndex = 1;
            LblId.Text = "ID";
            // 
            // BtnEditKandidaten
            // 
            BtnEditKandidaten.Location = new Point(0, 89);
            BtnEditKandidaten.Name = "BtnEditKandidaten";
            BtnEditKandidaten.Size = new Size(233, 29);
            BtnEditKandidaten.TabIndex = 12;
            BtnEditKandidaten.Text = "Kandidaten bearbeiten";
            BtnEditKandidaten.UseVisualStyleBackColor = true;
            BtnEditKandidaten.Click += BtnEditKandidaten_Click;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(0, 39);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(233, 27);
            IdBox.TabIndex = 0;
            // 
            // WahlkreisWahlberechtigtLabel
            // 
            WahlkreisWahlberechtigtLabel.AutoSize = true;
            WahlkreisWahlberechtigtLabel.Location = new Point(50, 106);
            WahlkreisWahlberechtigtLabel.Name = "WahlkreisWahlberechtigtLabel";
            WahlkreisWahlberechtigtLabel.Size = new Size(201, 20);
            WahlkreisWahlberechtigtLabel.TabIndex = 11;
            WahlkreisWahlberechtigtLabel.Text = "Anzahl der Wahlberechtigten";
            // 
            // WahlkreisWahlberechtigtBox
            // 
            WahlkreisWahlberechtigtBox.Location = new Point(50, 129);
            WahlkreisWahlberechtigtBox.Name = "WahlkreisWahlberechtigtBox";
            WahlkreisWahlberechtigtBox.Size = new Size(233, 27);
            WahlkreisWahlberechtigtBox.TabIndex = 10;
            WahlkreisWahlberechtigtBox.TextChanged += WahlkreisWahlberechtigtBox_TextChanged;
            // 
            // WahlkreisAbbrechenBtn
            // 
            WahlkreisAbbrechenBtn.Location = new Point(189, 319);
            WahlkreisAbbrechenBtn.Name = "WahlkreisAbbrechenBtn";
            WahlkreisAbbrechenBtn.Size = new Size(94, 29);
            WahlkreisAbbrechenBtn.TabIndex = 9;
            WahlkreisAbbrechenBtn.Text = "Abbrechen";
            WahlkreisAbbrechenBtn.UseVisualStyleBackColor = true;
            WahlkreisAbbrechenBtn.Click += WahlkreisAbbrechenBtn_Click;
            // 
            // WahlkreisSpeichernBtn
            // 
            WahlkreisSpeichernBtn.Location = new Point(50, 319);
            WahlkreisSpeichernBtn.Name = "WahlkreisSpeichernBtn";
            WahlkreisSpeichernBtn.Size = new Size(94, 29);
            WahlkreisSpeichernBtn.TabIndex = 8;
            WahlkreisSpeichernBtn.Text = "Hinzufügen";
            WahlkreisSpeichernBtn.UseVisualStyleBackColor = true;
            WahlkreisSpeichernBtn.Click += WahlkreisSpeichernBtn_Click;
            WahlkreisSpeichernBtn.MouseCaptureChanged += BtnWahlkreisAdd_Click;
            // 
            // OrtNameLabel
            // 
            OrtNameLabel.AutoSize = true;
            OrtNameLabel.Location = new Point(50, 29);
            OrtNameLabel.Name = "OrtNameLabel";
            OrtNameLabel.Size = new Size(30, 20);
            OrtNameLabel.TabIndex = 1;
            OrtNameLabel.Text = "Ort";
            OrtNameLabel.Click += OrtNameLabel_Click;
            // 
            // WahlkreisOrtBox
            // 
            WahlkreisOrtBox.Location = new Point(50, 52);
            WahlkreisOrtBox.Name = "WahlkreisOrtBox";
            WahlkreisOrtBox.Size = new Size(233, 27);
            WahlkreisOrtBox.TabIndex = 0;
            WahlkreisOrtBox.TextChanged += WahlkreisOrtBox_TextChanged;
            // 
            // BtnWahlkreisAdd
            // 
            BtnWahlkreisAdd.Location = new Point(31, 363);
            BtnWahlkreisAdd.Name = "BtnWahlkreisAdd";
            BtnWahlkreisAdd.Size = new Size(130, 29);
            BtnWahlkreisAdd.TabIndex = 2;
            BtnWahlkreisAdd.Text = "Neuer Wahlkreis";
            BtnWahlkreisAdd.UseVisualStyleBackColor = true;
            BtnWahlkreisAdd.Click += BtnWahlkreisAdd_Click;
            // 
            // btnLoeschenWahlkreis
            // 
            btnLoeschenWahlkreis.Location = new Point(176, 363);
            btnLoeschenWahlkreis.Name = "btnLoeschenWahlkreis";
            btnLoeschenWahlkreis.Size = new Size(94, 29);
            btnLoeschenWahlkreis.TabIndex = 3;
            btnLoeschenWahlkreis.Text = "Löschen";
            btnLoeschenWahlkreis.UseVisualStyleBackColor = true;
            btnLoeschenWahlkreis.Click += btnLoeschenWahlkreis_Click;
            // 
            // btnStimmzettel
            // 
            btnStimmzettel.Location = new Point(284, 363);
            btnStimmzettel.Name = "btnStimmzettel";
            btnStimmzettel.Size = new Size(166, 29);
            btnStimmzettel.TabIndex = 4;
            btnStimmzettel.Text = "Stimmzettel ausfüllen";
            btnStimmzettel.UseVisualStyleBackColor = true;
            btnStimmzettel.Click += btnStimmzettel_Click;
            // 
            // FrmWahlkreise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(btnStimmzettel);
            Controls.Add(btnLoeschenWahlkreis);
            Controls.Add(BtnWahlkreisAdd);
            Controls.Add(GrpWahlkreiseBearbeiten);
            Controls.Add(WahlkreiseListBox);
            Name = "FrmWahlkreise";
            Text = "Wahlkreise";
            GrpWahlkreiseBearbeiten.ResumeLayout(false);
            GrpWahlkreiseBearbeiten.PerformLayout();
            GrpEditKandidaten.ResumeLayout(false);
            GrpEditKandidaten.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox WahlkreiseListBox;
        private GroupBox GrpWahlkreiseBearbeiten;
        private TextBox WahlkreisOrtBox;
        private Button BtnWahlkreisAdd;
        private Button btnLoeschenWahlkreis;
        private Label OrtNameLabel;
        private Button WahlkreisSpeichernBtn;
        private Button WahlkreisAbbrechenBtn;
        private Label WahlkreisWahlberechtigtLabel;
        private TextBox WahlkreisWahlberechtigtBox;
        private Button BtnEditKandidaten;
        private GroupBox GrpEditKandidaten;
        private Label LblId;
        private TextBox IdBox;
        private Button btnStimmzettel;
    }
}