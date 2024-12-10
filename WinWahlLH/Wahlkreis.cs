
 
using System;

using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using System.Threading.Tasks;
 
namespace WinWahlLFH

{

    public class Wahlkreis

    {

        private int anzahlWahlberechtigte;

        private string name;

        private int wahlkreisID;

        private List<Kandidat> kandidaten;

        private List<Stimmzettel> stimmzettel;

        public Wahlkreis(string name, int id, int anzahlWahlberechtigte)

        {

            this.name = name;

            this.wahlkreisID = id;

            this.anzahlWahlberechtigte = anzahlWahlberechtigte;

            this.kandidaten = new List<Kandidat>(Program.alleKandidaten);

            this.stimmzettel = new List<Stimmzettel>();

        }
        public Wahlkreis(Wahlkreis wahlkreis)
        {
            this.wahlkreisID = wahlkreis.wahlkreisID;
            this.anzahlWahlberechtigte = wahlkreis.anzahlWahlberechtigte;
            this.name = wahlkreis.name;
            this.kandidaten = wahlkreis.kandidaten;
            this.stimmzettel = wahlkreis.stimmzettel;
        }

        public string Name => $"{this.wahlkreisID}: {this.name} | {this.anzahlWahlberechtigte}";

        public int getId()

        {

            return this.wahlkreisID;

        }

        public void setId(int id)

        {

            this.wahlkreisID = id;

        }

        public string getName()

        {

            return this.name;

        }

        public void setName(string name)

        {

            this.name = name;

        }

        public int getAnzahlWahlberechtigte()

        {

            return this.anzahlWahlberechtigte;

        }

        public void setAnzahlWahlberechtigte(int anzahlWahlberechtigte)

        {

            this.anzahlWahlberechtigte = anzahlWahlberechtigte;

        }
        public List<Kandidat> Kandidaten
        {
            get { return this.kandidaten; }
            set { this.kandidaten = value; }
        }
        public List<Stimmzettel> Stimmzettel
        {
            get { return this.stimmzettel; }
            set { this.stimmzettel = value; }
        }

    }

}

