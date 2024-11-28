namespace WinWahlLFH
{
    internal static class Program
    {

        public static List<Wahl>? alleWahlen;
        public static List<Kandidat>? alleKandidaten;
        public static List<Wahlkreis>? alleWahlkreise;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]        

        static void Main()
        {
            alleWahlen = new List<Wahl>();
            alleWahlen.Add(new Wahl("Bundestagswahl 2025", 4, new DateTime(2025, 3, 13), 1));
            alleWahlen.Add(new Wahl("Sachsen-Anhalt 2025", 4, new DateTime(2025, 9, 25), 2));
            alleWahlen.Add(new Wahl("Timbuktu 2025", 4, new DateTime(2025, 10, 25), 3));

            alleKandidaten = new List<Kandidat>();
            alleKandidaten.Add(new Kandidat(alleKandidaten.Count() + 1, "Annika Ahlers", 11, "Arzt"));
            alleKandidaten.Add(new Kandidat(alleKandidaten.Count() + 1, "Bettina Busch", 22, "Bäcker"));
            alleKandidaten.Add(new Kandidat(alleKandidaten.Count() + 1, "Chris Clark", 33, "Chemiker"));

            alleWahlkreise = new List<Wahlkreis>();
            alleWahlkreise.Add(new Wahlkreis("Aachen", alleWahlkreise.Count() + 1, 1111));
            alleWahlkreise.Add(new Wahlkreis("Bremen", alleWahlkreise.Count() + 1, 2222));
            alleWahlkreise.Add(new Wahlkreis("Chemnitz", alleWahlkreise.Count() + 1, 3333));


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());

            //Wahlen = new List<Wahl>();
            //DateTime Termin = new DateTime(2024, 11, 25);
            //Wahl myWahl = new Wahl("Bundestagswahl 2024", 4);
        }
    }
}