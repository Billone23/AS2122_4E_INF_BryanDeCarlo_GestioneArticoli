
namespace AS2122_4E_INF_BryanDeCarlo_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDettagliarticolo = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbUnitadimisura = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblUnitadimisura = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.cmbVisualizzarticoli = new System.Windows.Forms.ComboBox();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.gpbDettagliarticolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDettagliarticolo
            // 
            this.gpbDettagliarticolo.Controls.Add(this.btnAggiungi);
            this.gpbDettagliarticolo.Controls.Add(this.cmbUnitadimisura);
            this.gpbDettagliarticolo.Controls.Add(this.txtPrezzo);
            this.gpbDettagliarticolo.Controls.Add(this.txtDescrizione);
            this.gpbDettagliarticolo.Controls.Add(this.txtCodice);
            this.gpbDettagliarticolo.Controls.Add(this.lblPrezzo);
            this.gpbDettagliarticolo.Controls.Add(this.lblUnitadimisura);
            this.gpbDettagliarticolo.Controls.Add(this.lblDescrizione);
            this.gpbDettagliarticolo.Controls.Add(this.lblCodice);
            this.gpbDettagliarticolo.Location = new System.Drawing.Point(12, 21);
            this.gpbDettagliarticolo.Name = "gpbDettagliarticolo";
            this.gpbDettagliarticolo.Size = new System.Drawing.Size(380, 365);
            this.gpbDettagliarticolo.TabIndex = 0;
            this.gpbDettagliarticolo.TabStop = false;
            this.gpbDettagliarticolo.Text = "Dettagli articolo";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(54, 285);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(227, 80);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi/modifica articlo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // cmbUnitadimisura
            // 
            this.cmbUnitadimisura.FormattingEnabled = true;
            this.cmbUnitadimisura.Location = new System.Drawing.Point(133, 147);
            this.cmbUnitadimisura.Name = "cmbUnitadimisura";
            this.cmbUnitadimisura.Size = new System.Drawing.Size(76, 28);
            this.cmbUnitadimisura.TabIndex = 7;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(88, 204);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(125, 27);
            this.txtPrezzo.TabIndex = 6;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(137, 104);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(125, 27);
            this.txtDescrizione.TabIndex = 4;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(101, 50);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(125, 27);
            this.txtCodice.TabIndex = 1;
            this.txtCodice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(18, 204);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(53, 20);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblUnitadimisura
            // 
            this.lblUnitadimisura.AutoSize = true;
            this.lblUnitadimisura.Location = new System.Drawing.Point(18, 155);
            this.lblUnitadimisura.Name = "lblUnitadimisura";
            this.lblUnitadimisura.Size = new System.Drawing.Size(109, 20);
            this.lblUnitadimisura.TabIndex = 2;
            this.lblUnitadimisura.Text = "Unita di misura";
            this.lblUnitadimisura.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(18, 104);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(86, 20);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(18, 50);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(55, 20);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(724, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 29);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "...";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // cmbVisualizzarticoli
            // 
            this.cmbVisualizzarticoli.FormattingEnabled = true;
            this.cmbVisualizzarticoli.Location = new System.Drawing.Point(551, 39);
            this.cmbVisualizzarticoli.Name = "cmbVisualizzarticoli";
            this.cmbVisualizzarticoli.Size = new System.Drawing.Size(151, 28);
            this.cmbVisualizzarticoli.TabIndex = 2;
            this.cmbVisualizzarticoli.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 20;
            this.lsbLista.Location = new System.Drawing.Point(551, 107);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(224, 304);
            this.lsbLista.TabIndex = 3;
            this.lsbLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbLista);
            this.Controls.Add(this.cmbVisualizzarticoli);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gpbDettagliarticolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDettagliarticolo.ResumeLayout(false);
            this.gpbDettagliarticolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDettagliarticolo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblUnitadimisura;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbUnitadimisura;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ComboBox cmbVisualizzarticoli;
        private System.Windows.Forms.ListBox lsbLista;
    }
}

