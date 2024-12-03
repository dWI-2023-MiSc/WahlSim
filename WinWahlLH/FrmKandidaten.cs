using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWahlLFH
{
    public partial class FrmKandidaten : Form
    {
        private List<Kandidat> kandidaten;
        public FrmKandidaten()
        {
            this.kandidaten = Program.alleKandidaten;
            InitializeComponent();
            UpdateKandidaten();
        }
        public FrmKandidaten(List<Kandidat> kandidaten)
        {
            this.kandidaten = kandidaten;
            InitializeComponent();
            UpdateKandidaten();
        }

        private void UpdateKandidaten()
        {
            foreach (Kandidat kandidat in kandidaten)
            {
                KandidatenListBox.Items.Add(kandidat.Name);
            }
        }
        private void KandidatenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KandidatenListBox.SelectedItem != null)
            {
                kandidatenEditBox.Visible = true;
                IdBox.Visible = true;
                kandidatenEditBox.Enabled = true;
                IdBox.Enabled = true;
                int id = Convert.ToInt16(Convert.ToString(KandidatenListBox.SelectedItem).Substring(0, Convert.ToString(KandidatenListBox.SelectedItem).IndexOf(":")));
                Kandidat kandidat;
                foreach (Kandidat k in kandidaten)
                {
                    if (k.getId() == id)
                    {
                        kandidat = k;
                        KandidatenIdBox.Text = Convert.ToString(kandidat.getId());
                        KandidatenNameBox.Text = kandidat.getName();
                        KandidatAlterBox.Text = Convert.ToString(kandidat.getAlter());
                        KandidatBerufBox.Text = kandidat.getBeruf();
                    }
                }

                KandidatSpeichernBtn.Text = "Ändern";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addKandidatBtn_Click(object sender, EventArgs e)
        {
            kandidatenEditBox.Enabled = true;
            kandidatenEditBox.Visible = true;
            IdBox.Visible = false;
            IdBox.Enabled = false;
            KandidatSpeichernBtn.Text = "Hinzufügen";
            KandidatenIdBox.Text = "";
            KandidatenNameBox.Text = "";
            KandidatAlterBox.Text = "";
            KandidatBerufBox.Text = "";
        }

        private void KandidatSpeichernBtn_Click(object sender, EventArgs e)
        {
            if (KandidatenNameBox.Text != "" && KandidatAlterBox.Text != "" && KandidatBerufBox.Text != "")
            {
                if (KandidatenIdBox.Text == "")
                {
                    kandidaten.Add(new Kandidat(Program.alleKandidaten.Count() + 1, KandidatenNameBox.Text, Convert.ToInt16(KandidatAlterBox.Text), KandidatBerufBox.Text));
                    KandidatenNameBox.Text = "";
                    KandidatAlterBox.Text = "";
                    KandidatBerufBox.Text = "";
                    KandidatenIdBox.Text = "";
                    IdBox.Enabled = false;
                    IdBox.Visible = false;
                    kandidatenEditBox.Enabled = false;
                    kandidatenEditBox.Visible = false;
                    KandidatenListBox.Items.Clear();
                    foreach (Kandidat kandidat in kandidaten)
                    {
                        KandidatenListBox.Items.Add(kandidat.Name);
                    }
                }
                else
                {
                    try
                    {
                        foreach (Kandidat kandidat in kandidaten)
                        {
                            if (kandidat.getId() == Convert.ToInt16(KandidatenIdBox.Text))
                            {
                                kandidat.setAlter(Convert.ToInt16(KandidatAlterBox.Text));

                                kandidat.setName(KandidatenNameBox.Text);
                                kandidat.setBeruf(KandidatBerufBox.Text);
                            }
                        }
                        KandidatenNameBox.Text = "";
                        KandidatAlterBox.Text = "";
                        KandidatBerufBox.Text = "";
                        KandidatenIdBox.Text = "";
                        IdBox.Enabled = false;
                        IdBox.Visible = false;
                        kandidatenEditBox.Enabled = false;
                        kandidatenEditBox.Visible = false;
                        KandidatenListBox.Items.Clear();
                        foreach (Kandidat kandidat in kandidaten)
                        {
                            KandidatenListBox.Items.Add(kandidat.Name);
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

        private void KandidatAbbrechenBtn_Click(object sender, EventArgs e)
        {
            KandidatenNameBox.Text = "";
            KandidatAlterBox.Text = "";
            KandidatBerufBox.Text = "";
            KandidatenIdBox.Text = "";
            IdBox.Enabled = false;
            IdBox.Visible = false;
            kandidatenEditBox.Enabled = false;
            kandidatenEditBox.Visible = false;
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Convert.ToString(KandidatenListBox.SelectedItem).Substring(0, Convert.ToString(KandidatenListBox.SelectedItem).IndexOf(":")));
            Kandidat k = new Kandidat(-1, "", -1, "");
            foreach(Kandidat kandidat in kandidaten)
            {
                if (kandidat.getId() == id)
                {
                    k = kandidat;
                }
            }
            kandidaten.Remove(k);
            KandidatenListBox.Items.Clear();
            foreach (Kandidat kandidat in kandidaten)
            {
                KandidatenListBox.Items.Add(kandidat.Name);
            }
            KandidatenNameBox.Text = "";
            KandidatAlterBox.Text = "";
            KandidatBerufBox.Text = "";
            KandidatenIdBox.Text = "";
            IdBox.Enabled = false;
            IdBox.Visible = false;
            kandidatenEditBox.Enabled = false;
            kandidatenEditBox.Visible = false;
        }
    }
}
