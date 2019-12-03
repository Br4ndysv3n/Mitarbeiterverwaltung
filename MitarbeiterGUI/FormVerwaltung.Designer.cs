using System;

namespace MITARBEITER.GUI {

    partial class FormVerwaltung {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerwaltung));
            this.textBoxPersonalnummer = new System.Windows.Forms.TextBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.labelPersonalnummer = new System.Windows.Forms.Label();
            this.groupBoxPerson = new System.Windows.Forms.GroupBox();
            this.labelAbteilung = new System.Windows.Forms.Label();
            this.textBoxAbteilung = new System.Windows.Forms.TextBox();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNeu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSpeichern = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZurueck = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelZaehler = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonVor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBeenden = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPerson.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPersonalnummer
            // 
            this.textBoxPersonalnummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPersonalnummer.Location = new System.Drawing.Point(108, 19);
            this.textBoxPersonalnummer.Name = "textBoxPersonalnummer";
            this.textBoxPersonalnummer.Size = new System.Drawing.Size(193, 20);
            this.textBoxPersonalnummer.TabIndex = 0;
            this.textBoxPersonalnummer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatenGeaendert);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitel.Location = new System.Drawing.Point(108, 45);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(193, 20);
            this.textBoxTitel.TabIndex = 1;
            this.textBoxTitel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatenGeaendert);
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVorname.Location = new System.Drawing.Point(108, 71);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(193, 20);
            this.textBoxVorname.TabIndex = 2;
            this.textBoxVorname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatenGeaendert);
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNachname.Location = new System.Drawing.Point(108, 97);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(193, 20);
            this.textBoxNachname.TabIndex = 3;
            this.textBoxNachname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatenGeaendert);
            // 
            // labelPersonalnummer
            // 
            this.labelPersonalnummer.AutoSize = true;
            this.labelPersonalnummer.Location = new System.Drawing.Point(14, 22);
            this.labelPersonalnummer.Name = "labelPersonalnummer";
            this.labelPersonalnummer.Size = new System.Drawing.Size(88, 13);
            this.labelPersonalnummer.TabIndex = 5;
            this.labelPersonalnummer.Text = "Personalnummer:";
            // 
            // groupBoxPerson
            // 
            this.groupBoxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPerson.Controls.Add(this.labelAbteilung);
            this.groupBoxPerson.Controls.Add(this.textBoxAbteilung);
            this.groupBoxPerson.Controls.Add(this.labelNachname);
            this.groupBoxPerson.Controls.Add(this.textBoxNachname);
            this.groupBoxPerson.Controls.Add(this.labelVorname);
            this.groupBoxPerson.Controls.Add(this.textBoxVorname);
            this.groupBoxPerson.Controls.Add(this.labelTitel);
            this.groupBoxPerson.Controls.Add(this.textBoxTitel);
            this.groupBoxPerson.Controls.Add(this.labelPersonalnummer);
            this.groupBoxPerson.Controls.Add(this.textBoxPersonalnummer);
            this.groupBoxPerson.Location = new System.Drawing.Point(12, 40);
            this.groupBoxPerson.Name = "groupBoxPerson";
            this.groupBoxPerson.Size = new System.Drawing.Size(316, 157);
            this.groupBoxPerson.TabIndex = 6;
            this.groupBoxPerson.TabStop = false;
            this.groupBoxPerson.Text = "Personeninformationen";
            // 
            // labelAbteilung
            // 
            this.labelAbteilung.AutoSize = true;
            this.labelAbteilung.Location = new System.Drawing.Point(14, 126);
            this.labelAbteilung.Name = "labelAbteilung";
            this.labelAbteilung.Size = new System.Drawing.Size(54, 13);
            this.labelAbteilung.TabIndex = 12;
            this.labelAbteilung.Text = "Abteilung:";
            // 
            // textBoxAbteilung
            // 
            this.textBoxAbteilung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAbteilung.Location = new System.Drawing.Point(108, 123);
            this.textBoxAbteilung.Name = "textBoxAbteilung";
            this.textBoxAbteilung.Size = new System.Drawing.Size(193, 20);
            this.textBoxAbteilung.TabIndex = 4;
            this.textBoxAbteilung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatenGeaendert);
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(14, 100);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(62, 13);
            this.labelNachname.TabIndex = 8;
            this.labelNachname.Text = "Nachname:";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(14, 74);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(52, 13);
            this.labelVorname.TabIndex = 7;
            this.labelVorname.Text = "Vorname:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(14, 48);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(30, 13);
            this.labelTitel.TabIndex = 6;
            this.labelTitel.Text = "Titel:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNeu,
            this.toolStripButtonSpeichern,
            this.toolStripSeparator1,
            this.toolStripButtonZurueck,
            this.toolStripLabelZaehler,
            this.toolStripButtonVor,
            this.toolStripSeparator2,
            this.toolStripButtonBeenden});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(341, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNeu
            // 
            this.toolStripButtonNeu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNeu.Image")));
            this.toolStripButtonNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNeu.Name = "toolStripButtonNeu";
            this.toolStripButtonNeu.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonNeu.Text = "Neu";
            this.toolStripButtonNeu.Click += new System.EventHandler(this.toolStripButtonNeu_Click);
            // 
            // toolStripButtonSpeichern
            // 
            this.toolStripButtonSpeichern.Enabled = false;
            this.toolStripButtonSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSpeichern.Image")));
            this.toolStripButtonSpeichern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSpeichern.Name = "toolStripButtonSpeichern";
            this.toolStripButtonSpeichern.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSpeichern.Text = "Speichern";
            this.toolStripButtonSpeichern.Click += new System.EventHandler(this.toolStripButtonSpeichern_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonZurueck
            // 
            this.toolStripButtonZurueck.AutoSize = false;
            this.toolStripButtonZurueck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonZurueck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZurueck.Image")));
            this.toolStripButtonZurueck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZurueck.Name = "toolStripButtonZurueck";
            this.toolStripButtonZurueck.Size = new System.Drawing.Size(40, 22);
            this.toolStripButtonZurueck.Text = "<";
            this.toolStripButtonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // toolStripLabelZaehler
            // 
            this.toolStripLabelZaehler.Name = "toolStripLabelZaehler";
            this.toolStripLabelZaehler.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabelZaehler.Text = "0 / 0";
            // 
            // toolStripButtonVor
            // 
            this.toolStripButtonVor.AutoSize = false;
            this.toolStripButtonVor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonVor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVor.Image")));
            this.toolStripButtonVor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVor.Name = "toolStripButtonVor";
            this.toolStripButtonVor.Size = new System.Drawing.Size(40, 22);
            this.toolStripButtonVor.Text = ">";
            this.toolStripButtonVor.Click += new System.EventHandler(this.buttonVor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBeenden
            // 
            this.toolStripButtonBeenden.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBeenden.Image")));
            this.toolStripButtonBeenden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBeenden.Name = "toolStripButtonBeenden";
            this.toolStripButtonBeenden.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonBeenden.Text = "Beenden";
            this.toolStripButtonBeenden.Click += new System.EventHandler(this.toolStripButtonBeenden_Click);
            // 
            // FormVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 211);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxPerson);
            this.Name = "FormVerwaltung";
            this.Text = "Mitarbeiterverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBoxPerson.ResumeLayout(false);
            this.groupBoxPerson.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonalnummer;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label labelPersonalnummer;
        private System.Windows.Forms.GroupBox groupBoxPerson;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelAbteilung;
        private System.Windows.Forms.TextBox textBoxAbteilung;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNeu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSpeichern;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBeenden;
        private System.Windows.Forms.ToolStripButton toolStripButtonZurueck;
        private System.Windows.Forms.ToolStripButton toolStripButtonVor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelZaehler;
    }
}

