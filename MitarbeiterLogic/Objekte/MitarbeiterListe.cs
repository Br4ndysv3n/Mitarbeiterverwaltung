using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;
using MITARBEITER.INFRASTRUKTUR;

namespace MITARBEITER.LOGIC.OBJEKTE {

    /// <summary>
    /// Bildet einen Mitarbeiter ab.
    /// </summary>
    [Serializable]
    public sealed class MitarbeiterListe : ISerializable {

        public List<Mitarbeiter> Mitarbeiter { get; set; }
        private int position_;

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="MitarbeiterListe"/>-Klasse.
        /// </summary>
        public MitarbeiterListe() {
            Mitarbeiter = new List<Mitarbeiter>();
            position_ = 0;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="MitarbeiterListe"/>-Klasse.
        /// </summary>
        /// <param name="info">Das <see cref="SerializationInfo"/>-Objekt, das die Daten nach der Deserialisierung enthält.</param>
        /// <param name="ctxt">Der <see cref="StreamingContext"/>.</param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="info"/> <see langword="null"/> ist.</exception>
        public MitarbeiterListe( SerializationInfo info, StreamingContext ctxt )
            : this() {
            Pruefung.ArgumentNichtNull( info, "info" );

            Mitarbeiter = ( List<Mitarbeiter> ) info.GetValue( "Mitarbeiter", typeof( List<Mitarbeiter> ) );
        }

        /// <summary>
        /// Füllt eine <see cref="SerializationInfo"/> mit den Daten, die zum Serialisieren des Zielobjekts erforderlich sind.
        /// </summary>
        /// <param name="info">Die mit Daten zu füllende <see cref="SerializationInfo"/>. </param>
        /// <param name="context">Das Ziel (siehe <see cref="StreamingContext"/>) dieser Serialisierung. </param>
        /// <exception cref="SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung. </exception>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn der Parameter <paramref name="info"/> <see langword="null"/> ist.</exception>
        public void GetObjectData( SerializationInfo info, StreamingContext context ) {
            Pruefung.ArgumentNichtNull( info, "info" );

            info.AddValue( "Mitarbeiter", Mitarbeiter );
        }

        /// <summary>
        /// Fügt einen neuen Mitarbeiter hinzu.
        /// </summary>
        /// <param name="mitarbeiter"></param>
        public void Add( Mitarbeiter mitarbeiter ) {
            Mitarbeiter.Add( mitarbeiter );
        }

        /// <summary>
        /// Liefert die Anzahl der Mitarbeiter.
        /// </summary>
        public int Count {
            get { return Mitarbeiter.Count; }
        }

        /// <summary>
        /// Liefert einen Mitarbeiter an einer bestimmten Position der Liste.
        /// </summary>
        /// <param name="i">Der Index.</param>
        /// <returns>Ein Mitarbeiter-Objekt.</returns>
        public Mitarbeiter this[ int i ] {
            get { return Mitarbeiter[ i ]; }
        }

        /// <summary>
        /// Liefert das erste Mitarbeiter-Objekt der Liste..
        /// </summary>
        public Mitarbeiter First {
            get {
                if( Mitarbeiter.Count <= 0 ) {
                    Mitarbeiter.Add( new Mitarbeiter() );
                }
                position_ = 0;
                return Mitarbeiter[ position_ ];
            }
        }

        /// <summary>
        /// Liefert das nächste Mitarbeiter-Objekt der Liste.
        /// </summary>
        public Mitarbeiter Next {
            get {
                if( position_ < Mitarbeiter.Count - 1 ) {
                    position_++;
                }
                return Mitarbeiter[ position_ ];
            }
        }

        /// <summary>
        /// Liefert das vorhergehende Mitarbeiter-Objekt der Liste.
        /// </summary>
        public Mitarbeiter Previous {
            get {
                if( position_ > 0 ) {
                    return Mitarbeiter[ --position_ ];
                }
                return Mitarbeiter[ 0 ];
            }
        }

        /// <summary>
        /// Liefert das letzte Mitarbeiter-Objekt der Liste.
        /// </summary>
        public Mitarbeiter Last {
            get {
                position_ = Mitarbeiter.Count - 1;
                return Mitarbeiter[ position_ ];
            }
        }

        /// <summary>
        /// Erstellt und liefert ein neues Mitarbeiter-Objekt.
        /// </summary>
        public Mitarbeiter New {
            get {
                Mitarbeiter.Add( new Mitarbeiter() );
                return Last;
            }
        }

        /// <summary>
        /// Liefert das aktuelle Mitarbeiter-Objekt.
        /// </summary>
        public Mitarbeiter Current {
            get { return Mitarbeiter[ position_ ]; }
        }

        /// <summary>
        /// Liefert eine Information, welcher Datensatz ausgewählt wurde.
        /// </summary>
        public string Info {
            get { return string.Format( "{0} / {1}", position_ + 1, Mitarbeiter.Count ); }
        }
    }
}
