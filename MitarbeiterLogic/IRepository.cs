using MITARBEITER.LOGIC.OBJEKTE;

namespace MITARBEITER.LOGIC {

    /// <summary>
    /// Eine Schnittstelle für alle Repositories, die die Anfragen auf eine Datenquelle kapseln.
    /// </summary>
    public interface IRepository {

        /// <summary>
        /// Sucht zu einer Personalnummer die dazugehörige Person.
        /// </summary>
        /// <param name="personalnummer">Die Personalnummer.</param>
        /// <returns>Eine <see cref="Person"/>-Implementierung mit den Daten der Person.</returns>
        Person gibPersonMitPersonalnummer( string personalnummer );

        /// <summary>
        /// Erstellt eine Liste aller Mitarbeiter.
        /// </summary>
        /// <returns>Die <see cref="MitarbeiterListe"/>.</returns>
        MitarbeiterListe gibAlleMitarbeiter();

        /// <summary>
        /// Speichert alle Mitarbeiter.
        /// </summary>
        /// <param name="mitarbeiterListe">Die <see cref="MitarbeiterListe"/>.</param>
        void speichereAlleMitarbeiter( MitarbeiterListe mitarbeiterListe );
    }
}