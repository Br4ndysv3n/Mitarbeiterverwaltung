using System;
using MITARBEITER.LOGIC.DATENQUELLE;
using MITARBEITER.LOGIC.OBJEKTE;
using Moq;
using NUnit.Framework;

namespace MITARBEITER.LOGIC {

    /// <summary>
    /// Modultest der Klasse <see cref="Repository"/>.
    /// </summary>
    [TestFixture]
    public class TestRepository {

        /// <summary>
        /// Testet das Auslösen der Exceptions.
        /// </summary>
        [Test]
        public void TestExceptions() {
            Assert.Throws<ArgumentNullException>( () => new Repository( null ) );
        }

        /// <summary>
        /// Testet das Ermitteln einer Person anhand der Personalnummer.
        /// </summary>
        [Test]
        public void TestGibPersonMitPersonalnummer() {

            // Ein Zugriff auf eine Datenbank besteht nicht, also müssen wir ein Mockup der Fabrik erzeugen, das uns ein Mockup der Person liefert.
            var personMock = new Person();
            personMock.Personalnummer = "1";
            personMock.Titel = "Mr.";
            personMock.Vorname = "John";
            personMock.Nachname = "Doe";

            var fabrikMock = new Mock<IZugriffDatenquelle>();
            fabrikMock.Setup( mock => mock.gibPerson( "1" ) ).Returns( personMock );

            var repository = new Repository( fabrikMock.Object );
            var person = repository.gibPersonMitPersonalnummer( "1" );

            Assert.AreEqual( "1", person.Personalnummer, "Personalnummer" );
            Assert.AreEqual( "Mr.", person.Titel, "Titel" );
            Assert.AreEqual( "John", person.Vorname, "Vorname" );
            Assert.AreEqual( "Doe", person.Nachname, "Nachname" );
        }

        /// <summary>
        /// Testet das Ermitteln aller Mitarbeiter.
        /// </summary>
        [Test]
        public void TestGibAlleMitarbeiter() {
            var zugriffDatenquelleMock = new Mock<IZugriffDatenquelle>();
            var repository = new Repository( zugriffDatenquelleMock.Object );
            repository.gibAlleMitarbeiter();
            zugriffDatenquelleMock.Verify( mock => mock.gibAlleMitarbeiter(), Times.Once(), "Zugriff Datenquelle nicht aufgerufen" );
        }

        /// <summary>
        /// Testet das Ermitteln aller Mitarbeiter.
        /// </summary>
        [Test]
        public void TestSpeichereMitarbeiter() {
            var zugriffDatenquelleMock = new Mock<IZugriffDatenquelle>();
            var repository = new Repository( zugriffDatenquelleMock.Object );

            var mitarbeiterListe = new MitarbeiterListe();
            repository.speichereAlleMitarbeiter( mitarbeiterListe );
            zugriffDatenquelleMock.Verify( mock => mock.speichereAlleMitarbeiter( mitarbeiterListe ), Times.Once(), "Zugriff Datenquelle nicht aufgerufen" );
        }
    }
}
