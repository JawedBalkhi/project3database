namespace database_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Zoekknop = new System.Windows.Forms.Button();
            this.LabelDatum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelLoc = new System.Windows.Forms.Label();
            this.ComboLoc = new System.Windows.Forms.ComboBox();
            this.ComboZoek = new System.Windows.Forms.ComboBox();
            this.TextTot = new System.Windows.Forms.TextBox();
            this.TextVan = new System.Windows.Forms.TextBox();
            this.LabelIkzoek = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Zoekknop);
            this.splitContainer1.Panel1.Controls.Add(this.LabelDatum);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.LabelLoc);
            this.splitContainer1.Panel1.Controls.Add(this.ComboLoc);
            this.splitContainer1.Panel1.Controls.Add(this.ComboZoek);
            this.splitContainer1.Panel1.Controls.Add(this.TextTot);
            this.splitContainer1.Panel1.Controls.Add(this.TextVan);
            this.splitContainer1.Panel1.Controls.Add(this.LabelIkzoek);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1481, 529);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // Zoekknop
            // 
            this.Zoekknop.Location = new System.Drawing.Point(310, 332);
            this.Zoekknop.Name = "Zoekknop";
            this.Zoekknop.Size = new System.Drawing.Size(75, 23);
            this.Zoekknop.TabIndex = 10;
            this.Zoekknop.Text = "Zoeken";
            this.Zoekknop.UseVisualStyleBackColor = true;
            this.Zoekknop.Click += new System.EventHandler(this.zoekknop_Click);
            // 
            // LabelDatum
            // 
            this.LabelDatum.AutoSize = true;
            this.LabelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatum.Location = new System.Drawing.Point(56, 208);
            this.LabelDatum.Name = "LabelDatum";
            this.LabelDatum.Size = new System.Drawing.Size(81, 25);
            this.LabelDatum.TabIndex = 9;
            this.LabelDatum.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Van";
            // 
            // LabelLoc
            // 
            this.LabelLoc.AutoSize = true;
            this.LabelLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoc.Location = new System.Drawing.Point(56, 147);
            this.LabelLoc.Name = "LabelLoc";
            this.LabelLoc.Size = new System.Drawing.Size(89, 25);
            this.LabelLoc.TabIndex = 6;
            this.LabelLoc.Text = "Locatie:";
            // 
            // ComboLoc
            // 
            this.ComboLoc.FormattingEnabled = true;
            this.ComboLoc.Items.AddRange(new object[] {
            "Feijenoord",
            "IJsselmonde",
            "Charlois",
            "Waalhaven",
            "Delfshaven",
            "Centrum",
            "Kralingen- Crooswijk",
            "Prins Alexander",
            "Overschie",
            "Hillegersberg- schiebroek",
            "Rotterdam - Noord"});
            this.ComboLoc.Location = new System.Drawing.Point(310, 141);
            this.ComboLoc.Name = "ComboLoc";
            this.ComboLoc.Size = new System.Drawing.Size(121, 24);
            this.ComboLoc.TabIndex = 5;
            // 
            // ComboZoek
            // 
            this.ComboZoek.FormattingEnabled = true;
            this.ComboZoek.Items.AddRange(new object[] {
            "Markten",
            "Sportactiviteiten",
            "Zalen"});
            this.ComboZoek.Location = new System.Drawing.Point(310, 39);
            this.ComboZoek.Name = "ComboZoek";
            this.ComboZoek.Size = new System.Drawing.Size(121, 24);
            this.ComboZoek.TabIndex = 4;
            // 
            // TextTot
            // 
            this.TextTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTot.Location = new System.Drawing.Point(310, 265);
            this.TextTot.Name = "TextTot";
            this.TextTot.Size = new System.Drawing.Size(121, 30);
            this.TextTot.TabIndex = 3;
            // 
            // TextVan
            // 
            this.TextVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVan.Location = new System.Drawing.Point(310, 229);
            this.TextVan.Name = "TextVan";
            this.TextVan.Size = new System.Drawing.Size(121, 30);
            this.TextVan.TabIndex = 2;
            // 
            // LabelIkzoek
            // 
            this.LabelIkzoek.AutoSize = true;
            this.LabelIkzoek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIkzoek.Location = new System.Drawing.Point(51, 38);
            this.LabelIkzoek.Name = "LabelIkzoek";
            this.LabelIkzoek.Size = new System.Drawing.Size(209, 25);
            this.LabelIkzoek.TabIndex = 1;
            this.LabelIkzoek.Text = "Ik ben op zoek naar:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(984, 529);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label LabelIkzoek;
        private System.Windows.Forms.Label LabelDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelLoc;
        private System.Windows.Forms.ComboBox ComboLoc;
        private System.Windows.Forms.ComboBox ComboZoek;
        private System.Windows.Forms.TextBox TextTot;
        private System.Windows.Forms.TextBox TextVan;
        private System.Windows.Forms.Button Zoekknop;
    }
}

