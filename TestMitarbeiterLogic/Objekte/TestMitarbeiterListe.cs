using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using NUnit.Framework;

namespace MITARBEITER.LOGIC.OBJEKTE.MODULTEST {

    /// <summary>
    /// Test für die Klasse <see cref="MitarbeiterListe"/>.
    /// </summary>
    [TestFixture]
    public class TestMitarbeiterListe {

        /// <summary>
        /// Testet den Aufruf über einen leeren Konstruktor.
        /// </summary>
        [Test]
        public void TestLeererKonstruktor() {
            var mitarbeiterListe = new MitarbeiterListe();
            Assert.IsNotNull( mitarbeiterListe.Mitarbeiter, "Mitarbeiter" );
        }

        /// <summary>
        /// Testet das Auslesen über ein SerializationInfo-Objekt.
        /// </summary>
        [Test]
        public void TestSerializationInfo() {
            var serializationInfo = new SerializationInfo( typeof( MitarbeiterListe ), new FormatterConverter() );
            serializationInfo.AddValue( "Mitarbeiter", new List<Mitarbeiter> { new Mitarbeiter( new Person(), "Entwicklung" ) } );
            var mitarbeiterListe = new MitarbeiterListe( serializationInfo, new StreamingContext() );
            Assert.AreEqual( 1, mitarbeiterListe.Mitarbeiter.Count, "Anzahl der Mitarbeiter" );
            Assert.AreEqual( "Entwicklung", mitarbeiterListe.Mitarbeiter[ 0 ].Abteilung );

            var serializationInfoGelesen = new SerializationInfo( typeof( List<Mitarbeiter> ), new FormatterConverter() );
            mitarbeiterListe.GetObjectData( serializationInfoGelesen, new StreamingContext() );

            var mitarbeiterGelesen = ( List<Mitarbeiter> ) serializationInfo.GetValue( "Mitarbeiter", typeof( List<Mitarbeiter> ) );
            Assert.AreEqual( 1, mitarbeiterGelesen.Count, "Anzahl gelesener Mitarbeiter" );
            Assert.AreEqual( "Entwicklung", mitarbeiterGelesen[ 0 ].Abteilung, "Abteilung des gelesenen Mitarbeiters" );
        }

        /// <summary>
        /// Testet die Listenoperationen.
        /// </summary>
        [Test]
        public void TestListenoperationen() {
            var mitarbeiter1 = new Mitarbeiter( new Person( "1", "Mr.", "John", "Doe" ), "Marketing" );
            var mitarbeiter2 = new Mitarbeiter( new Person( "2", "Ms.", "Jane", "Smith" ), "Entwicklung" );
            
            var mitarbeiterListe = new MitarbeiterListe();
            mitarbeiterListe.Add( mitarbeiter1 );
            mitarbeiterListe.Add( mitarbeiter2 );

            Assert.AreEqual( 2, mitarbeiterListe.Count, "Anzahl nach dem Hinzufügen" );
            Assert.AreEqual( mitarbeiter1, mitarbeiterListe.First, "Mitarbeiter an erster Position" );
            Assert.AreEqual( "1 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter2, mitarbeiterListe.Next, "Mitarbeiter an nächster Position" );
            Assert.AreEqual( "2 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter2, mitarbeiterListe.Next, "Mitarbeiter an nochmaliger nächster Position" );
            Assert.AreEqual( "2 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter1, mitarbeiterListe.Previous, "Mitarbeiter an vorheriger Position" );
            Assert.AreEqual( "1 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter1, mitarbeiterListe.Previous, "Mitarbeiter an nochmaliger vorheriger Position" );
            Assert.AreEqual( "1 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter2, mitarbeiterListe.Last, "Mitarbeiter an letzter Position" );
            Assert.AreEqual( "2 / 2", mitarbeiterListe.Info, "Info" );
            Assert.AreEqual( mitarbeiter2, mitarbeiterListe.Current, "Mitarbeiter an aktueller Position" );
            Assert.AreEqual( "2 / 2", mitarbeiterListe.Info, "Info" );
            Assert.IsNotNull( mitarbeiterListe.New, "Mitarbeiter an neuer Position" );
            Assert.AreEqual( 3, mitarbeiterListe.Count, "Anzahl nach dem Hinzufügen eines neuen Mitarbeiters" );

            Assert.AreEqual( "3 / 3", mitarbeiterListe.Info, "Info" );
            var ma = mitarbeiterListe.First;
            Assert.AreEqual( "1 / 3", mitarbeiterListe.Info, "Info" );
        }
    }
}
