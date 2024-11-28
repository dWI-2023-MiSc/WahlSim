using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;
using System.Text;
//using WinWahlLFH;


namespace WinWahlLFH
{
    public partial class frmMain : Form
    {
        private List<Wahl> Wahlen;
        public frmMain()
        {
            InitializeComponent();
            Wahlen = new List<Wahl>();
            foreach (Wahl wahl in Program.alleWahlen)
                Wahlen.Add(wahl);
            updateListe();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (lstWahlen.Items.Count < 1)
            {
                grpWahl.Enabled = false;
            }
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            grpWahl.Enabled = true;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            if (lstWahlen.Items.Count > 0)
                grpWahl.Enabled = true;
            else
                grpWahl.Enabled = false;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Daten gespeichert.");

            Wahl wahl = new Wahl();
            wahl.SetTitel(txtTitel.Text);
            wahl.SetMaxStimmen((uint)numTermin.Value);
            wahl.Termin = dtpTermin.Value;
            wahl.Id = (uint)this.Wahlen.Count + 1;
            this.Wahlen.Add(wahl);

            updateListe();

            if (lstWahlen.Items.Count > 0)
                grpWahl.Enabled = true;
            else
                grpWahl.Enabled = false;
        }

        private void updateListe()
        {
            lstWahlen.Items.Clear();
            int id = 0;
            foreach (Wahl wahl in Wahlen)
            {
                lstWahlen.Items.Add(wahl.Name);
            }
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {

        }

        private void lstWahlen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WahlkreiseEditBtn_Click(object sender, EventArgs e)
        {
            Form wahlkreiseFenster = new Wahlkreise();

            wahlkreiseFenster.ShowDialog();
        }

        private void KandidatenEditBtn_Click(object sender, EventArgs e)
        {
            Form kandidatenFenster = new Kandidaten();

            kandidatenFenster.ShowDialog();
        }
    }
}
