namespace WinWahlLFH
{
    partial class FrmStimmzettel
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
            lblStatus = new Label();
            btnUngueltig = new Button();
            bntNaechsterStimmzettel = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(192, 0, 0);
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(413, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 50);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "nicht gültig";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // btnUngueltig
            // 
            btnUngueltig.Location = new Point(631, 36);
            btnUngueltig.Name = "btnUngueltig";
            btnUngueltig.Size = new Size(94, 49);
            btnUngueltig.TabIndex = 1;
            btnUngueltig.Text = "ungültig";
            btnUngueltig.UseVisualStyleBackColor = true;
            btnUngueltig.Click += btnUngueltig_Click;
            // 
            // bntNaechsterStimmzettel
            // 
            bntNaechsterStimmzettel.BackColor = Color.FromArgb(192, 255, 192);
            bntNaechsterStimmzettel.DialogResult = DialogResult.Continue;
            bntNaechsterStimmzettel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntNaechsterStimmzettel.Location = new Point(413, 164);
            bntNaechsterStimmzettel.Name = "bntNaechsterStimmzettel";
            bntNaechsterStimmzettel.Size = new Size(149, 125);
            bntNaechsterStimmzettel.TabIndex = 2;
            bntNaechsterStimmzettel.Text = "nächster Stimmzettel";
            bntNaechsterStimmzettel.UseVisualStyleBackColor = false;
            bntNaechsterStimmzettel.Click += bntNaechsterStimmzettel_Click;
            // 
            // FrmStimmzettel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(20, 20);
            ClientSize = new Size(800, 450);
            Controls.Add(bntNaechsterStimmzettel);
            Controls.Add(btnUngueltig);
            Controls.Add(lblStatus);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStimmzettel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wahl : Stimmzettel";
            Load += FrmStimmzettel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private Button btnUngueltig;
        private Button bntNaechsterStimmzettel;
    }
}