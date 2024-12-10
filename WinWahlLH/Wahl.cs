using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinWahlLFH
{
    public class Wahl
    {
        // Eindeutige ID der Wahl
        private uint _id = 0;

        // Titel der Wahl
        private string _titel;

        // Maximale Anzahl der Stimmen, die abgegeben werden dürfen
        private uint _maxStimmen;

        // Datum und Uhrzeit, an dem die Wahl stattfindet
        private DateTime _termin;

        // Kurzbeschreibung der Wahl
        private string _beschreibung = string.Empty;

        // Liste der Wahlkreise, die an der Wahl teilnehmen
        private List<Wahlkreis> _wahlkreise;


        // Initialisiert eine Wahl mit einem leeren Titel und einer leeren Wahlkreisliste
        public Wahl()
        {
            // Standardwert für den Titel
            this._titel = string.Empty;

            // Initialisiert die Wahlkreisliste als leer
            this._wahlkreise = new List<Wahlkreis>();
        }

        // Konstruktor mit Titel und maximaler Stimmenanzahl
        public Wahl(string titel, uint maxStimmen)
        {
            // Initialisiert den Titel
            this._titel = titel;

            // Initialisiert die maximale Stimmenanzahl
            this._maxStimmen = maxStimmen;

            // Initialisiert die Wahlkreisliste als leer
            this._wahlkreise = new List<Wahlkreis>();
        }


        // Konstruktor mit allen wichtigen Eigenschaften
        public Wahl(string titel, uint maxStimmen, DateTime termin, uint id)
        {
            // Initialisiert den Titel
            this._titel = titel;

            // Initialisiert die maximale Stimmenanzahl
            this._maxStimmen = maxStimmen;

            // Initialisiert das Datum der Wahl
            this._termin = termin;

            // Initialisiert die ID der Wahl
            this._id = id;

            // Kopiert alle Wahlkreise
            this._wahlkreise = new List<Wahlkreis> (Program.alleWahlkreise);
        }


        // Setzt den Titel der Wahl auf einen neuen Wert
        public void SetTitel(string titel)
        {
            this._titel = titel;
        }


        // Gibt den Titel der Wahl zurück
        // Wenn der Titel null ist, wird ein leerer String zurückgegeben
        public string GetTitel()
        {
            if (_titel == null)
                return string.Empty;
            else
                return _titel;
        }


        // Set-Methode für die maximale Stimmenanzahl
        // Setzt die maximale Stimmenanzahl auf einen neuen Wert
        public void SetMaxStimmen(uint value)
        {
            _maxStimmen = value;
        }


        // Get-Methode für die maximale Stimmenanzahl
        // Gibt die maximale Stimmenanzahl zurück
        public uint GetMaxStimmen()
        {
            return _maxStimmen;
        }


        //public string Name => $"{Titel} : {string.Format("{0:dd.MM.yyyy}", _termin)}"; // 0: Platzhalter für das erste Element
        // Formatierte Eigenschaft, die eine Zusammenfassung der Wahl zurückgibt
        public string Name => $"{_id} : {_titel} : {_termin.ToString("dd.MM.yyyy")}";


        // Einfache Eigenschaft für den Titel der Wahl
        // Gibt den Titel der Wahl zurück
        public string Titel => _titel;


        // Eigenschaft für das Datum der Wahl
        // Ermöglicht das Abrufen und Festlegen des Datums
        public DateTime Termin
        {
            get { return _termin; }
            set { _termin = value; }
        }


        // Eigenschaft für die eindeutige ID der Wahl
        // Ermöglicht das Abrufen und Festlegen der ID
        public uint Id
        { 
            get { return _id; }
            set { _id = value; }
        }


        // Eigenschaft für die Kurzbeschreibung der Wahl
        // Ermöglicht das Abrufen und Festlegen der Beschreibung
        public string Beschreibung
        {
            get { return _beschreibung; }
            set { _beschreibung = value; }
        }


        // Eigenschaft für die Liste der Wahlkreise
        // Ermöglicht das Abrufen und Festlegen der Liste der Wahlkreise
        public List<Wahlkreis> Wahlkreise
        {
            get { return this._wahlkreise; }
            set { this._wahlkreise = value; }
        }

    }
}
