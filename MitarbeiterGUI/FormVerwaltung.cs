using System;
using System.ComponentModel;
using System.Windows.Forms;
using MITARBEITER.GUI.Properties;
using MITARBEITER.LOGIC.CONTROLS;

namespace MITARBEITER.GUI {
    public partial class FormVerwaltung : Form, IView {

        /// <summary>
        /// Erstellt eine neue Instanz der <see cref="FormVerwaltung"/>-Klasse.
        /// </summary>
        public FormVerwaltung() {
            InitializeComponent();
        }

        #region Implementation of INotifyPropertyChanged

        /// <summary>
        /// Tritt ein, wenn sich ein Eigenschaftswert ändert.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Private Event-Methoden

        private void OnLoad( object sender, EventArgs e ) {
            try {
                if( DesignMode == false ) {
                    new Presenter( this );
                }
            }
            catch( Exception ex ) {
                dialogFehlerAnzeigen( ex );
            }
        }

        private void DatenGeaendert( object sender, KeyEventArgs e ) {
            Application.DoEvents();

            try {
                if( sender is TextBox && PropertyChanged != null ) {
                    PropertyChanged( sender, new PropertyChangedEventArgs( ( sender as TextBox ).Name ) );
                }

                toolStripButtonSpeichern.Enabled = true;

            }
            catch( Exception ex ) {
                dialogFehlerAnzeigen( ex );
            }
        }

        private void buttonVor_Click( object sender, EventArgs e ) {
            if( PropertyChanged != null ) {
                PropertyChanged( sender, new PropertyChangedEventArgs( "buttonVor" ) );
            }
        }

        private void buttonZurueck_Click( object sender, EventArgs e ) {
            if( PropertyChanged != null ) {
                PropertyChanged( sender, new PropertyChangedEventArgs( "buttonZurueck" ) );
            }
        }

        private void toolStripButtonSpeichern_Click( object sender, EventArgs e ) {
            if( PropertyChanged != null ) {
                PropertyChanged( sender, new PropertyChangedEventArgs( "speichern" ) );
            }

            toolStripButtonSpeichern.Enabled = false;
        }

        private void toolStripButtonNeu_Click( object sender, EventArgs e ) {
            if( PropertyChanged != null ) {
                PropertyChanged( sender, new PropertyChangedEventArgs( "neu" ) );
            }
        }

        private void toolStripButtonBeenden_Click( object sender, EventArgs e ) {
            OnClosing( null, new FormClosingEventArgs( CloseReason.UserClosing, false ) );
        }

        private void OnClosing( object sender, FormClosingEventArgs e ) {
            try {
                if( toolStripButtonSpeichern.Enabled ) {
                    var result = MessageBox.Show( Resources.FrageVorBeendenSpeichern, Resources.CaptionFrage, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
                    switch( result ) {
                        case DialogResult.Yes:
                            toolStripButtonSpeichern.PerformClick();
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            e.Cancel = true;
                            break;
                    }
                }
            }
            catch( Exception ex ) {
                dialogFehlerAnzeigen( ex );
                e.Cancel = false;
            }
        }

        #endregion

        #region Implementation of IView

        /// <summary>
        /// Liefert die Personalnummer oder legt diese fest.
        /// </summary>
        public string Personalnummer {
            get { return textBoxPersonalnummer.Text; }
            set { textBoxPersonalnummer.Text = value; }
        }

        /// <summary>
        /// Liefert den Titel oder legt diesen fest.
        /// </summary>
        public string Titel {
            get { return textBoxTitel.Text; }
            set { textBoxTitel.Text = value; }
        }

        /// <summary>
        /// Liefert den Vornamen oder legt diesen fest.
        /// </summary>
        public string Vorname {
            get { return textBoxVorname.Text; }
            set { textBoxVorname.Text = value; }
        }

        /// <summary>
        /// Liefert den Nachnamen oder legt diesen fest.
        /// </summary>
        public string Nachname {
            get { return textBoxNachname.Text; }
            set { textBoxNachname.Text = value; }
        }

        /// <summary>
        /// Liefert die Abteilung oder legt diese fest.
        /// </summary>
        public string Abteilung {
            get { return textBoxAbteilung.Text; }
            set { textBoxAbteilung.Text = value; }
        }

        /// <summary>
        /// Legt die Information fest, welcher Datensatz angezeigt wird.
        /// </summary>
        public string Anzahl {
            set { toolStripLabelZaehler.Text = value; }
        }

        #endregion

        private void dialogFehlerAnzeigen( Exception ex ) {
            MessageBox.Show( ex.Message, Resources.CaptionFehler, MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
