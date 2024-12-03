using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWahlLFH
{
    public class Stimmzettel
    {
        private ushort _maxKandidaten = 0;
        private ushort _maxStimmen = 0;
        private ushort _stimmen = 0;
        private bool _gueltig = false;

        public ushort MaxKandidaten
        {
            get { return _maxKandidaten; }
            set { _maxKandidaten = value; }
        }

        public ushort MaxStimmen
        {
            get { return _maxStimmen; }
            set { _maxStimmen = value; }
        }

        public ushort Stimmen
        {
            get { return _stimmen; }
            set { _stimmen = value; }
        }

        public bool Gueltig 
        { 
            get { return _gueltig; }
            set { _gueltig = value; }
        }



        // ToDo: Kandidaten
    }
}
