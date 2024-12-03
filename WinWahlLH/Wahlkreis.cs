
 
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
 
namespace WinWahlLFH

{

    internal class Wahlkreis

    {

        private int anzahlWahlberechtigte;

        private string name;

        private int wahlkreisID;

        public Wahlkreis(string name, int id, int anzahlWahlberechtigte)

        {

            this.name = name;

            this.wahlkreisID = id;

            this.anzahlWahlberechtigte = anzahlWahlberechtigte;

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


    }

}

