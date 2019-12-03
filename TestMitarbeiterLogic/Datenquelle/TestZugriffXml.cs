using System;
using System.IO;
using MITARBEITER.LOGIC.OBJEKTE;
using Moq;
using NUnit.Framework;

namespace MITARBEITER.LOGIC.DATENQUELLE.INTEGRATIONSTEST {

    /// <summary>
    /// Test für die Klasse <see cref="ZugriffXml"/>.
    /// </summary>
    [TestFixture]
    public class TestZugriffXml {

        /// <summary>
        /// Testet das Speichern und Aulesen der Mitarbeiter.
        /// </summary>
        [Test]
        public void TestMethode() {
            var zugriffXml = new ZugriffXml( @"mitarbeiter_test.xml" );
            var mitarbeiterListe = new MitarbeiterListe();
            mitarbeiterListe.Add( new Mitarbeiter( new Person( "1", "Mr", "John", "Doe" ), "Entwicklung" ) );
            zugriffXml.speichereAlleMitarbeiter( mitarbeiterListe );

            var mitarbeiter = zugriffXml.gibAlleMitarbeiter();
            Assert.AreEqual( 1, mitarbeiter.Count, "Anzahl der Mitarbeiter" );
        }

        /// <summary>
        /// Testet das Ermitteln aller Mitarbeiter bei fehlender Datei.
        /// </summary>
        [Test]
        public void TestGibAlleMitarbeiterUnbekannteDatei() {
            var dateiname = @"foobar.xml";
            if( File.Exists( dateiname ) ) {
                File.Delete( dateiname );
            }

            var zugriffXml = new ZugriffXml( dateiname );
            var mitarbeiter = zugriffXml.gibAlleMitarbeiter();
            Assert.AreEqual( 1, mitarbeiter.Count, "Anzahl Mitarbeiter" );
            Assert.IsNotNull( mitarbeiter.Current );
            Assert.IsNotNull( mitarbeiter.Current.Person );
            Assert.AreEqual( string.Empty, mitarbeiter.Current.Person.Personalnummer );
        }

        /// <summary>
        /// Testet das Ermitteln einer Person anhand der Personalnummer. Die Methode ist noch nicht implementiert.
        /// </summary>
        [Test]
        public void TestGibPersonAnhandPersonalnummer() {
            var zugriffXml = new ZugriffXml();
            Assert.Throws<NotImplementedException>( () => zugriffXml.gibPerson( It.IsAny<string>() ) );
        }
    }
}
