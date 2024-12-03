using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;
using System.Text;
//using WinWahlLFH;


namespace WinWahlLFH
{
    public partial class frmMain : Form
    {
        private List<Wahl> _wahlen;

        // Temporär
        private List<Stimmzettel> _stimmzettelListe = new List<Stimmzettel>();

        public frmMain()
        {
            InitializeComponent();
            _wahlen = new List<Wahl>();
            foreach (Wahl wahl in Program.alleWahlen)
                _wahlen.Add(wahl);
            updateListe();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (lstWahlen.Items.Count < 1)
            //{
            grpWahl.Enabled = false;
            //}
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            grpWahl.Enabled = true;

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            //if (lstWahlen.Items.Count > 0)
            //    grpWahl.Enabled = true;
            //else
            grpWahl.Enabled = false;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Wahl wahl = new Wahl();
            wahl.SetTitel(txtTitel.Text);
            wahl.SetMaxStimmen((uint)numMaxStimmen.Value);
            wahl.Termin = dtpTermin.Value;
            wahl.Id = (uint)this._wahlen.Count + 1;

            this._wahlen.Add(wahl);

            updateListe();
            grpWahl.Enabled = false;

            MessageBox.Show("Die Wahl wurde gespeichert!");
        }

        private void updateListe()
        {
            lstWahlen.Items.Clear();
            foreach (Wahl wahl in _wahlen)
            {
                lstWahlen.Items.Add(wahl.Name);
            }
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            FrmWahlkreise frm = new FrmWahlkreise();
            frm.ShowDialog();
        }

        private void btnFormularAnzeigen_Click(object sender, EventArgs e)
        {
            FrmWahl frmWahl = new FrmWahl();

            // Standardaufruf
            frmWahl.Show();
            // Alternative als Dialog
            //frmWahl.ShowDialog();
        }

        private void btnStimmzettel_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Continue;

            while (result == DialogResult.Continue)
            {
                Stimmzettel stimmzettel = new Stimmzettel();
                stimmzettel.MaxStimmen = 3;
                stimmzettel.MaxKandidaten = (ushort)Program.alleKandidaten.Count;

                FrmStimmzettel frmStimmzettel = new FrmStimmzettel(stimmzettel);

                result = frmStimmzettel.ShowDialog();

                _stimmzettelListe.Add(frmStimmzettel.Stimmzettel());
            }

            MessageBox.Show($"Es wurden insgesamt {_stimmzettelListe.Count} Stimmzettel erfasst.");

        }

        private void lstWahlen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWahlen.SelectedItem != null)
            {
                int id = Convert.ToInt16(Convert.ToString(lstWahlen.SelectedItem).Substring(0, Convert.ToString(lstWahlen.SelectedItem).IndexOf(":")));
                Wahl wahl;
                foreach (Wahl k in Program.alleWahlen)
                {
                    if (k.Id == id)
                    {
                        wahl = k;
                        txtTitel.Text = Convert.ToString(wahl.Titel);
                        numMaxStimmen.Text = Convert.ToString(wahl.GetMaxStimmen());
                        dtpTermin.Text = Convert.ToString(wahl.Termin);
                    }
                }
                grpWahl.Enabled = true;
            }
            
        }
    }
}
