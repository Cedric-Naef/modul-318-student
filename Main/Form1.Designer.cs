namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Von = new System.Windows.Forms.Label();
            this.label_Bis = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ListAusgabe = new System.Windows.Forms.ListBox();
            this.LableWarnung = new System.Windows.Forms.Label();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.textBoxBis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Von
            // 
            this.label_Von.AutoSize = true;
            this.label_Von.Location = new System.Drawing.Point(81, 39);
            this.label_Von.Name = "label_Von";
            this.label_Von.Size = new System.Drawing.Size(37, 17);
            this.label_Von.TabIndex = 1;
            this.label_Von.Text = "Von:";
            // 
            // label_Bis
            // 
            this.label_Bis.AutoSize = true;
            this.label_Bis.Location = new System.Drawing.Point(81, 82);
            this.label_Bis.Name = "label_Bis";
            this.label_Bis.Size = new System.Drawing.Size(31, 17);
            this.label_Bis.TabIndex = 2;
            this.label_Bis.Text = "Bis:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(84, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(344, 55);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Verbindungen suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ListAusgabe
            // 
            this.ListAusgabe.FormattingEnabled = true;
            this.ListAusgabe.ItemHeight = 16;
            this.ListAusgabe.Location = new System.Drawing.Point(84, 228);
            this.ListAusgabe.Name = "ListAusgabe";
            this.ListAusgabe.Size = new System.Drawing.Size(588, 276);
            this.ListAusgabe.TabIndex = 10;
            // 
            // LableWarnung
            // 
            this.LableWarnung.AutoSize = true;
            this.LableWarnung.ForeColor = System.Drawing.Color.Red;
            this.LableWarnung.Location = new System.Drawing.Point(434, 42);
            this.LableWarnung.Name = "LableWarnung";
            this.LableWarnung.Size = new System.Drawing.Size(203, 17);
            this.LableWarnung.TabIndex = 11;
            this.LableWarnung.Text = "Dieses Feld darf nicht leer sein";
            this.LableWarnung.Visible = false;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SwissTransport.Transport);
            // 
            // textBoxVon
            // 
            this.textBoxVon.Location = new System.Drawing.Point(125, 39);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(303, 22);
            this.textBoxVon.TabIndex = 13;
            this.textBoxVon.TextChanged += new System.EventHandler(this.textBoxVon_TextChanged);
            // 
            // textBoxBis
            // 
            this.textBoxBis.Location = new System.Drawing.Point(125, 79);
            this.textBoxBis.Name = "textBoxBis";
            this.textBoxBis.Size = new System.Drawing.Size(303, 22);
            this.textBoxBis.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 566);
            this.Controls.Add(this.textBoxBis);
            this.Controls.Add(this.textBoxVon);
            this.Controls.Add(this.LableWarnung);
            this.Controls.Add(this.ListAusgabe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label_Bis);
            this.Controls.Add(this.label_Von);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Von;
        private System.Windows.Forms.Label label_Bis;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox ListAusgabe;
        private System.Windows.Forms.Label LableWarnung;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBoxBis;
    }
}

