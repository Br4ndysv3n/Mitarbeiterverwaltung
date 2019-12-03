using System;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace MITARBEITER.LOGIC.OBJEKTE.MODULTEST {

    /// <summary>
    /// Modultest der Klasse <see cref="Mitarbeiter"/>.
    /// </summary>
    [TestFixture]
    public class TestMitarbeiter {

        /// <summary>
        /// Testet das Auslösen der Exceptions.
        /// </summary>
        [Test]
        public void TestExceptions() {
            var personMock = new Person();
            Assert.Throws<ArgumentNullException>( () => new Mitarbeiter( null, "Management" ) );
            Assert.Throws<ArgumentNullException>( () => new Mitarbeiter( personMock, null ) );
            Assert.Throws<ArgumentException>( () => new Mitarbeiter( personMock, string.Empty ) );
        }

        /// <summary>
        /// Testet das Setzen und Lesen der Abteilung.
        /// </summary>
        [Test]
        public void TestAbteilung() {
            var personMock = new Person();

            var mitarbeiter = new Mitarbeiter( personMock, "Management" );
            Assert.AreEqual( mitarbeiter.Abteilung, "Management", "Abteilung des Mitarbeiters" );
        }

        /// <summary>
        /// Testet das Auslesen der Daten aus einem <see cref="SerializationInfo"/>-Objekt via GetObjectData-Methode.
        /// </summary>
        [Test]
        public void TestMitarbeiterAusSerializationInfo() {
            var serializationInfo = new SerializationInfo( typeof( Person ), new FormatterConverter() );
            serializationInfo.AddValue( "abteilung", "entwicklung" );

            var mitarbeiter = new Mitarbeiter( serializationInfo, new StreamingContext() );
            Assert.AreEqual( "entwicklung", mitarbeiter.Abteilung, "Abteilung" );

            var serializationInfoGelesen = new SerializationInfo( typeof( Person ), new FormatterConverter() );
            mitarbeiter.GetObjectData( serializationInfoGelesen, new StreamingContext() );
            Assert.AreEqual( mitarbeiter.Abteilung, serializationInfoGelesen.GetValue( "abteilung", typeof( string ) ), "Abteilung" );
        }

        /// <summary>
        /// Testet das Setzen der Informationen via Default-Parameter.
        /// </summary>
        [Test]
        public void TestLeererKonstruktor() {
            var mitarbeiter = new Mitarbeiter();
            Assert.AreEqual( string.Empty, mitarbeiter.Abteilung, "Abteilung" );
        }
    }
}
