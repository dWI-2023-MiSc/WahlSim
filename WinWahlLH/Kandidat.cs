using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWahlLFH
{
    public class Kandidat
    {
        // Eindeutige ID des Kandidaten
        private int id;

        // Name des Kandidaten
        private string name;

        // Beruf des Kandidaten
        private string beruf;

        // Alter des Kandidaten
        private int alter;


        // Konstruktor für die Klasse Kandidat
        // Initialisiert die Felder mit den übergebenen Werten
        public Kandidat(int id, string name, int alter, string beruf)
        {
            this.id = id;
            this.name = name;
            this.alter = alter;
            this.beruf = beruf;
        }
        
        
        // Öffentliche Eigenschaft Name
        // Gibt eine formatierte Zeichenfolge mit ID, Name, ALter und Beruf des Kandidaten zurück
        public string Name => $"{this.id}: {this.name} | {this.alter} | {this.beruf}";


        // Getter für die ID
        // Gibt die ID des Kandidaten zurück
        public int getId()
        {
            return this.id;
        }

        // Setzt die ID des Kandidaten auf einen neuen Wert
        public void setId(int id)
        {
            this.id = id;
        }

        // Getter für den Namen
        // Gibt den Namen des Kandidaten zurück
        public string getName()
        {
            return this.name;
        }

        // Setzt den Namen des Kandidaten auf einen neuen Wert
        public void setName(string name)
        {
            this.name = name;
        }

        // Getter für den Beruf
        // Gibt den Beruf des Kandidaten zurück
        public string getBeruf()
        {
            return this.beruf;
        }

        // Setzt den Beruf des Kandidaten auf einen neuen Wert
        public void setBeruf(string beruf)
        {
            this.beruf = beruf;
        }

        // Getter für das Alter
        // Gibt das Alter des Kandidaten zurück
        public int getAlter()
        {
            return this.alter;
        }

        // Setzt das Alter des Kandidaten auf einen neuen Wert
        public void setAlter(int alter)
        {
            this.alter = alter;
        }
    }
}
