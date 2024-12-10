using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWahlLFH
{
    public partial class FrmStimmzettel : Form
    {
        Stimmzettel _stimmzettel = new Stimmzettel();

        private List<GroupBox> _grbKandidaten = new List<GroupBox>();
        private List<CheckBox> _cboStimmen = new List<CheckBox>();

        public FrmStimmzettel()
        {
            InitializeComponent();
        }

        public FrmStimmzettel(Stimmzettel stimmzettel)
        {
            _stimmzettel = stimmzettel;
            InitializeComponent();
        }

        public Stimmzettel Stimmzettel()
        {
            return _stimmzettel;
        }

        private void InitStimmzettel()
        {
            for (int kandidat = 0; kandidat < _stimmzettel.Kandidaten.Count; kandidat++)
            {
                GroupBox grbKandidat = new GroupBox();
                grbKandidat.Location = new Point(32, kandidat * 110 + 12);
                grbKandidat.Name = $"grbKandidat_{kandidat}";
                grbKandidat.Size = new Size(300, 85);
                grbKandidat.TabIndex = 0;
                grbKandidat.TabStop = false;
                grbKandidat.Text = _stimmzettel.Kandidaten[kandidat].getName();

                for (int stimme = 0; stimme < _stimmzettel.MaxStimmen; stimme++)
                {
                    CheckBox cboStimme = new CheckBox();
                    cboStimme.Appearance = Appearance.Button;
                    cboStimme.CheckAlign = ContentAlignment.MiddleCenter;
                    cboStimme.Font = new Font("Segoe UI", 11F);
                    cboStimme.AutoSize = false;
                    cboStimme.Location = new Point(stimme * 48 + 35, 35);
                    cboStimme.Name = $"cboKandidat_{kandidat}_{stimme}";
                    cboStimme.Padding = new Padding(2, 0, 0, 0);
                    cboStimme.Size = new Size(36, 36);
                    cboStimme.TabIndex = stimme;
                    cboStimme.Text = string.Empty;
                    cboStimme.TextAlign = ContentAlignment.MiddleCenter;
                    cboStimme.UseVisualStyleBackColor = true;
                    cboStimme.CheckedChanged += cboKandidat_CheckedChanged;

                    _cboStimmen.Add(cboStimme);
                    grbKandidat.Controls.Add(cboStimme);
                }

                _grbKandidaten.Add(grbKandidat);
            }

            SuspendLayout();
            foreach (GroupBox grbKandidat in _grbKandidaten)
            {
                this.Controls.Add(grbKandidat);
            }
            ResumeLayout(false);

        }

        private void cboKandidat_CheckedChanged(object sender, EventArgs e)
        {
            // Todo
            //MessageBox.Show($"Checkbox {((CheckBox)sender).Name} ist angeklickt {((CheckBox)sender).Checked}");
            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).Text = "X";
                _stimmzettel.Stimmen++;
            }
            else
            {
                ((CheckBox)sender).Text = string.Empty;
                _stimmzettel.Stimmen--;
            }

            _stimmzettel.Gueltig = PruefeGueltig();
        }

        private bool PruefeGueltig()
        {
            if (_stimmzettel.Stimmen < 1 || _stimmzettel.Stimmen > _stimmzettel.MaxStimmen)
            {
                lblStatus.BackColor = Color.FromArgb(204, 0, 0);
                lblStatus.Text = "nicht gültig";
                return false;
            }

            lblStatus.BackColor = Color.FromArgb(0, 204, 0);
            lblStatus.Text = "gültig";
            return true;
        }

        private void FrmStimmzettel_Load(object sender, EventArgs e)
        {
            this.Height =
                ((_stimmzettel.MaxKandidaten * 120 > 900) ? (900) : (_stimmzettel.MaxKandidaten * 120 + 48));
            InitStimmzettel();
        }

        private void btnUngueltig_Click(object sender, EventArgs e)
        {
            lblStatus.BackColor = Color.FromArgb(204, 0, 0);
            lblStatus.Text = "nicht gültig";
            _stimmzettel.Gueltig = false;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void bntNaechsterStimmzettel_Click(object sender, EventArgs e)
        {

        }
    }
}
