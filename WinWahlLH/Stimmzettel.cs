using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWahlLFH
{
    public class Stimmzettel
    {
        // Maximale Anzahl der Kandidaten, die erlaubt sind 
        private ushort _maxKandidaten = 0;

        // Maximale Anzahl der Stimmen, die ein Kandidar erhalten kann
        private ushort _maxStimmen = 0;

        // Anzahl der aktuell abgegebenen Stimmen
        private ushort _stimmen = 0;

        // Gibt an, ob die aktuellen Daten gültig sind
        private bool _gueltig = false;

        // Liste, die alle Kandidaten speichert
        private List<Kandidat> _kandidaten = new List<Kandidat>();


        // Öffentliche Eigenschaft für die maximale Anzahl von Kandidaten
        public ushort MaxKandidaten
        {
            // Gibt den aktuellen Wert des privaten Felds _maxKandidaten zurück
            get { return _maxKandidaten; }

            // Ermöglicht das Setzen eines neuen Wertes für _maxKandidaten
            set { _maxKandidaten = value; }
        }

        // Öffentliche Eigenschaft für die maximale Anzahl der Stimmen
        public ushort MaxStimmen
        {
            // Gibt den aktuellen Wert des privaten Felds _maxStimme zurück
            get { return _maxStimmen; }

            // Ermöglicht das Setzen eines neuen Wertes für _maxStimme
            set { _maxStimmen = value; }
        }

        // Öffentliche Eigenschaft für die Stimmen
        public ushort Stimmen
        {
            // Gibt den aktuellen Wert des privaten Felds _stimmen zurück
            get { return _stimmen; }

            // Ermöglicht das Setzen eines neuen Wertes für _stimmen
            set { _stimmen = value; }
        }

        // Öffentliche Eigenschaft für die Gültigkeit
        public bool Gueltig 
        {
            // Gibt den aktuellen Wert des privaten Felds _gueltig zurück
            get { return _gueltig; }

            // Ermöglicht das Setzen eines neuen Wertes für _gueltig
            set { _gueltig = value; }
        }

        // Öffentliche Eigenschaft für die Liste der Kandiaten
        public List<Kandidat> Kandidaten
        {
            // Gibt den aktuellen Wert der privaten Liste der Kandidaten zurück
            get { return this._kandidaten; }

            // Ermöglicht das Setzen eines neuen Wertes für die private Liste der Kandidaten
            set { this._kandidaten = value; }
        }

        
    }
}
