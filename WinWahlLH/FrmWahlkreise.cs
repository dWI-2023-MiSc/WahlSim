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
    public partial class FrmWahlkreise : Form
    {
        private List<Wahlkreis> wahlkreise;
        private ushort maxStimmen;

        private List<Stimmzettel> _stimmzettelListe = new List<Stimmzettel>();
        public FrmWahlkreise()
        {
            this.wahlkreise = Program.alleWahlkreise;
            this.maxStimmen = 3;
            InitializeComponent();
            UpdateWahlkreise();
        }
        public FrmWahlkreise(Wahl wahl)
        {
            this.wahlkreise = wahl.Wahlkreise;
            this.maxStimmen = (ushort) wahl.GetMaxStimmen();
            InitializeComponent();
            UpdateWahlkreise();
        }
        private void UpdateWahlkreise()
        {
            foreach (Wahlkreis wahlkreis in wahlkreise)
            {
                WahlkreiseListBox.Items.Add(wahlkreis.Name);
            }
        }

        private void btnStimmzettel_Click(object sender, EventArgs e)
        {
            if(WahlkreiseListBox.SelectedIndex != -1)
            {
                DialogResult result = DialogResult.Continue;

                while (result == DialogResult.Continue)
                {
                    Stimmzettel stimmzettel = new Stimmzettel();
                    stimmzettel.MaxStimmen = maxStimmen;
                    stimmzettel.Kandidaten = wahlkreise[WahlkreiseListBox.SelectedIndex].Kandidaten;
                    stimmzettel.MaxKandidaten = (ushort)stimmzettel.Kandidaten.Count;
                    FrmStimmzettel frmStimmzettel = new FrmStimmzettel(stimmzettel);

                    result = frmStimmzettel.ShowDialog();
                    if (result != DialogResult.Cancel)
                    {
                        _stimmzettelListe.Add(frmStimmzettel.Stimmzettel());
                    }
                }

                MessageBox.Show($"Es wurden insgesamt {_stimmzettelListe.Count} Stimmzettel erfasst.");
            }
            

        }

        private void WahlkreiseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WahlkreiseListBox.SelectedItem != null)
            {
                Wahlkreis wahlkreis;
                int id = Convert.ToInt16(Convert.ToString(WahlkreiseListBox.SelectedItem).Substring(0, Convert.ToString(WahlkreiseListBox.SelectedItem).IndexOf(":")));
                foreach (Wahlkreis k in wahlkreise)
                {
                    if (k.getId() == id)
                    {
                        wahlkreis = k;
                        IdBox.Text = Convert.ToString(wahlkreis.getId());
                        WahlkreisOrtBox.Text = wahlkreis.getName();
                        WahlkreisWahlberechtigtBox.Text = Convert.ToString(wahlkreis.getAnzahlWahlberechtigte());
                        GrpWahlkreiseBearbeiten.Visible = true;
                        GrpEditKandidaten.Visible = true;
                        WahlkreisSpeichernBtn.Text = "Ändern";
                    }
                }
            }
        }

        private void KandidatenEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnWahlkreisAdd_Click(object sender, EventArgs e)
        {
            GrpWahlkreiseBearbeiten.Visible = true;
            WahlkreisSpeichernBtn.Text = "Hinzufügen";
            WahlkreisOrtBox.Text = "";
            WahlkreisWahlberechtigtBox.Text = "";
            IdBox.Text = "";
            GrpEditKandidaten.Visible = false;
        }

        private void WahlkreisOrtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrtNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void WahlkreiseBearbeitenGroup_Enter(object sender, EventArgs e)
        {

        }

        private void WahlkreisWahlberechtigtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEditKandidaten_Click(object sender, EventArgs e)
        {
            FrmKandidaten frm = new FrmKandidaten(wahlkreise[WahlkreiseListBox.SelectedIndex].Kandidaten);
            frm.ShowDialog();
        }

        private void WahlkreisSpeichernBtn_Click(object sender, EventArgs e)
        {
            if (WahlkreisOrtBox.Text != "" && WahlkreisWahlberechtigtBox.Text != "")
            {
                if (IdBox.Text == "")
                {
                    wahlkreise.Add(new Wahlkreis(WahlkreisOrtBox.Text, Program.alleWahlkreise.Count() + 1, Convert.ToInt16(WahlkreisWahlberechtigtBox.Text)));
                    WahlkreisOrtBox.Text = "";
                    WahlkreisWahlberechtigtBox.Text = "";
                    IdBox.Text = "";
                    GrpEditKandidaten.Visible = false;
                    GrpWahlkreiseBearbeiten.Visible = false;
                    WahlkreiseListBox.Items.Clear();
                    foreach (Wahlkreis wahlkreis in wahlkreise)
                    {
                        WahlkreiseListBox.Items.Add(wahlkreis.Name);
                    }
                }
                else
                {
                    try
                    {
                        foreach (Wahlkreis wahlkreis in wahlkreise)
                        {
                            if (wahlkreis.getId() == Convert.ToInt16(IdBox.Text))
                            {
                                wahlkreis.setAnzahlWahlberechtigte(Convert.ToInt16(WahlkreisWahlberechtigtBox.Text));

                                wahlkreis.setName(WahlkreisOrtBox.Text);
                            }
                        }
                        WahlkreisOrtBox.Text = "";
                        WahlkreisWahlberechtigtBox.Text = "";
                        IdBox.Text = "";
                        GrpEditKandidaten.Visible = false;
                        GrpWahlkreiseBearbeiten.Visible = false;
                        WahlkreiseListBox.Items.Clear();
                        foreach (Wahlkreis wahlkreis in wahlkreise)
                        {
                            WahlkreiseListBox.Items.Add(wahlkreis.Name);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else
            {

            }

        }

        private void WahlkreisAbbrechenBtn_Click(object sender, EventArgs e)
        {
            WahlkreisOrtBox.Text = "";
            WahlkreisWahlberechtigtBox.Text = "";
            IdBox.Text = "";
            GrpEditKandidaten.Visible = false;
            GrpWahlkreiseBearbeiten.Visible = false;
        }

        private void btnLoeschenWahlkreis_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Convert.ToString(WahlkreiseListBox.SelectedItem).Substring(0, Convert.ToString(WahlkreiseListBox.SelectedItem).IndexOf(":")));
            Wahlkreis w = new Wahlkreis("", -1, -1);
            foreach (Wahlkreis kandidat in wahlkreise)
            {
                if (kandidat.getId() == id)
                {
                    w = kandidat;
                }
            }
            wahlkreise.Remove(w);
            WahlkreiseListBox.Items.Clear();
            foreach (Wahlkreis wahlkreis in wahlkreise)
            {
                WahlkreiseListBox.Items.Add(wahlkreis.Name);
            }
            WahlkreisOrtBox.Text = "";
            WahlkreisWahlberechtigtBox.Text = "";
            IdBox.Text = "";
            GrpEditKandidaten.Visible = false;
            GrpWahlkreiseBearbeiten.Visible = false;
        }
    }
}
