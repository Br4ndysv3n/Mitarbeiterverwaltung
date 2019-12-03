using System;
using System.Runtime.Serialization;
using MITARBEITER.INFRASTRUKTUR;

namespace MITARBEITER.LOGIC.OBJEKTE {

    /// <summary>
    /// Bildet einen Mitarbeiter ab.
    /// </summary>
    [Serializable]
    public sealed class Mitarbeiter : ISerializable {

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Mitarbeiter"/>-Klasse.
        /// </summary>
        public Mitarbeiter() {
            Person = new Person();
            Abteilung = string.Empty;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Mitarbeiter"/>-Klasse.
        /// </summary>
        /// <param name="person">Die Informationen der <see cref="Person"/>.</param>
        /// <param name="abteilung">Die Abteilung.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn ein Parameter <see langword="null"/> ist</exception>
        /// <exception cref="ArgumentException">Wird ausgelöst, wenn der Parameter <paramref name="abteilung"/> <see cref="string.Empty"/> ist.</exception>
        public Mitarbeiter( Person person, string abteilung ) {
            Pruefung.ArgumentNichtNull( person, "person" );
            Pruefung.ZeichenketteNichtNullOderLeer( abteilung, "abteilung" );

            Person = person;
            Abteilung = abteilung;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Mitarbeiter"/>-Klasse.
        /// </summary>
        public Mitarbeiter( SerializationInfo info, StreamingContext ctxt )
            : this() {
            Pruefung.ArgumentNichtNull( info, "info" );

            Abteilung = ( string ) info.GetValue( "abteilung", typeof( string ) );
        }

        /// <summary>
        /// Liefert die Informationen der <see cref="Person"/>.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Liefert die Abteilung.
        /// </summary>
        public string Abteilung { get; set; }

        #region Implementation of ISerializable

        /// <summary>
        /// Füllt eine <see cref="T:System.Runtime.Serialization.SerializationInfo"/> mit den Daten, die zum Serialisieren des Zielobjekts erforderlich sind.
        /// </summary>
        /// <param name="info">Die mit Daten zu füllende <see cref="T:System.Runtime.Serialization.SerializationInfo"/>. </param><param name="context">Das Ziel (siehe <see cref="T:System.Runtime.Serialization.StreamingContext"/>) dieser Serialisierung. </param><exception cref="T:System.Security.SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung. </exception>
        public void GetObjectData( SerializationInfo info, StreamingContext context ) {
            info.AddValue( "abteilung", Abteilung );
        }

        #endregion
    }
}
