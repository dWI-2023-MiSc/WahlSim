namespace WinWahlLFH
{
    partial class Wahlkreise
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
            WahlkreiseBearbeitenGroup = new GroupBox();
            SuspendLayout();
            // 
            // WahlkreiseListBox
            // 
            WahlkreiseListBox.FormattingEnabled = true;
            WahlkreiseListBox.Location = new Point(31, 44);
            WahlkreiseListBox.Name = "WahlkreiseListBox";
            WahlkreiseListBox.Size = new Size(311, 304);
            WahlkreiseListBox.TabIndex = 0;
            WahlkreiseListBox.SelectedIndexChanged += WahlkreiseListBox_SelectedIndexChanged;
            // 
            // WahlkreiseBearbeitenGroup
            // 
            WahlkreiseBearbeitenGroup.Location = new Point(429, 44);
            WahlkreiseBearbeitenGroup.Name = "WahlkreiseBearbeitenGroup";
            WahlkreiseBearbeitenGroup.Size = new Size(322, 304);
            WahlkreiseBearbeitenGroup.TabIndex = 1;
            WahlkreiseBearbeitenGroup.TabStop = false;
            // 
            // Wahlkreise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WahlkreiseBearbeitenGroup);
            Controls.Add(WahlkreiseListBox);
            Name = "Wahlkreise";
            Text = "Wahlkreise";
            ResumeLayout(false);
        }

        #endregion

        private ListBox WahlkreiseListBox;
        private GroupBox WahlkreiseBearbeitenGroup;
    }
}