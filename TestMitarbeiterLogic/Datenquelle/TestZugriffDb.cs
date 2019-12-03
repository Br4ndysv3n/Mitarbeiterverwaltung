using System;
using MITARBEITER.LOGIC.OBJEKTE;
using Moq;
using NUnit.Framework;

namespace MITARBEITER.LOGIC.DATENQUELLE.MODULTEST {

    /// <summary>
    /// Integrationstest der Klasse <see cref="ZugriffDb"/>.
    /// </summary>
    [TestFixture]
    public class TestZugriffDb {

        /// <summary>
        /// Testet das Auslösen der Exceptions.
        /// </summary>
        [Test]
        public void TestExceptions() {
            IZugriffDatenquelle zugriffDatenquelle = new ZugriffDb();

            Assert.Throws<NotImplementedException>( () => zugriffDatenquelle.gibPerson( It.IsAny<string>() ) );
            Assert.Throws<NotImplementedException>( () => zugriffDatenquelle.speichereAlleMitarbeiter( It.IsAny<MitarbeiterListe>() ) );
            Assert.Throws<NotImplementedException>( () => zugriffDatenquelle.gibAlleMitarbeiter() );
        }
    }
}
