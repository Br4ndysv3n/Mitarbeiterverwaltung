using System.ComponentModel;

namespace MITARBEITER.LOGIC.CONTROLS {

    /// <summary>
    /// Eine Schnittstelle für alle Formulare.
    /// </summary>
    public interface IView : INotifyPropertyChanged {

        /// <summary>
        /// Liefert die Personalnummer oder legt diese fest.
        /// </summary>
        string Personalnummer { get; set; }

        /// <summary>
        /// Liefert den Titel oder legt diesen fest.
        /// </summary>
        string Titel { get; set; }

        /// <summary>
        /// Liefert den Vornamen oder legt diesen fest.
        /// </summary>
        string Vorname { get; set; }

        /// <summary>
        /// Liefert den Nachnamen oder legt diesen fest.
        /// </summary>
        string Nachname { get; set; }

        /// <summary>
        /// Liefert die Abteilung oder legt diese fest.
        /// </summary>
        string Abteilung { get; set; }

        /// <summary>
        /// Legt die Information fest, welcher Datensatz angezeigt wird.
        /// </summary>
        string Anzahl { set; }
    }
}
