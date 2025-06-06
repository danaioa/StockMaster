namespace StockMaster
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
            this.dataGridProduse = new System.Windows.Forms.DataGridView();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnBucatarie = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnAfisareProduse = new System.Windows.Forms.Button();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.afișareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificaCantitate = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtidCTG = new System.Windows.Forms.TextBox();
            this.txtDescriereProdus = new System.Windows.Forms.TextBox();
            this.btnNume = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnDescriere = new System.Windows.Forms.Button();
            this.btnCantitate = new System.Windows.Forms.Button();
            this.btnPret = new System.Windows.Forms.Button();
            this.numeCantitate = new System.Windows.Forms.TextBox();
            this.PretProdus = new System.Windows.Forms.NumericUpDown();
            this.btnSalveazaProdusNou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeHotel = new System.Windows.Forms.Label();
            this.btnStoc = new System.Windows.Forms.Button();
            this.btnInapoiLogare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretProdus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduse
            // 
            this.dataGridProduse.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduse.Location = new System.Drawing.Point(92, 282);
            this.dataGridProduse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProduse.Name = "dataGridProduse";
            this.dataGridProduse.RowHeadersWidth = 51;
            this.dataGridProduse.RowTemplate.Height = 24;
            this.dataGridProduse.Size = new System.Drawing.Size(749, 240);
            this.dataGridProduse.TabIndex = 0;
            this.dataGridProduse.Visible = false;
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.Color.Thistle;
            this.btnBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBar.ForeColor = System.Drawing.Color.Purple;
            this.btnBar.Location = new System.Drawing.Point(63, 142);
            this.btnBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(143, 33);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = " Bar";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnBucatarie
            // 
            this.btnBucatarie.BackColor = System.Drawing.Color.Thistle;
            this.btnBucatarie.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucatarie.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnBucatarie.Location = new System.Drawing.Point(60, 95);
            this.btnBucatarie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBucatarie.Name = "btnBucatarie";
            this.btnBucatarie.Size = new System.Drawing.Size(145, 42);
            this.btnBucatarie.TabIndex = 3;
            this.btnBucatarie.Text = " Bucătărie";
            this.btnBucatarie.UseVisualStyleBackColor = false;
            this.btnBucatarie.Click += new System.EventHandler(this.btnBucatarie_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(12, 12);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(104, 23);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAfisareProduse
            // 
            this.btnAfisareProduse.BackColor = System.Drawing.Color.Thistle;
            this.btnAfisareProduse.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAfisareProduse.ForeColor = System.Drawing.Color.Purple;
            this.btnAfisareProduse.Location = new System.Drawing.Point(228, 95);
            this.btnAfisareProduse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfisareProduse.Name = "btnAfisareProduse";
            this.btnAfisareProduse.Size = new System.Drawing.Size(123, 41);
            this.btnAfisareProduse.TabIndex = 5;
            this.btnAfisareProduse.Text = "Afișare Produse";
            this.btnAfisareProduse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAfisareProduse.UseVisualStyleBackColor = false;
            this.btnAfisareProduse.Click += new System.EventHandler(this.btnAfisareProduse_Click_1);
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.Thistle;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaProdus.ForeColor = System.Drawing.Color.Purple;
            this.btnAdaugaProdus.Location = new System.Drawing.Point(372, 95);
            this.btnAdaugaProdus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(128, 39);
            this.btnAdaugaProdus.TabIndex = 6;
            this.btnAdaugaProdus.Text = "Adaugă produse";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // afișareProduseToolStripMenuItem
            // 
            this.afișareProduseToolStripMenuItem.Name = "afișareProduseToolStripMenuItem";
            this.afișareProduseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnModificaCantitate
            // 
            this.btnModificaCantitate.BackColor = System.Drawing.Color.Thistle;
            this.btnModificaCantitate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificaCantitate.ForeColor = System.Drawing.Color.Purple;
            this.btnModificaCantitate.Location = new System.Drawing.Point(521, 95);
            this.btnModificaCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificaCantitate.Name = "btnModificaCantitate";
            this.btnModificaCantitate.Size = new System.Drawing.Size(152, 42);
            this.btnModificaCantitate.TabIndex = 8;
            this.btnModificaCantitate.Text = "Modifică Cantitatea";
            this.btnModificaCantitate.UseVisualStyleBackColor = false;
            this.btnModificaCantitate.Click += new System.EventHandler(this.btnModificaCantitate_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCautare.Location = new System.Drawing.Point(228, 150);
            this.txtCautare.Margin = new System.Windows.Forms.Padding(4);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(337, 22);
            this.txtCautare.TabIndex = 9;
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.Thistle;
            this.btnCautare.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautare.ForeColor = System.Drawing.Color.Purple;
            this.btnCautare.Location = new System.Drawing.Point(573, 145);
            this.btnCautare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(136, 30);
            this.btnCautare.TabIndex = 10;
            this.btnCautare.Text = "Căutare";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(55, 236);
            this.txtNumeProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(132, 22);
            this.txtNumeProdus.TabIndex = 12;
            this.txtNumeProdus.Visible = false;
            // 
            // txtidCTG
            // 
            this.txtidCTG.Location = new System.Drawing.Point(196, 236);
            this.txtidCTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtidCTG.Name = "txtidCTG";
            this.txtidCTG.Size = new System.Drawing.Size(132, 22);
            this.txtidCTG.TabIndex = 13;
            this.txtidCTG.Visible = false;
            // 
            // txtDescriereProdus
            // 
            this.txtDescriereProdus.Location = new System.Drawing.Point(355, 236);
            this.txtDescriereProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriereProdus.Name = "txtDescriereProdus";
            this.txtDescriereProdus.Size = new System.Drawing.Size(132, 22);
            this.txtDescriereProdus.TabIndex = 14;
            this.txtDescriereProdus.Visible = false;
            // 
            // btnNume
            // 
            this.btnNume.BackColor = System.Drawing.Color.Thistle;
            this.btnNume.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNume.ForeColor = System.Drawing.Color.Purple;
            this.btnNume.Location = new System.Drawing.Point(55, 201);
            this.btnNume.Margin = new System.Windows.Forms.Padding(4);
            this.btnNume.Name = "btnNume";
            this.btnNume.Size = new System.Drawing.Size(125, 28);
            this.btnNume.TabIndex = 15;
            this.btnNume.Text = "Nume Produs";
            this.btnNume.UseVisualStyleBackColor = false;
            this.btnNume.Visible = false;
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.Thistle;
            this.btnCategorie.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCategorie.ForeColor = System.Drawing.Color.Purple;
            this.btnCategorie.Location = new System.Drawing.Point(208, 201);
            this.btnCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(104, 28);
            this.btnCategorie.TabIndex = 16;
            this.btnCategorie.Text = "Categorie";
            this.btnCategorie.UseVisualStyleBackColor = false;
            this.btnCategorie.Visible = false;
            // 
            // btnDescriere
            // 
            this.btnDescriere.BackColor = System.Drawing.Color.Thistle;
            this.btnDescriere.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDescriere.ForeColor = System.Drawing.Color.Purple;
            this.btnDescriere.Location = new System.Drawing.Point(355, 201);
            this.btnDescriere.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescriere.Name = "btnDescriere";
            this.btnDescriere.Size = new System.Drawing.Size(121, 28);
            this.btnDescriere.TabIndex = 17;
            this.btnDescriere.Text = "Descriere";
            this.btnDescriere.UseVisualStyleBackColor = false;
            this.btnDescriere.Visible = false;
            // 
            // btnCantitate
            // 
            this.btnCantitate.BackColor = System.Drawing.Color.Thistle;
            this.btnCantitate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCantitate.ForeColor = System.Drawing.Color.Purple;
            this.btnCantitate.Location = new System.Drawing.Point(507, 201);
            this.btnCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCantitate.Name = "btnCantitate";
            this.btnCantitate.Size = new System.Drawing.Size(116, 28);
            this.btnCantitate.TabIndex = 18;
            this.btnCantitate.Text = "Cantitate";
            this.btnCantitate.UseVisualStyleBackColor = false;
            this.btnCantitate.Visible = false;
            // 
            // btnPret
            // 
            this.btnPret.BackColor = System.Drawing.Color.Thistle;
            this.btnPret.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPret.ForeColor = System.Drawing.Color.Purple;
            this.btnPret.Location = new System.Drawing.Point(667, 201);
            this.btnPret.Margin = new System.Windows.Forms.Padding(4);
            this.btnPret.Name = "btnPret";
            this.btnPret.Size = new System.Drawing.Size(120, 30);
            this.btnPret.TabIndex = 19;
            this.btnPret.Text = "Pret";
            this.btnPret.UseVisualStyleBackColor = false;
            this.btnPret.Visible = false;
            // 
            // numeCantitate
            // 
            this.numeCantitate.Location = new System.Drawing.Point(507, 236);
            this.numeCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.numeCantitate.Name = "numeCantitate";
            this.numeCantitate.Size = new System.Drawing.Size(132, 22);
            this.numeCantitate.TabIndex = 20;
            this.numeCantitate.Visible = false;
            // 
            // PretProdus
            // 
            this.PretProdus.Location = new System.Drawing.Point(667, 238);
            this.PretProdus.Margin = new System.Windows.Forms.Padding(4);
            this.PretProdus.Name = "PretProdus";
            this.PretProdus.Size = new System.Drawing.Size(160, 22);
            this.PretProdus.TabIndex = 24;
            this.PretProdus.Visible = false;
            // 
            // btnSalveazaProdusNou
            // 
            this.btnSalveazaProdusNou.BackColor = System.Drawing.Color.Thistle;
            this.btnSalveazaProdusNou.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveazaProdusNou.ForeColor = System.Drawing.Color.Purple;
            this.btnSalveazaProdusNou.Location = new System.Drawing.Point(807, 201);
            this.btnSalveazaProdusNou.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalveazaProdusNou.Name = "btnSalveazaProdusNou";
            this.btnSalveazaProdusNou.Size = new System.Drawing.Size(124, 28);
            this.btnSalveazaProdusNou.TabIndex = 23;
            this.btnSalveazaProdusNou.Text = "Salveaza";
            this.btnSalveazaProdusNou.UseVisualStyleBackColor = false;
            this.btnSalveazaProdusNou.Visible = false;
            this.btnSalveazaProdusNou.Click += new System.EventHandler(this.btnSalveazaProdusNou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(313, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "StockMaster";
            // 
            // lblNumeHotel
            // 
            this.lblNumeHotel.AutoSize = true;
            this.lblNumeHotel.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumeHotel.ForeColor = System.Drawing.Color.Purple;
            this.lblNumeHotel.Location = new System.Drawing.Point(558, 12);
            this.lblNumeHotel.Name = "lblNumeHotel";
            this.lblNumeHotel.Size = new System.Drawing.Size(112, 52);
            this.lblNumeHotel.TabIndex = 26;
            this.lblNumeHotel.Text = "label2";
            this.lblNumeHotel.Click += new System.EventHandler(this.lblNumeHotel_Click);
            // 
            // btnStoc
            // 
            this.btnStoc.BackColor = System.Drawing.Color.Thistle;
            this.btnStoc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStoc.ForeColor = System.Drawing.Color.Purple;
            this.btnStoc.Location = new System.Drawing.Point(732, 95);
            this.btnStoc.Name = "btnStoc";
            this.btnStoc.Size = new System.Drawing.Size(95, 34);
            this.btnStoc.TabIndex = 27;
            this.btnStoc.Text = "Stoc";
            this.btnStoc.UseVisualStyleBackColor = false;
            this.btnStoc.Visible = false;
            this.btnStoc.Click += new System.EventHandler(this.btnStoc_Click);
            // 
            // btnInapoiLogare
            // 
            this.btnInapoiLogare.Location = new System.Drawing.Point(12, 12);
            this.btnInapoiLogare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoiLogare.Name = "btnInapoiLogare";
            this.btnInapoiLogare.Size = new System.Drawing.Size(104, 23);
            this.btnInapoiLogare.TabIndex = 28;
            this.btnInapoiLogare.Text = "Înapoi";
            this.btnInapoiLogare.UseVisualStyleBackColor = true;
            this.btnInapoiLogare.Click += new System.EventHandler(this.btnInapoiLogare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(971, 535);
            this.Controls.Add(this.btnInapoiLogare);
            this.Controls.Add(this.btnStoc);
            this.Controls.Add(this.lblNumeHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalveazaProdusNou);
            this.Controls.Add(this.PretProdus);
            this.Controls.Add(this.numeCantitate);
            this.Controls.Add(this.btnPret);
            this.Controls.Add(this.btnCantitate);
            this.Controls.Add(this.btnDescriere);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.btnNume);
            this.Controls.Add(this.txtDescriereProdus);
            this.Controls.Add(this.txtidCTG);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.btnModificaCantitate);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.btnAfisareProduse);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnBucatarie);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.dataGridProduse);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretProdus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduse;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnBucatarie;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnAfisareProduse;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.ToolStripMenuItem afișareProduseToolStripMenuItem;
        private System.Windows.Forms.Button btnModificaCantitate;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtidCTG;
        private System.Windows.Forms.TextBox txtDescriereProdus;
        private System.Windows.Forms.Button btnNume;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnDescriere;
        private System.Windows.Forms.Button btnCantitate;
        private System.Windows.Forms.Button btnPret;
        private System.Windows.Forms.TextBox numeCantitate;
        private System.Windows.Forms.NumericUpDown PretProdus;
        private System.Windows.Forms.Button btnSalveazaProdusNou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeHotel;
        private System.Windows.Forms.Button btnStoc;
        private System.Windows.Forms.Button btnInapoiLogare;
    }
}

