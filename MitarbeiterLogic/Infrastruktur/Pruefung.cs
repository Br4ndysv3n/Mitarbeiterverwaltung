using System;

namespace MITARBEITER.INFRASTRUKTUR {

    /// <summary>
    /// Diese Hilfklasse enthält Methoden zur Sicherstellung von Vorbedingungen.
    /// </summary>
    public static class Pruefung {

        /// <summary>
        /// Wirft eine <see cref="ArgumentNullException"/>, wenn der übergebene Wert <see langword="null"/> ist.
        /// </summary>
        /// <param name="value">Der zu prÜfende Wert.</param>
        /// <param name="name">Der Name des Parameters, welcher in der Ausnahme erscheinen soll.</param>
        /// <exception cref="ArgumentNullException">Wird geworfen, wenn der zu prÜfende Wert <see langword="null"/> 
        /// ist.</exception>
        public static void ArgumentNichtNull( object value, string name ) {
            if( value == null )
                throw new ArgumentNullException( name );
        }

        /// <summary>
        /// Wirft eine <see cref="ArgumentNullException"/>, wenn der übergebene Wert <see langword="null"/> ist oder 
        /// eine <see cref="ArgumentException"/>, wenn der Übergebene Wert eine Länge von <b>0</b> besitzt.
        /// </summary>
        /// <param name="value">Der zu prÜfende Wert.</param>
        /// <param name="name">Der Name des Parameters, welcher in der Ausnahme erscheinen soll.</param>
        /// <exception cref="ArgumentNullException">Wird geworfen, wenn der zu prüfende Wert <see langword="null"/> ist.</exception>
        /// <exception cref="ArgumentException">Wird geworfen, wenn der zu prüfende Wert eine Länge von <b>0</b> besitzt.</exception>
        public static void ZeichenketteNichtNullOderLeer( string value, string name ) {
            if( value == null )
                throw new ArgumentNullException( name );
            if( value.Length <= 0 )
                throw new ArgumentException( name );
        }
    }
}
