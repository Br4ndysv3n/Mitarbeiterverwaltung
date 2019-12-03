using MITARBEITER.LOGIC.OBJEKTE;

namespace MITARBEITER.LOGIC.DATENQUELLE {

    /// <summary>
    /// Eine Schnittstelle für alle Zugriffsklassen auf eine Datenquelle.
    /// </summary>
    public interface IZugriffDatenquelle {

        /// <summary>
        /// Liest die Informationen einer <see cref="Person"/> aus der Datenquelle.
        /// </summary>
        /// <param name="personalnummer"></param>
        Person gibPerson( string personalnummer );

        /// <summary>
        /// Speichert eine Liste der Mitarbeiter in einer Datenquelle.
        /// </summary>
        /// <param name="mitarbeiterListe">Eine <see cref="MitarbeiterListe"/>.</param>
        void speichereAlleMitarbeiter(MitarbeiterListe mitarbeiterListe);

        /// <summary>
        /// Liest eine Liste aller Mitarbeiter aus einer Datenquelle.
        /// </summary>
        /// <returns>Eine <see cref="MitarbeiterListe"/>.</returns>
        MitarbeiterListe gibAlleMitarbeiter();
    }
}