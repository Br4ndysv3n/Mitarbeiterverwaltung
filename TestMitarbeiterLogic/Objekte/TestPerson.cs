using System;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace MITARBEITER.LOGIC.OBJEKTE.MODULTEST {

    /// <summary>
    /// Modultest der Klasse <see cref="Person"/>.
    /// </summary>
    [TestFixture]
    public class TestPerson {

        /// <summary>
        /// Testet das Auslösen der Exceptions.
        /// </summary>
        [Test]
        public void TestExceptions() {
            Assert.Throws<ArgumentNullException>( () => new Person( null, null, "John", "Doe" ) );
            Assert.Throws<ArgumentNullException>( () => new Person( "1", null, "John", "Doe" ) );
            Assert.Throws<ArgumentNullException>( () => new Person( "1", "Mr.", null, "Doe" ) );
            Assert.Throws<ArgumentNullException>( () => new Person( "1", "Mr.", "John", null ) );

            Assert.Throws<ArgumentException>( () => new Person( string.Empty, string.Empty, "John", "Doe" ) );
            Assert.Throws<ArgumentException>( () => new Person( "1", string.Empty, "John", "Doe" ) );
            Assert.Throws<ArgumentException>( () => new Person( "1", "Mr.", string.Empty, "Doe" ) );
            Assert.Throws<ArgumentException>( () => new Person( "1", "Mr.", "John", string.Empty ) );
        }

        /// <summary>
        /// Testet das Setzen und Lesen der Inhalte über Konstruktor.
        /// </summary>
        [Test]
        public void TestParameter() {
            var person = new Person( "1", "Mr.", "John", "Doe" );
            Assert.AreEqual( "1", person.Personalnummer, "Personalnummer" );
            Assert.AreEqual( "Mr.", person.Titel, "Titel der Person" );
            Assert.AreEqual( "John", person.Vorname, "Vorname der Person" );
            Assert.AreEqual( "Doe", person.Nachname, "Nachname der Person" );
        }

        /// <summary>
        /// Testet das Auslesen der Daten aus einem <see cref="SerializationInfo"/>-Objekt via GetObjectData-Methode.
        /// </summary>
        [Test]
        public void TestPersonAusSerializationInfo() {
            var serializationInfo = new SerializationInfo( typeof( Person ), new FormatterConverter() );
            serializationInfo.AddValue( "personalnummer", "1" );
            serializationInfo.AddValue( "titel", "Mr." );
            serializationInfo.AddValue( "vorname", "John" );
            serializationInfo.AddValue( "nachname", "Doe" );

            var person = new Person( serializationInfo, new StreamingContext() );
            Assert.AreEqual( "1", person.Personalnummer, "Personalnummer" );
            Assert.AreEqual( "Mr.", person.Titel, "Titel" );
            Assert.AreEqual( "John", person.Vorname, "Vorname" );
            Assert.AreEqual( "Doe", person.Nachname, "Nachname" );

            var serializationInfoGelesen = new SerializationInfo( typeof( Person ), new FormatterConverter() );
            person.GetObjectData( serializationInfoGelesen, new StreamingContext() );
            Assert.AreEqual( person.Personalnummer, serializationInfoGelesen.GetValue( "personalnummer", typeof( string ) ), "Personalnummer" );
            Assert.AreEqual( person.Titel, serializationInfoGelesen.GetValue( "titel", typeof( string ) ), "Titel" );
            Assert.AreEqual( person.Vorname, serializationInfoGelesen.GetValue( "vorname", typeof( string ) ), "Vorname" );
            Assert.AreEqual( person.Nachname, serializationInfoGelesen.GetValue( "nachname", typeof( string ) ), "Nachname" );
        }

        /// <summary>
        /// Testet das Setzen der Informationen via Default-Parameter.
        /// </summary>
        [Test]
        public void TestLeererKonstruktor() {
            var person = new Person();
            Assert.AreEqual( string.Empty, person.Personalnummer, "Personalnummer" );
            Assert.AreEqual( string.Empty, person.Titel, "Titel" );
            Assert.AreEqual( string.Empty, person.Vorname, "Vorname" );
            Assert.AreEqual( string.Empty, person.Nachname, "Nachname" );
        }
    }
}
