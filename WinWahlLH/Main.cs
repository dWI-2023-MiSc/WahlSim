using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;
using System.Text;
//using WinWahlLFH;


namespace WinWahlLFH
{

    public partial class frmMain : Form
    {
        // Gibt an, ob eine neue Wahl hinzugefügt werden soll
        private bool add = false;


        // Liste aller Wahlen
        private List<Wahl> _wahlen;


        // Konstruktor des Hauptformulars
        // Initialisiert die Komponenten und lädt die bestehenden Wahlen
        public frmMain()
        {
            // Initialisiert die UI-Komponenten
            InitializeComponent();

            // Initialisiert die Liste der Wahlen
            _wahlen = new List<Wahl>();

            // Kopiert alle Wahlen aus dem Hauptprogramm
            foreach (Wahl wahl in Program.alleWahlen)
                _wahlen.Add(wahl);

            // Aktualisiert die Anzeige der Wahlen
            updateListe();
        }


        // Event-Handler, der beim Laden des Formulars aufgerufen wird
        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (lstWahlen.Items.Count < 1)
            //{
            //}
        }


        // Event-Handler für den "Neu"-Button
        // Aktiviert den Modus zum Hinzufügen einer neuen Wahl
        private void btnNeu_Click(object sender, EventArgs e)
        {
            // Setzt die "add"-Flag auf true, um anzuzeigen, dass eine neue Wahl erstellt wird
            add = true;
            // Versteckt die Eingabegruppe
            grpWahl.Visible = true;
            // Entfernt den Text des Titelfelds
            txtTitel.Text = "";
            // Setzt den Standartwert 0 in das Nummernfeld ein
            numMaxStimmen.Value = 0;
            // Entfernt den Text des Terminfelds
            dtpTermin.Text = "";
        }


        // Event-Handler für den "Abbrechen"-Button
        // Schließt das Eingabeformular oder deaktiviert die Eingabegruppe
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            // Versteckt die Eingabegruppe
            grpWahl.Visible = false;
        }


        // Event-Handler für den "Speichern"-Button
        // Speichert eine neue Wahl oder aktualisiert eine bestehende Wahl
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // Wenn eine neue Wahl hinzugefügt werden soll
            if (add)
            {
                // Erstellt eine neue Wahl
                Wahl wahl = new Wahl();

                // Setzt den Titel
                wahl.SetTitel(txtTitel.Text);

                // Setzt die maximale Stimmenanzahl
                wahl.SetMaxStimmen((uint)numMaxStimmen.Value);

                // Setzt den Termin
                wahl.Termin = dtpTermin.Value;

                // Setzt die ID der neuen Wahl
                wahl.Id = (uint)this._wahlen.Count + 1;

                // Fügt die neue Wahl der Liste hinzu
                this._wahlen.Add(wahl);
            }

            // Wenn eine bestehende Wahl bearbeitet werden soll
            else
            {
                if (lstWahlen.SelectedIndex != -1)
                {
                    // Holt die ausgewählte Wahl
                    Wahl wahl = this._wahlen[lstWahlen.SelectedIndex];

                    // Aktualisiert den Titel
                    wahl.SetTitel(txtTitel.Text);

                    // Aktualisiert die maximale Stimmenanzahl
                    wahl.SetMaxStimmen((uint)numMaxStimmen.Value);

                    // Aktualisiert den Termin
                    wahl.Termin = dtpTermin.Value;
                }
                
            }

            // Aktualisiert die Liste der Wahlen
            updateListe();

            // Zeigt eine Erfolgsmeldung an
            MessageBox.Show("Die Wahl wurde gespeichert!");
        }


        // Aktualisiert die Liste der Wahlen in der Benutzeroberfläche
        private void updateListe()
        {
            // Löscht alle Einträge in der Liste
            lstWahlen.Items.Clear();

            // Fügt alle Wahlen der Liste hinzu
            foreach (Wahl wahl in _wahlen)
            {
                // Zeigt den Namen jeder Wahl an
                lstWahlen.Items.Add(wahl.Name);
            }
        }


        // Event-Handler für den "Bearbeiten"-Button
        // Öffnet ein neues Formular, um die Wahlkreise einer Wahl zu bearbeiten
        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            // Wenn eine Wahl ausgewählt ist
            if (lstWahlen.SelectedIndex != -1)
            {
                // Erstellt ein Formular für die Wahlkreise
                FrmWahlkreise frm = new FrmWahlkreise(_wahlen[lstWahlen.SelectedIndex]);

                // Zeigt das Formular als Dialog an
                frm.ShowDialog();
            }
        }


        // Event-Handler für den "Formular Anzeigen"-Button
        // Öffnet ein neues Formular für die Wahlen
        private void btnFormularAnzeigen_Click(object sender, EventArgs e)
        {
            // Erstellt ein neues Formular
            FrmWahl frmWahl = new FrmWahl();

            // Zeigt das Formular an
            // Standardaufruf
            frmWahl.Show();
            // Alternative als Dialog
            //frmWahl.ShowDialog();
        }


        // Event-Handler für die Auswahländerung in der Wahlliste
        // Lädt die Details der ausgewählten Wahl in die Eingabefelder
        private void lstWahlen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wenn ein Element ausgewählt ist
            if (lstWahlen.SelectedIndex != -1)
            {
                // Extrahiert die ID aus dem Listeneintrag
                int id = Convert.ToInt16(Convert.ToString(lstWahlen.SelectedItem).Substring(0, Convert.ToString(lstWahlen.SelectedItem).IndexOf(":")));
                Wahl wahl;

                // Sucht die entsprechende Wahl
                foreach (Wahl k in Program.alleWahlen)
                {
                    if (k.Id == id)
                    {
                        wahl = k;

                        // Lädt den Titel
                        txtTitel.Text = Convert.ToString(wahl.Titel);

                        // Lädt die maximale Stimmenanzahl
                        numMaxStimmen.Text = Convert.ToString(wahl.GetMaxStimmen());

                        // Lädt den Termin
                        dtpTermin.Text = Convert.ToString(wahl.Termin);
                    }
                }

                // Zeigt die Eingabegruppe an
                grpWahl.Visible = true;

                // Setzt den "add"-Modus auf false
                add = false;
            }

        }

        // Event-Handler für den "Löschen"-Button
        // Löscht eine Wahl
        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            // Prüft ob eine Wahl ausgewählt ist
            if (lstWahlen.SelectedIndex != -1)
            {
                // Entfernt die gewählte Wahl aus der Liste
                _wahlen.RemoveAt(lstWahlen.SelectedIndex);
                // Setzt die Auswahl in der angezeigten Liste zurück
                lstWahlen.SelectedIndex = -1;
                // Aktualisiert die angezeigte Liste
                updateListe();
            }  
        }
    }
}
