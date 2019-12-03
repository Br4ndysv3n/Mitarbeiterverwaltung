using System;
using MITARBEITER.INFRASTRUKTUR;
using MITARBEITER.LOGIC.DATENQUELLE;
using MITARBEITER.LOGIC.OBJEKTE;

namespace MITARBEITER.LOGIC {

    /// <summary>
    /// Ein Repository, das den Zugriff auf eine Datenquelle kapselt.
    /// </summary>
    public sealed class Repository : IRepository {

        private readonly IZugriffDatenquelle zugriffDatenquelle_;

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Repository"/>-Klasse.
        /// </summary>
        /// <param name="zugriffDatenquelle">Eine <see cref="IZugriffDatenquelle"/>-Implementierung für den Zugriff auf eine Datenquelle.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="zugriffDatenquelle"/> <see langword="null"/> ist.</exception>
        public Repository( IZugriffDatenquelle zugriffDatenquelle ) {
            Pruefung.ArgumentNichtNull( zugriffDatenquelle, "fabrik" );

            zugriffDatenquelle_ = zugriffDatenquelle;
        }

        /// <summary>
        /// Sucht zu einer Personalnummer die dazugehörige Person.
        /// </summary>
        /// <param name="personalnummer">Die Personalnummer.</param>
        /// <returns>Eine <see cref="Person"/>-Implementierung mit den Daten der Person.</returns>
        public Person gibPersonMitPersonalnummer( string personalnummer ) {
            return zugriffDatenquelle_.gibPerson( personalnummer );
        }

        /// <summary>
        /// Erstellt eine Liste aller Mitarbeiter.
        /// </summary>
        /// <returns>Die <see cref="MitarbeiterListe"/>.</returns>
        public MitarbeiterListe gibAlleMitarbeiter() {
            return zugriffDatenquelle_.gibAlleMitarbeiter();
        }

        /// <summary>
        /// Speichert alle Mitarbeiter.
        /// </summary>
        /// <param name="mitarbeiterListe">Die <see cref="MitarbeiterListe"/>.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="mitarbeiterListe"/> <see langword="null"/> ist.</exception>
        public void speichereAlleMitarbeiter( MitarbeiterListe mitarbeiterListe ) {
            Pruefung.ArgumentNichtNull( mitarbeiterListe, "mitarbeiterListe" );

            zugriffDatenquelle_.speichereAlleMitarbeiter( mitarbeiterListe );
        }
    }
}
