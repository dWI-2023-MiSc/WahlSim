namespace WinWahlLFH
{
    partial class FrmKandidaten
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
            KandidatenListBox = new ListBox();
            kandidatenEditBox = new GroupBox();
            KandidatAbbrechenBtn = new Button();
            KandidatBerufLabel = new Label();
            KandidatSpeichernBtn = new Button();
            KandidatBerufBox = new TextBox();
            IdBox = new GroupBox();
            KandidatenIdBox = new TextBox();
            KandidatenIdLabel = new Label();
            KandidatAlterLabel = new Label();
            KandidatAlterBox = new TextBox();
            KandidatenNameLabel = new Label();
            KandidatenNameBox = new TextBox();
            btnLoeschen = new Button();
            addKandidatBtn = new Button();
            kandidatenEditBox.SuspendLayout();
            IdBox.SuspendLayout();
            SuspendLayout();
            // 
            // KandidatenListBox
            // 
            KandidatenListBox.FormattingEnabled = true;
            KandidatenListBox.Location = new Point(60, 45);
            KandidatenListBox.Name = "KandidatenListBox";
            KandidatenListBox.Size = new Size(292, 284);
            KandidatenListBox.TabIndex = 0;
            KandidatenListBox.SelectedIndexChanged += KandidatenBox_SelectedIndexChanged;
            // 
            // kandidatenEditBox
            // 
            kandidatenEditBox.Controls.Add(KandidatAbbrechenBtn);
            kandidatenEditBox.Controls.Add(KandidatBerufLabel);
            kandidatenEditBox.Controls.Add(KandidatSpeichernBtn);
            kandidatenEditBox.Controls.Add(KandidatBerufBox);
            kandidatenEditBox.Controls.Add(IdBox);
            kandidatenEditBox.Controls.Add(KandidatAlterLabel);
            kandidatenEditBox.Controls.Add(KandidatAlterBox);
            kandidatenEditBox.Controls.Add(KandidatenNameLabel);
            kandidatenEditBox.Controls.Add(KandidatenNameBox);
            kandidatenEditBox.Enabled = false;
            kandidatenEditBox.Location = new Point(431, 45);
            kandidatenEditBox.Name = "kandidatenEditBox";
            kandidatenEditBox.Size = new Size(308, 362);
            kandidatenEditBox.TabIndex = 1;
            kandidatenEditBox.TabStop = false;
            kandidatenEditBox.Visible = false;
            // 
            // KandidatAbbrechenBtn
            // 
            KandidatAbbrechenBtn.Location = new Point(184, 309);
            KandidatAbbrechenBtn.Name = "KandidatAbbrechenBtn";
            KandidatAbbrechenBtn.Size = new Size(94, 29);
            KandidatAbbrechenBtn.TabIndex = 8;
            KandidatAbbrechenBtn.Text = "Abbrechen";
            KandidatAbbrechenBtn.UseVisualStyleBackColor = true;
            KandidatAbbrechenBtn.Click += KandidatAbbrechenBtn_Click;
            // 
            // KandidatBerufLabel
            // 
            KandidatBerufLabel.AutoSize = true;
            KandidatBerufLabel.Location = new Point(66, 143);
            KandidatBerufLabel.Name = "KandidatBerufLabel";
            KandidatBerufLabel.Size = new Size(44, 20);
            KandidatBerufLabel.TabIndex = 7;
            KandidatBerufLabel.Text = "Beruf";
            // 
            // KandidatSpeichernBtn
            // 
            KandidatSpeichernBtn.Location = new Point(21, 309);
            KandidatSpeichernBtn.Name = "KandidatSpeichernBtn";
            KandidatSpeichernBtn.Size = new Size(94, 29);
            KandidatSpeichernBtn.TabIndex = 7;
            KandidatSpeichernBtn.Text = "Hinzufügen";
            KandidatSpeichernBtn.UseVisualStyleBackColor = true;
            KandidatSpeichernBtn.Click += KandidatSpeichernBtn_Click;
            // 
            // KandidatBerufBox
            // 
            KandidatBerufBox.Location = new Point(66, 166);
            KandidatBerufBox.Name = "KandidatBerufBox";
            KandidatBerufBox.Size = new Size(165, 27);
            KandidatBerufBox.TabIndex = 6;
            // 
            // IdBox
            // 
            IdBox.Controls.Add(KandidatenIdBox);
            IdBox.Controls.Add(KandidatenIdLabel);
            IdBox.Enabled = false;
            IdBox.Location = new Point(40, 199);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(217, 85);
            IdBox.TabIndex = 8;
            IdBox.TabStop = false;
            // 
            // KandidatenIdBox
            // 
            KandidatenIdBox.Location = new Point(26, 35);
            KandidatenIdBox.Name = "KandidatenIdBox";
            KandidatenIdBox.ReadOnly = true;
            KandidatenIdBox.Size = new Size(165, 27);
            KandidatenIdBox.TabIndex = 2;
            // 
            // KandidatenIdLabel
            // 
            KandidatenIdLabel.AutoSize = true;
            KandidatenIdLabel.Location = new Point(26, 12);
            KandidatenIdLabel.Name = "KandidatenIdLabel";
            KandidatenIdLabel.Size = new Size(24, 20);
            KandidatenIdLabel.TabIndex = 3;
            KandidatenIdLabel.Text = "ID";
            // 
            // KandidatAlterLabel
            // 
            KandidatAlterLabel.AutoSize = true;
            KandidatAlterLabel.Location = new Point(66, 80);
            KandidatAlterLabel.Name = "KandidatAlterLabel";
            KandidatAlterLabel.Size = new Size(41, 20);
            KandidatAlterLabel.TabIndex = 5;
            KandidatAlterLabel.Text = "Alter";
            // 
            // KandidatAlterBox
            // 
            KandidatAlterBox.Location = new Point(66, 103);
            KandidatAlterBox.Name = "KandidatAlterBox";
            KandidatAlterBox.Size = new Size(165, 27);
            KandidatAlterBox.TabIndex = 4;
            // 
            // KandidatenNameLabel
            // 
            KandidatenNameLabel.AutoSize = true;
            KandidatenNameLabel.Location = new Point(66, 11);
            KandidatenNameLabel.Name = "KandidatenNameLabel";
            KandidatenNameLabel.Size = new Size(49, 20);
            KandidatenNameLabel.TabIndex = 1;
            KandidatenNameLabel.Text = "Name";
            KandidatenNameLabel.Click += label1_Click;
            // 
            // KandidatenNameBox
            // 
            KandidatenNameBox.Location = new Point(66, 34);
            KandidatenNameBox.Name = "KandidatenNameBox";
            KandidatenNameBox.Size = new Size(165, 27);
            KandidatenNameBox.TabIndex = 0;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(224, 354);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(94, 29);
            btnLoeschen.TabIndex = 6;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // addKandidatBtn
            // 
            addKandidatBtn.Location = new Point(60, 354);
            addKandidatBtn.Name = "addKandidatBtn";
            addKandidatBtn.Size = new Size(142, 29);
            addKandidatBtn.TabIndex = 5;
            addKandidatBtn.Text = "Neuer Kandidat";
            addKandidatBtn.UseVisualStyleBackColor = true;
            addKandidatBtn.Click += addKandidatBtn_Click;
            // 
            // Kandidaten
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoeschen);
            Controls.Add(addKandidatBtn);
            Controls.Add(kandidatenEditBox);
            Controls.Add(KandidatenListBox);
            Name = "Kandidaten";
            Text = "Kandidaten";
            kandidatenEditBox.ResumeLayout(false);
            kandidatenEditBox.PerformLayout();
            IdBox.ResumeLayout(false);
            IdBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox KandidatenListBox;
        private GroupBox kandidatenEditBox;
        private Label KandidatenNameLabel;
        private TextBox KandidatenNameBox;
        private Label KandidatenIdLabel;
        private TextBox KandidatenIdBox;
        private Button btnLoeschen;
        private Button addKandidatBtn;
        private Label KandidatAlterLabel;
        private Label KandidatBerufLabel;
        private TextBox KandidatBerufBox;
        private Button KandidatSpeichernBtn;
        private Button KandidatAbbrechenBtn;
        private GroupBox IdBox;
        private TextBox KandidatAlterBox;
    }
}