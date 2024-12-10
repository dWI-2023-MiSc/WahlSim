
 
using System;

using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;

using System.Threading.Tasks;
 
namespace WinWahlLFH

{

    public class Wahlkreis

    {
        // Speichert doe Anzahl der wahlberechtigten Personen in diesem Wahlkreis
        private int anzahlWahlberechtigte;

        // Der Name des Wahlkreises
        private string name;

        //Eindeutige ID des Wahlkreises
        private int wahlkreisID;

        // Liste aller Kandidaten, die in diesem Wahlkreis antreten
        private List<Kandidat> kandidaten;

        // liste aller Stimmzettel, die in diesem Wahlkreis abgegebn wurden
        private List<Stimmzettel> stimmzettel;


        //  Konstruktor, der die grundlegenden Eigenschaften eines Wahlkreises initialisiert
        public Wahlkreis(string name, int id, int anzahlWahlberechtigte)

        {

            this.name = name;

            this.wahlkreisID = id;

            this.anzahlWahlberechtigte = anzahlWahlberechtigte;

            this.kandidaten = new List<Kandidat>(Program.alleKandidaten);

            this.stimmzettel = new List<Stimmzettel>();
        }


        // Kopierkonstruktor, der einen bestehenden Wahlkreis dupliziert
        public Wahlkreis(Wahlkreis wahlkreis)
        {
            this.wahlkreisID = wahlkreis.wahlkreisID;
            this.anzahlWahlberechtigte = wahlkreis.anzahlWahlberechtigte;
            this.name = wahlkreis.name;
            this.kandidaten = wahlkreis.kandidaten;
            this.stimmzettel = wahlkreis.stimmzettel;
        }


        // Öffentliche Eigenschaft, die eine formatierte Darstellung des Wahlkreisnamens zurückgibt
        public string Name => $"{this.wahlkreisID}: {this.name} | {this.anzahlWahlberechtigte}";


        // Getter und Setter für die Wahlkreis-ID
        public int getId()

        {
            // Gibt die ID des Wahlkreises zurück
            return this.wahlkreisID;

        }

        public void setId(int id)

        {
            // Setzt die ID des Wahlkreises auf einen neuen Wert
            this.wahlkreisID = id;

        }


        // Getter und Setter für den Namen des Wahlkreises
        public string getName()

        {
            // Gibt den Namen des Wahlkreises zurück
            return this.name;

        }

        public void setName(string name)

        {
            // Setzt den Namen des Wahlkreises auf einen neuen Wert
            this.name = name;

        }


        // Getter und Setter für die Anzahl der Wahlberechtigten
        public int getAnzahlWahlberechtigte()

        {
            // Gibt die Anzahl der Wahlberechtigten zurück
            return this.anzahlWahlberechtigte;

        }

        public void setAnzahlWahlberechtigte(int anzahlWahlberechtigte)

        {
            // Setzt die Anzahl der Wahlberechtigten auf einen neuen Wert
            this.anzahlWahlberechtigte = anzahlWahlberechtigte;

        }


        // Öffentliche Eigenschaft für den Zugriff auf die Kandidatenliste
        public List<Kandidat> Kandidaten
        {
            // Gibt die Liste der Kandidaten zurück
            get { return this.kandidaten; }

            // Setzt die Liste der Kandidaten auf einen neuen Wert
            set { this.kandidaten = value; }
        }


        // Öffentliche Eigenschaft für den Zugriff auf die Liste der Stimmzettel
        public List<Stimmzettel> Stimmzettel
        {
            // Gibt die Liste der Stimmzettel zurück
            get { return this.stimmzettel; }

            // Setzt die Liste der Stimmzettel auf einen neuen Wert
            set { this.stimmzettel = value; }
        }

    }

}

