using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using MITARBEITER.INFRASTRUKTUR;
using MITARBEITER.LOGIC.OBJEKTE;

namespace MITARBEITER.LOGIC.DATENQUELLE {

    /// <summary>
    /// Stellt den Zugriff auf eine XML-Datei her.
    /// </summary>
    public sealed class ZugriffXml : IZugriffDatenquelle {

        private readonly string dateiname_ = @"mitarbeiter.xml";

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="ZugriffXml"/>-Klasse.
        /// </summary>
        public ZugriffXml( string dateiname = "" ) {
            dateiname_ = string.IsNullOrEmpty( dateiname ) ? @"mitarbeiter.xml" : dateiname;
        }

        /// <summary>
        /// Liest die Informationen einer <see cref="Person"/> aus der XML-Datei.
        /// </summary>
        /// <param name="personalnummer">Die Personalnummer.</param>
        /// <exception cref="NotImplementedException">Wird ausgelöst, weil die Funktion noch nicht implementiert ist.</exception>
        public Person gibPerson( string personalnummer ) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liest eine Liste aller Mitarbeiter aus der XML-Datei.
        /// </summary>
        /// <returns>Eine <see cref="MitarbeiterListe"/>.</returns>
        public MitarbeiterListe gibAlleMitarbeiter() {
            var serializer = new XmlSerializer( typeof( MitarbeiterListe ) );
            if( File.Exists( dateiname_ ) == false ) {
                var mitarbeiterListe = new MitarbeiterListe();
                mitarbeiterListe.Add( new Mitarbeiter() );
                return mitarbeiterListe;
            }
            using( var xmlReader = new XmlTextReader( dateiname_ ) ) {
                return ( MitarbeiterListe ) serializer.Deserialize( xmlReader );
            }
        }

        /// <summary>
        /// Speichert eine Liste der Mitarbeiter in der XML-Datei.
        /// </summary>
        /// <param name="mitarbeiterListe">Eine <see cref="MitarbeiterListe"/>.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="mitarbeiterListe"/> <see langword="null"/> ist.</exception>
        public void speichereAlleMitarbeiter( MitarbeiterListe mitarbeiterListe ) {
            Pruefung.ArgumentNichtNull( mitarbeiterListe, "mitarbeiterListe" );

            var serializer = new XmlSerializer( typeof( MitarbeiterListe ) );
            using( var xmlWriter = new XmlTextWriter( dateiname_, Encoding.UTF8 ) ) {
                serializer.Serialize( xmlWriter, mitarbeiterListe );
            }
        }
    }
}
