using System;
using System.Runtime.Serialization;
using System.Security;
using MITARBEITER.INFRASTRUKTUR;

namespace MITARBEITER.LOGIC.OBJEKTE {

    /// <summary>
    /// Bildet eine Person ab.
    /// </summary>
    [Serializable]
    public sealed class Person : ISerializable {

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Person"/>-Klasse.
        /// </summary>
        public Person() {
            Titel = string.Empty;
            Vorname = string.Empty;
            Nachname = string.Empty;
            Personalnummer = string.Empty;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Person"/>-Klasse.
        /// </summary>
        /// <param name="personalnummer">Die Personalnummer.</param>
        /// <param name="titel">Der Titel der Person.</param>
        /// <param name="vorname">Der Vorname der Person.</param>
        /// <param name="nachname">Der Nachname der Person.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn ein Parameter <see langword="null"/> ist.</exception>
        /// <exception cref="ArgumentException">Wird ausgelöst, wenn ein Parameter <see cref="string.Empty"/> ist.</exception>
        public Person( string personalnummer, string titel, string vorname, string nachname ) {
            Pruefung.ZeichenketteNichtNullOderLeer( titel, "titel" );
            Pruefung.ZeichenketteNichtNullOderLeer( vorname, "vorname" );
            Pruefung.ZeichenketteNichtNullOderLeer( nachname, "nachname" );
            Pruefung.ZeichenketteNichtNullOderLeer( personalnummer, "personalnummer" );

            Titel = titel;
            Vorname = vorname;
            Nachname = nachname;
            Personalnummer = personalnummer;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Person"/>-Klasse.
        /// </summary>
        /// <param name="info">Das <see cref="SerializationInfo"/>-Objekt, das die Daten nach der Deserialisierung enthält.</param>
        /// <param name="ctxt">Der <see cref="StreamingContext"/>.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="info"/> <see langword="null"/> ist.</exception>
        public Person( SerializationInfo info, StreamingContext ctxt ) {
            Pruefung.ArgumentNichtNull( info, "info" );

            Titel = ( string ) info.GetValue( "titel", typeof( string ) );
            Personalnummer = ( string ) info.GetValue( "personalnummer", typeof( string ) );
            Vorname = ( string ) info.GetValue( "vorname", typeof( string ) );
            Nachname = ( string ) info.GetValue( "nachname", typeof( string ) );
        }

        /// <summary>
        /// Liefert die Personalnummer.
        /// </summary>
        public string Personalnummer { get; set; }

        /// <summary>
        /// Liefert den Titel der Person.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Liefert den Vornamen der Person.
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// Liefert den Nachnamen der Person.
        /// </summary>
        public string Nachname { get; set; }

        #region Implementation of ISerializable

        /// <summary>
        /// Füllt eine <see cref="SerializationInfo"/> mit den Daten, die zum Serialisieren des Zielobjekts erforderlich sind.
        /// </summary>
        /// <param name="info">Die mit Daten zu füllende <see cref="SerializationInfo"/>. </param>
        /// <param name="context">Das Ziel (siehe <see cref="StreamingContext"/>) dieser Serialisierung. </param>
        /// <exception cref="SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung. </exception>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="info"/> <see langword="null"/> ist.</exception>
        public void GetObjectData( SerializationInfo info, StreamingContext context ) {
            Pruefung.ArgumentNichtNull( info, "info" );

            info.AddValue( "personalnummer", Personalnummer );
            info.AddValue( "titel", Titel );
            info.AddValue( "vorname", Vorname );
            info.AddValue( "nachname", Nachname );
        }

        #endregion
    }
}
