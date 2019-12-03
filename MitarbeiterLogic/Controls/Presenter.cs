using System;
using System.ComponentModel;
using MITARBEITER.INFRASTRUKTUR;
using MITARBEITER.LOGIC.DATENQUELLE;
using MITARBEITER.LOGIC.OBJEKTE;
using Ninject;

namespace MITARBEITER.LOGIC.CONTROLS {

    /// <summary>
    /// Eine <see cref="IPresenter"/>-Implementierung zur Kommunikation zwischen einer <see cref="IView"/>- und <see cref="IModel"/>-Implementierung.
    /// </summary>
    public class Presenter : IPresenter, IDisposable {

        private readonly IView view_;
        private readonly MitarbeiterListe mitarbeiterListe_;
        private readonly IKernel kernel_;
        private readonly IRepository repository_;

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="Presenter"/>-Klasse.
        /// </summary>
        /// <param name="view">Eine <see cref="IView"/>-Implementierung zur Darstellung eines Formulars.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn ein Parameter <see langword="null"/> ist.</exception>
        public Presenter( IView view ) {
            Pruefung.ArgumentNichtNull( view, "view" );

            kernel_ = new StandardKernel();
            kernel_.Bind<IZugriffDatenquelle>().To<ZugriffXml>();
            kernel_.Bind<IRepository>().To<Repository>();
            kernel_.Bind<IView>().ToConstant( view );

            repository_ = kernel_.Get<IRepository>();
            view_ = kernel_.Get<IView>();
            view_.PropertyChanged += ViewPropertyChanged;

            mitarbeiterListe_ = repository_.gibAlleMitarbeiter();
            if( mitarbeiterListe_.Count > 0 ) {
                aktualisiereMitarbeiter( mitarbeiterListe_.First );
            }
        }

        #region Private Methoden

        private void aktualisiereMitarbeiter( Mitarbeiter mitarbeiter ) {
            view_.Personalnummer = mitarbeiter.Person.Personalnummer;
            view_.Titel = mitarbeiter.Person.Titel;
            view_.Vorname = mitarbeiter.Person.Vorname;
            view_.Nachname = mitarbeiter.Person.Nachname;
            view_.Abteilung = mitarbeiter.Abteilung;
            view_.Anzahl = mitarbeiterListe_.Info;
        }

        private void ViewPropertyChanged( object sender, PropertyChangedEventArgs propertyChangedEventArgs ) {
            if( propertyChangedEventArgs.PropertyName.Equals( "speichern" ) ) {
                repository_.speichereAlleMitarbeiter( mitarbeiterListe_ );
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "buttonVor" ) ) {
                aktualisiereMitarbeiter( mitarbeiterListe_.Next );
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "buttonZurueck" ) ) {
                aktualisiereMitarbeiter( mitarbeiterListe_.Previous );
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "neu" ) ) {
                aktualisiereMitarbeiter( mitarbeiterListe_.New );
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "textBoxPersonalnummer" ) ) {
                mitarbeiterListe_.Current.Person.Personalnummer = view_.Personalnummer;
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "textBoxTitel" ) ) {
                mitarbeiterListe_.Current.Person.Titel = view_.Titel;
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "textBoxVorname" ) ) {
                mitarbeiterListe_.Current.Person.Vorname = view_.Vorname;
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "textBoxNachname" ) ) {
                mitarbeiterListe_.Current.Person.Nachname = view_.Nachname;
            }
            else if( propertyChangedEventArgs.PropertyName.Equals( "textBoxAbteilung" ) ) {
                mitarbeiterListe_.Current.Abteilung = view_.Abteilung;
            }
        }

        #endregion

        #region Implementation of IDisposable

        /// <summary>
        /// Führt anwendungsspezifische Aufgaben durch, die mit der Freigabe, der Zurückgabe oder dem Zurücksetzen von nicht verwalteten Ressourcen zusammenhängen.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose() {
            kernel_.Dispose();
        }

        #endregion
    }
}
