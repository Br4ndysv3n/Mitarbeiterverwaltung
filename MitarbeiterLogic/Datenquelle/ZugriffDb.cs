using System;
using MITARBEITER.LOGIC.OBJEKTE;

namespace MITARBEITER.LOGIC.DATENQUELLE {

    /// <summary>
    /// Stellt den Zugriff auf eine Datenbank her.
    /// </summary>
    public sealed class ZugriffDb : IZugriffDatenquelle {

        /// <summary>
        /// Liest die Informationen einer <see cref="Person"/> aus der Datenbank.
        /// </summary>
        /// <param name="personalnummer">Die Personalnummer.</param>
        /// <exception cref="NotImplementedException">Wird ausgelöst, weil kein Zugriff auf eine Datenbank existiert.</exception>
        public Person gibPerson( string personalnummer ) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speichert eine Liste der Mitarbeiter in einer Datenbank.
        /// </summary>
        /// <param name="mitarbeiterListe">Eine <see cref="MitarbeiterListe"/>.</param>
        /// <exception cref="NotImplementedException">Wird ausgelöst, weil kein Zugriff auf eine Datenbank existiert.</exception>
        public void speichereAlleMitarbeiter(MitarbeiterListe mitarbeiterListe) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liest eine Liste aller Mitarbeiter aus einer Datenbank.
        /// </summary>
        /// <returns>Eine <see cref="MitarbeiterListe"/>.</returns>
        /// <exception cref="NotImplementedException">Wird ausgelöst, weil kein Zugriff auf eine Datenbank existiert.</exception>
        public MitarbeiterListe gibAlleMitarbeiter() {            
            throw new NotImplementedException();
        }
    }
}
